using Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Infrastructure.Services.Export;
using Microsoft.Extensions.DependencyInjection;

namespace Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Infrastructure.Configuration;

public static class InfrastructureServicesExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services) 
    { 
    
        
        //services.AddTransient<IUnitOfWork, UnitOfWork>();
        //services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
        services.AddScoped<ExcelExportService>();
        
        
        return services;
    }
}