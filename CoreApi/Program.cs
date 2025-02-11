using CoreApi.Models;
using CoreApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar el servicio HTTP
builder.Services.AddHttpClient<UserService>();
builder.Services.AddHttpClient<SerieMarvelService>();

// Agregar controladores
builder.Services.AddControllers();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MarvelApiOptions>(builder.Configuration.GetSection("MarvelApi"));


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
