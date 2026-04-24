var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new
        {
            id = 1,
            nombre = "Portátil",
            precio = 1200.50,
            stock = 25,
            categoria = new { id = 101, nombre = "Electrónica" }
        },
        new
        {
            id = 2,
            nombre = "Auriculares",
            precio = 50.00,
            stock = 100,
            categoria = new { id = 102, nombre = "Accesorios" }
        }
    };
});

app.Run();