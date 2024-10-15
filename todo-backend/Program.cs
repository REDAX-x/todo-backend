using Microsoft.Extensions.Options;
using todo_backend.Database_Context;
using todo_backend.Models;


// Add services to the container.




var app = WebApplication.CreateBuilder(args).Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();

