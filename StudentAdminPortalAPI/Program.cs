using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.Models;
using StudentAdminPortalAPI.Repositories;
using StudentAdminPortalAPI.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext configuration
var connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<StudentAdminContext>(options =>
options.UseSqlServer(connectionStrings));

//AutoMapper Service
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<IStudentRepository, StudentRepository>();


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
