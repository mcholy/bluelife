using Contracts;
using Contracts.IRepository;
using Contracts.IService;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository;
using Serilog;
using Service;

namespace BlueLife.Extensions
{
    public static class ServiceExtensions
    {

        #region Constants
        private const string _CORS_VALUE = "CorsPolicy";
        private const string _DB_CONNECTION = "DefaultConnection";
        #endregion

        #region Methods
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(opt =>
            {
                opt.AddPolicy(_CORS_VALUE, builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("X-Pagination"));
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(opt => { });

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
            options.UseMySql(configuration.GetConnectionString(_DB_CONNECTION),
            ServerVersion.AutoDetect(configuration.GetConnectionString(_DB_CONNECTION)),
            b => b.MigrationsAssembly("BlueLife")));

        public static void ConfigureSerilog(this IHostBuilder hostBuilder) =>
            hostBuilder.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration));

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
        #endregion
    }
}
