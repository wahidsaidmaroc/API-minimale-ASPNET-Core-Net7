using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapGet("/", () => "Hello World!");
app.MapPost("/api/echo", (string message) =>
{
    if (string.IsNullOrEmpty(message))
    {
        return Results.BadRequest(new { Error = "Message cannot be empty." });
    }
    else
    {
        return Results.Ok(new { Message = message });

    }
});

app.UseHttpsRedirection();



app.Run();
