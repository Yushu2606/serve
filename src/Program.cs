WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Environment.WebRootPath = builder.Environment.ContentRootPath;

WebApplication app = builder.Build();

app.UseFileServer();

app.Run();
