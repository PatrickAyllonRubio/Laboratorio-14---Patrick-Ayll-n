using Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Infrastructure.Configuration;
using Microsoft.OpenApi.Models;

namespace Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Api.Configuration;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        services.AddInfrastructureServices();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "ArchitectureHexagonal", Version = "v1" });
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme 
            {
                In = ParameterLocation.Header,
                Description = "Por favor, introduzca un token válido",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });
        
        return services;
    }
}