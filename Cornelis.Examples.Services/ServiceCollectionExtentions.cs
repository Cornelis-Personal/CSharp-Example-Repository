using Cornelis.Examples.Services.Interfaces;
using Cornelis.Examples.Services.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Cornelis.Examples.Services
{
    /// <summary>
    /// Same purpose as the ServiceCollectionExtentions in the data access layer.
    /// See that one for a full list of comments and explination in this example.
    /// </summary>
    public static class ServiceCollectionExtentions
    {
        /// <summary>
        /// A function that allows dependency injection on the classes in the service
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services) => services
            // Register Scoped Services
            .AddScoped<IAnimalManagementService, AnimalManagementService>()
            .AddScoped<IPermissionsService, PermissionsService>()
            ;

        public static IServiceCollection RegisterNonRepositoryServices(this IServiceCollection services) => services
            .AddScoped<ITranslationService, TranslationService>();
        /// <summary>
        ///Register the logger service.
        /// </summary>
        /// <param name="serivces"></param>
        /// <param name="logFile"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterLogger(this IServiceCollection serivces, string logFile) => serivces
            .AddScoped<ILoggerService>(provider => new LoggerService(logFile));
    }
}