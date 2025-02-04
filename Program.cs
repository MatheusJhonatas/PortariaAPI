using PortariaAPI.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PortariaDataContext>();
var app = builder.Build();

app.MapGet("/", () => " Heloo World");

app.Run();
