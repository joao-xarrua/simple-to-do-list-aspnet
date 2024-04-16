using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // adiciona controllers

// cria a conexão e passa a utilizar AppDbContext como serviço podendo ser utilizado em outros arquivos
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers(); // mapeia controllers

app.Run();
