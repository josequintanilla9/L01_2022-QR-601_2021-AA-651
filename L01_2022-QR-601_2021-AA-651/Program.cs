using Microsoft.EntityFrameworkCore;
using L01_2022_QR_601_2021_AA_651.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Inyeccion de conexion 
builder.Services.AddDbContext<restauranteContext>(options =>
        options.UseSqlServer(
                builder.Configuration.GetConnectionString("restauranteDbConnection")
                )
);


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
