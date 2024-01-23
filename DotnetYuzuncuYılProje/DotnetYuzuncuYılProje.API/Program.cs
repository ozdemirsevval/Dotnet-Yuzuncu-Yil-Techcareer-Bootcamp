using DotnetYuzuncuYilProje.Core.Repositeries;
using DotnetYuzuncuYilProje.Core.Services;
using DotnetYuzuncuYilProje.Core.UnitOfWorks;
using DotnetYuzuncuYilProje.Repository;
using DotnetYuzuncuYilProje.Repository.Repositories;
using DotnetYuzuncuYilProje.Repository.UnitOfWorks;
using DotnetYuzuncuYilProje.Service;
using DotnetYuzuncuYilProje.Service.Mapping;
using DotnetYuzuncuYilProje.Service.Validations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfie));
builder.Services.AddControllers()
    .AddFluentValidation(x =>
    {
        x.RegisterValidatorsFromAssemblyContaining<MovieDtoValidator>();
        x.RegisterValidatorsFromAssemblyContaining<AudienceDtoValidator>();
    });
//AppDbContext ��lemleri
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

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
