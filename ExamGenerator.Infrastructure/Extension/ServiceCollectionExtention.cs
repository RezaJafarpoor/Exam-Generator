using ExamGenerator.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamGenerator.Infrastructure.Extension;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
       var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ExamGeneratorDbContext>(opt => opt.UseNpgsql(connectionString));
    }
    
}