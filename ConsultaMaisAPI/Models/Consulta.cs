namespace ConsultaMaisAPI.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
    }
}
