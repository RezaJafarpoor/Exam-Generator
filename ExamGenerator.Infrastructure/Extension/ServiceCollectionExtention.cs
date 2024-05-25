using ExamGenerator.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace ExamGenerator.Infrastructure.Extension;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        
        services.AddDbContext<ExamGeneratorDbContext>();
    }
    
}