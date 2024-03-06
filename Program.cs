using Apiemployee.Models;
using Apiemployee.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<EmployeeStoreDatabaseSetting>(builder.Configuration.GetSection(nameof(EmployeeStoreDatabaseSetting)));

builder.Services.AddSingleton<IEmployeeStoreDatabaseSetting>(sp => sp.GetRequiredService<IOptions<EmployeeStoreDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("EmployeeStoreDatabaseSetting:ConnectionString")));

builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();

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
