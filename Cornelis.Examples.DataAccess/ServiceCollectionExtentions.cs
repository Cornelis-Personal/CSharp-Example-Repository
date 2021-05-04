using Cornelis.Examples.DataAccess.Repositories.Interfaces;
using Cornelis.Examples.DataAccess.Repositories.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cornelis.Examples.DataAccess
{
    /// <summary>
    /// IServiceCollection extention methods that help keep
    /// classes/projects clean and independent of each other.
    /// </summary>
    public static class ServiceCollectionExtentions
    {
        /// <summary>
        /// Register a SQL Database/Context.
        ///
        /// This axample contains different elements which might not always be used in the same function,
        /// as it may causeses clashes with multiple SQL database contexts if multiple is added.
        ///
        /// However, it does showcase what can be done if needed.
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="services"></param>
        /// <param name="connectionString"></param>
        /// <param name="serviceLifetime"> This is an optional field as normally a context is scoped, but can change depending on requirements.</param>
        /// <returns></returns>
        public static IServiceCollection RegisterSQLContext<TContext>(this IServiceCollection services, string connectionString, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
                where TContext : DbContext => services
            .AddDbContext<TContext>(options => options.UseSqlServer(
                connectionString,
                // We don't want to the Migrations to be added to the calling project, we want it to be accessible from all other projects.
                actions => actions.MigrationsAssembly("Cornelis.Examples.DataAccess")
                ), serviceLifetime);

        /// <summary>
        /// We his this function to register the repoistories.
        ///
        /// Again we seperate this into it's own extention method to keep any Startup.cs project files clear,
        /// and to keep it localized within the project.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterRepositories(this IServiceCollection services) => services
            .AddScoped<IAnimalRepository, AnimalRepository>()
            .AddScoped<IPlantRepository, PlantRepository>()
            .AddScoped<IAnimalPlantHistoryRepository, AnimalPlantHistoryRepository>()
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IRoleRepository, RoleRepository>()
            ;
    }
}