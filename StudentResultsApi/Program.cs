using StudentResultsApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ResultService>();

var app = builder.Build();

app.MapGet("/api/results/{student}", (string student, ResultService service) =>
{
    return Results.Ok(service.GetResult(student));
});

app.Run();

public partial class Program { }
