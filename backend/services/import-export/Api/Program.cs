using Api.Domain;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/importitems", () => "Hello World!");
app.MapGet("/api/importitems/{id}", (string id) => "Hello World!");
app.MapDelete("/api/importitems/{id}", (string id) => "Hello World!");
app.MapPost("/api/importitems", (ImportItem item) => "Hello World!");
app.MapPut("/api/importitems/{id}", ([FromRoute] string id, [FromBody] ImportItem item) => "Hello World!");

app.Run();
