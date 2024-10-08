using FraudWatch.Application.Interfaces;
using FraudWatch.Application.Mappings;
using FraudWatch.Application.Services;
using FraudWatch.Domain.Entities;
using FraudWatch.Infraestructure.Data.Repositories;
using FraudWatch_CadastroUsuarios.Infraestructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MapperProfile));

// Add services to the container.

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IDentistaRepository, DentistaRepository>();
builder.Services.AddTransient<IAnalistaRepository, AnalistaRepository>();

builder.Services.AddScoped<IDentistaApplicationService, DentistaApplicationService>();
builder.Services.AddScoped<IAnalistaApplicationService, AnalistaApplicationService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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