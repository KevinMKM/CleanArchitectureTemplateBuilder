using KevinTemplate.Endpoints.WebApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.ConfigureServices().ConfigurePipeline();
app.Run();