using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Wearemm.Catalog.Database;
using Wearemm.Catalog.Extensions;
using Wearemm.Catalog.Features.Genres.CreateGenre;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.  

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle  
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.AddNpgsqlDbContext<CatalogDbContext>(connectionName: "postgresdb");

builder.Services.AddValidatorsFromAssemblyContaining<CreateGenreValidator>();

var app = builder.Build();

app.MapDefaultEndpoints();
app.MapEndpoints();

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
