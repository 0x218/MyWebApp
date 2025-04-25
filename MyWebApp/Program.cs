//Program.cs

//added to demo CI/CD
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple API endpoint
app.MapGet("/greet/{name}", (string name) =>
{
    var message = GreetingService.Greet(name);
    return Results.Ok(message);
});

app.Run();

// Business logic class
public static class GreetingService
{
    public static string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}
