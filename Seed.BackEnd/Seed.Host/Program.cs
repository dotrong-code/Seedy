
using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure.DB;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SeedContext>(opt =>
{
    // Set up your database connection string
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MyDb"));
});
// Add services to the container.

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
