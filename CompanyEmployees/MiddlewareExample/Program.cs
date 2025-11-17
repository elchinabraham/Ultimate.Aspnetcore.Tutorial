var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    Console.WriteLine("Custom Middleware: Incoming Request");
    await next.Invoke();
    Console.WriteLine("Custom Middleware: Outgoing Response");
});

app.MapWhen(context => context.Request.Query.ContainsKey("name"), builder =>
{
    builder.Run(async context =>
    {
        await context.Response.WriteAsync("Hello, " + context.Request.Query["name"]);
    });
});

app.Map("/usingmapbranch", builder =>
{
    builder.Use(async (context, next) =>
    {
        Console.WriteLine("Middleware in /usingmapbranch: Before Next");
        await next.Invoke();
        Console.WriteLine("Middleware in /usingmapbranch: After Next");
    });

    builder.Run(async context =>
    {
        Console.WriteLine("Handling request in /usingmapbranch");
        await context.Response.WriteAsync("Hello from /usingmapbranch!");
    });
});


app.Run(async context =>
{
    Console.WriteLine($"Writing the response to the client in the Run method");
    await context.Response.WriteAsync("Hello from the middleware component.");
});


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello from custom middleware!");
//});

app.MapControllers();

app.Run();
