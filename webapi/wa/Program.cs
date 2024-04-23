using wa.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<CuaHangContext>();
builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
