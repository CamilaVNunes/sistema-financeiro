
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain.Interfaces.Generics;
using SistemaFinanceiro.Domain.Interfaces.ICategoria;
using SistemaFinanceiro.Domain.Interfaces.IDespesa;
using SistemaFinanceiro.Domain.Interfaces.ISistemaFinanceiro;
using SistemaFinanceiro.Domain.Interfaces.IUsuarioSistemaFinanceiro;
using SistemaFinanceiro.Entities.Entities;
using SistemaFinanceiro.Infrastructure.Config;
using SistemaFinanceiro.Infrastructure.Repositories;
using SistemaFinanceiro.Infrastructure.Repositories.Generics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBase>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ContextBase>();

builder.Services.AddSingleton(typeof(IGeneric<>), typeof(RepositoryGenerics<>));
builder.Services.AddSingleton<ICategoria, RepositorioCategoria>();
builder.Services.AddSingleton<IDespesa, RepositorioDespesa>();
builder.Services.AddSingleton<ISistemaFinanceiro, RepositorioSistemaFinanceiro>();
builder.Services.AddSingleton<IUsuarioSistemaFinanceiro, RepositorioUsuarioSistemaFinanceiro>();

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
