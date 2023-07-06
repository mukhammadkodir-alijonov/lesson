using CarShop.Api.DbContexts;
using CarShop.Api.Interfaces;
using CarShop.Api.Services;
using Microsoft.EntityFrameworkCore;
//-> Service
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAccountService, AccountService>();

//-> database
string? connectionString = builder.Configuration.GetConnectionString("database");
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

//-> Middlewares
var app = builder.Build();
app.UseStaticFiles();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
