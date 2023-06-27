using Microsoft.EntityFrameworkCore;
using openAPI.Controllers;
using openAPI.Models;
using openAPI.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<HkcontextContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HK")));
builder.Services.AddDbContext<Hkcontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HK")));
builder.Services.AddScoped<EmbeddingController>();
builder.Services.AddScoped<TurboController>();
builder.Services.AddScoped<AnswerService>();
builder.Services.AddCors(options => options.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowAll");
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
