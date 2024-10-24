using EmployeeManagement.Application.Mappings;
using EmployeeManagement.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Application.Extensions;
using EmployeeManagement.Persistence.Extensions;
using EmployeeManagement.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
         .UseLazyLoadingProxies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddRepositoryLayer();
builder.Services.AddServiceLayer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
