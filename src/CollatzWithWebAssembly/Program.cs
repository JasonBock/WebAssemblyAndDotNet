using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);
var application = builder.Build();

var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".wasm"] = "application/octet-stream";

application.UseStaticFiles(new StaticFileOptions()
{
	ContentTypeProvider = provider
});

await application.RunAsync();
