using CleanArchitectureUtility.Extensions.Translations.Parrot.Extensions.DependencyInjection;

namespace KevinTemplate.Endpoints.WebApi.Extensions;

public static class PipelineExtension
{
    public static IServiceCollection AddParrotTranslator(this IServiceCollection services, string connectionString)
        => services.AddParrotTranslator(c =>
        {
            c.ConnectionString = connectionString;
            c.AutoCreateSqlTable = true;
            c.SchemaName = "dbo";
            c.TableName = "ParrotTranslations";
            c.ReloadDataIntervalInMinutes = 1;
        });
}