using Microsoft.EntityFrameworkCore;
using PropertyAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddRazorPages(); 
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<PropertyDbContext>(options =>
    options.UseSqlite("Data Source=/Users/zhezhang/Documents/Zhe/Programming/Projects/WebApp/Kensington/Database/properties.db"));

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
