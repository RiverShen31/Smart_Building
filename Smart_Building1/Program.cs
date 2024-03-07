using Microsoft.EntityFrameworkCore;
using Smart_Building1.Data;
using Smart_Building1.Repository;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services;
using Smart_Building1.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddScoped<IApartmentService, ApartmentService>();
builder.Services.AddScoped<IApartmentRepo, ApartmentRepo>();

builder.Services.AddScoped<ICitizenService, CitizenService>();
builder.Services.AddScoped<ICitizenRepo, CitizenRepo>();

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
