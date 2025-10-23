var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files if you add any later
app.UseDefaultFiles();
app.UseStaticFiles();

// Main page route
app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html>
<head>
  <meta charset='UTF-8'>
  <title>Simple APP of Escanor/title>
  <h3>In the magical C we see you h3</h3>
            <br><br><br>
            <h4> This is staging </h4> 
  <style>
    body {
      font-family: Arial, sans-serif;
      text-align: center;
      margin-top: 100px;
    }
    button {
      background-color: #0078D7;
      color: white;
      border: none;
      padding: 12px 24px;
      border-radius: 6px;
      font-size: 16px;
      cursor: pointer;
      transition: background-color 0.3s;
    }
    button:hover {
      background-color: #005A9E;
    }
  </style>
</head>
<body>
  <h1>Hello from .NET 8 on Azure!</h1>
  <p>Click the button below to view the image stored in Azure Blob Storage.</p>
  <button onclick=""window.open('https://cbazclistorage.blob.core.windows.net/webstorage/bandit.jpeg', '_blank')"">
    View Bandit Image
  </button>
</body>
</html>
", "text/html"));

app.Run();
