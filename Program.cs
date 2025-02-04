using PortariaAPI.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<PortariaDataContext>();
builder.Services.AddControllers();
var app = builder.Build();

// app.MapGet("/", () => " Heloo World");
app.MapControllers();
app.Run();
