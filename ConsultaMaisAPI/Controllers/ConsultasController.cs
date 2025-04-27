using ConsultaMaisAPI.Data;
using ConsultaMaisAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsultaMaisAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsultasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Consultas/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsulta(int id)
        {
            var consulta = await _context.Consultas
                .Include(c => c.Paciente)  // Inclui detalhes do paciente
                .Include(c => c.Medico)    // Inclui detalhes do médico
                .FirstOrDefaultAsync(c => c.Id == id);  // Busca a consulta pelo id

            if (consulta == null)
            {
                return NotFound(new { Message = "Consulta não encontrada." });
            }

            return Ok(consulta);
        }

        // POST: api/Consultas
        [HttpPost]
        public async Task<IActionResult> PostConsulta(Consulta consulta)
        {
            if (consulta == null)
            {
                return BadRequest(new { Message = "Dados inválidos." });
            }

            // Verificar se o PacienteId existe
            if (!await _context.Pacientes.AnyAsync(p => p.Id == consulta.PacienteId))
            {
                return BadRequest(new { Message = "Paciente não encontrado." });
            }

            // Verificar se o MedicoId existe
            if (!await _context.Medicos.AnyAsync(m => m.Id == consulta.MedicoId))
            {
                return BadRequest(new { Message = "Médico não encontrado." });
            }

            _context.Consultas.Add(consulta);
            await _context.SaveChangesAsync();

            // Retorna o status 201 Created com o URI para acessar o recurso recém-criado
            return CreatedAtAction(nameof(GetConsulta), new { id = consulta.Id }, consulta);
        }

        // PUT: api/Consultas/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsulta(int id, Consulta consulta)
        {
            if (id != consulta.Id)
            {
                return BadRequest(new { Message = "O ID da consulta não corresponde." });
            }

            // Verificar se o PacienteId existe
            if (!await _context.Pacientes.AnyAsync(p => p.Id == consulta.PacienteId))
            {
                return BadRequest(new { Message = "Paciente não encontrado." });
            }

            // Verificar se o MedicoId existe
            if (!await _context.Medicos.AnyAsync(m => m.Id == consulta.MedicoId))
            {
                return BadRequest(new { Message = "Médico não encontrado." });
            }

            _context.Entry(consulta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultaExists(id))
                {
                    return NotFound(new { Message = "Consulta não encontrada para atualizar." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();  // Retorna 204 No Content quando a atualização é bem-sucedida
        }

        // DELETE: api/Consultas/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsulta(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound(new { Message = "Consulta não encontrada para exclusão." });
            }

            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();

            return NoContent();  // Retorna 204 No Content quando a exclusão é bem-sucedida
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consultas.Any(e => e.Id == id);
        }
    }
}
