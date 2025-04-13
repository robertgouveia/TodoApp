using Todo.API.Extensions;
using Todo.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args).Configure();

var app = builder.Build();

app.MapControllers();

app.Run();