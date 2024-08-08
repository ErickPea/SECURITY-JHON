using Business.Implementacion;
using Business.Interface;
using Data.Implementation;
using Data.Interface;
using Entity.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configura DBContext con SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// No es necesario registrar ApplicationDbContext de nuevo
// builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddScoped<IPersonaBusiness, PersonaBusiness>();
builder.Services.AddScoped<IPersonaData, PersonaData>();
builder.Services.AddScoped<IModuloBusiness, ModuloBusiness>();
builder.Services.AddScoped<IModuloData, ModuloData>();
builder.Services.AddScoped<IRolBusiness, RolBusiness>();
builder.Services.AddScoped<IRolData, RolData>();
builder.Services.AddScoped<IVistaBusiness, VistaBusiness>();
builder.Services.AddScoped<IVistaData, VistaData>();
builder.Services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
builder.Services.AddScoped<IUsuarioData, UsuarioData>();
builder.Services.AddScoped<IUsuarioRolBusiness, UsuarioRolBusiness>();
builder.Services.AddScoped<IUsuarioRolData, UsuarioRolData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
