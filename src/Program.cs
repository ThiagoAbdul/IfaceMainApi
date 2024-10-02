using IfaceMainApi.Configurations;
using IfaceMainApi.Data;
using IfaceMainApi.Middlewares;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddHealthChecks();



var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var dbPath = Path.Join(path, "blogging.db");



//builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
//        Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") 
//        ?? builder.Configuration.GetConnectionString("DefaultConnection")
//    )
//);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite($"Data Source={dbPath}"));


builder.Services.InjectDependecies(builder.Configuration);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    var context = service.GetService<AppDbContext>();
    context?.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GlobalExceptionHandler>();

app.MapControllers();
app.UseHealthChecks("/api/Health");

app.Run();
