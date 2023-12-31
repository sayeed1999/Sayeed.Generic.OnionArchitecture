using ExampleApp1;
using Sayeed.Generic.OnionArchitecture;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registers SQLServer as database provider with generic repo & logic layer
builder.Services
    .RegisterSqlServer<AppDbContext>(builder.Configuration)
    .RegisterGenericRepositoryLayer()
    .RegisterGenericLogicLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
