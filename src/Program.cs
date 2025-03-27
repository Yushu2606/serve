using Microsoft.Extensions.FileProviders;

WebApplicationBuilder builder = WebApplication.CreateSlimBuilder(args);

WebApplication app = builder.Build();

FileServerOptions fileServerOptions = new()
{
    FileProvider = new PhysicalFileProvider(builder.Environment.ContentRootPath)
    {
        UseActivePolling = true,
        UsePollingFileWatcher = true
    }
};
fileServerOptions.StaticFileOptions.ServeUnknownFileTypes = true;

app.UseFileServer(fileServerOptions);

app.Run();
