var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () => "Forge is burning 🔥");

// Week 1: your first endpoint goes here – see docs/learning/week-01-async.md

app.Run();
