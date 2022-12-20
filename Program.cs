using Estoque.Context;
using Estoque.Repository;
using Estoque.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProdutoContext>(x => x.UseSqlServer("Server=localhost;database=dbEstoque;User ID=sa;Password=dojpM88NHC&JNAm56Z&;TrustServerCertificate=True;Encrypt=false"));
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
string gay = "Leu pq é gay";
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
