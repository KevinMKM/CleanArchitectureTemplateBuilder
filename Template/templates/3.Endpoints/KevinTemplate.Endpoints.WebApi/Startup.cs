using CleanArchitectureUtility.Endpoints.WebApi.Extensions.DependencyInjection;
using CleanArchitectureUtility.Extensions.Caching.InMemory.Extensions.DependencyInjection;
using CleanArchitectureUtility.Extensions.ObjectMappers.AutoMapper.Extensions.DependencyInjection;
using CleanArchitectureUtility.Extensions.Serializers.Microsoft.Extensions.DependencyInjection;
using CleanArchitectureUtility.Extensions.Translations.Parrot.Extensions.DependencyInjection;
using CleanArchitectureUtility.Extensions.UsersManagement.Extensions.DependencyInjection;
using KevinTemplate.Endpoints.WebApi.Extensions;
using KevinTemplate.Infra.Data.SqlCommand.Common;
using KevinTemplate.Infra.Data.SqlQuery.Common;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace KevinTemplate.Endpoints.WebApi;

public static class Startup
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("Context");
        builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
        builder.Services.AddParrotTranslator(c =>
        {
            c.ConnectionString = connectionString;
            c.AutoCreateSqlTable = true;
            c.SchemaName = "dbo";
            c.TableName = "ParrotTranslations";
            c.ReloadDataIntervalInMinutes = 1;
        });

        builder.Services.AddWebUserInfoService(builder.Configuration, true);
        builder.Services.AddAutoMapperProfiles(option => { option.AssemblyNamesForLoadProfiles = "KevinTemplate"; });
        builder.Services.AddMicrosoftSerializer();
        builder.Services.AddInMemoryCaching();
        builder.Services.AddDbContext<KevinTemplateCommandDbContext>(c => c.UseSqlServer(connectionString));
        builder.Services.AddDbContext<KevinTemplateQueryDbContext>(c => c.UseSqlServer(connectionString));
        builder.Services.AddApiCore("CleanArchitectureUtility", "KevinTemplate");
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.ConfigureMigrations();
        app.UseApiExceptionHandler();
        app.UseSerilogRequestLogging();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}