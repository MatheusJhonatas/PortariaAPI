var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddDbContext<PortariaDataContext>();
app.MapGet("/", () => "Hello World!");

app.Run();
