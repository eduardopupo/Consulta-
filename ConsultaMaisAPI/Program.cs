using ConsultaMaisAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          // Permitir acesso do frontend local (ajustar caso precise de outros domínios)
                          policy.WithOrigins("http://localhost:5173")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// Configuração do banco de dados SQLite usando Entity Framework
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));  // Usando a string de conexão do appsettings.json

// Adicionando suporte aos controladores (API)
builder.Services.AddControllers();

// Configuração do Swagger para documentar a API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Consulta+ API",
        Version = "v1",
        Description = "API para gerenciamento de consultas médicas",
    });
});

var app = builder.Build();

// Configuração do Swagger (apenas em desenvolvimento)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Consulta+ API v1");
        c.RoutePrefix = string.Empty;  // Swagger UI na raiz
    });
}

app.UseHttpsRedirection();

// Ativando o CORS
app.UseCors(MyAllowSpecificOrigins);

app.MapControllers(); // Mapeia os controladores (as rotas da API)

// Inicia a aplicação
app.Run();
