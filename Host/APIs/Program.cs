using Cqrs.Hosts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Reflection;
using TreeKnowledgeSystem.Application.Handlers;
using TreeKnowledgeSystem.Domain.Repositories;
using TreeKnowledgeSystem.Domain.Repositories.Base;
using TreeKnowledgeSystem.Infrastructure.Data;
using TreeKnowledgeSystem.Infrastructure.Repositories;
using TreeKnowledgeSystem.Infrastructure.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<TreeKnowledgeSystemContext>(m => m.UseSqlServer("Server=10.10.2.58;Database=TreeKnowledgeSystemDB;User Id=sa;password=123;Trusted_Connection=False;MultipleActiveResultSets=true;"), ServiceLifetime.Singleton);

builder.Services.AddAutoMapper(typeof(StartUp));
builder.Services.AddMediatR(typeof(CreateTreeStudentHandler).GetTypeInfo().Assembly);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<ITreeStudentRepository, TreeStudentRepository>();

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
