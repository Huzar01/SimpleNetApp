var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(@"
    <html>
        <head><title>Simple ASP.NET 8 App</title></head>
        <body style='font-family:Arial;text-align:center;margin-top:50px;'>
            <h1>Hello from .NET 8 on Azure App Service!</h1>
            <p>This is a simple test deployment.</p>
        </body>
    </html>
", "text/html"));

app.Run();