using AspNetCoreRateLimit;
using Contracts;
using Contracts.IRepository;
using Contracts.IService;
using Entities.ConfigurationModels;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using Repository;
using Serilog;
using Service;
using System.Runtime.InteropServices;
using System.Text;

namespace BlueLife.Extensions
{
    public static class ServiceExtensions
    {
        #region Methods
        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            var generalConfiguration = new GeneralConfiguration();
            configuration.Bind(generalConfiguration.Section, generalConfiguration);
            services.AddCors(opt =>
            {
                opt.AddPolicy(generalConfiguration.CorsPolicyName!, builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("X-Pagination"));
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(opt => { });

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var generalConfiguration = new GeneralConfiguration();
            configuration.Bind(generalConfiguration.Section, generalConfiguration);
            services.AddDbContext<RepositoryContext>(options =>
            options.UseMySql(configuration.GetConnectionString(generalConfiguration.ConnectionStringName!),
            ServerVersion.AutoDetect(configuration.GetConnectionString(generalConfiguration.ConnectionStringName!)),
            b => b.MigrationsAssembly("BlueLife")));
        }

        public static void ConfigureSerilog(this IHostBuilder hostBuilder) =>
            hostBuilder.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration));

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureRateLimitingOptions(this IServiceCollection services)
        {
            var rateLimitRules = new List<RateLimitRule>
            {
                new RateLimitRule
                {
                    Endpoint = "*",
                    Limit = 30,
                    Period = "5m"
                }
            };

            services.Configure<IpRateLimitOptions>(opt =>
            {
                opt.GeneralRules = rateLimitRules;
            });

            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<Usuario, TipoUsuario>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtConfiguration = new JwtConfiguration();
            configuration.Bind(jwtConfiguration.Section, jwtConfiguration);
            var secretKey = Environment.GetEnvironmentVariable("SECRET")!;
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtConfiguration.ValidIssuer,
                    ValidAudience = jwtConfiguration.ValidAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }

        public static void ConfigureDataProtection(this IServiceCollection services, IWebHostEnvironment environment)
        {
            var keysDirectory = new DirectoryInfo(Path.Combine(environment.ContentRootPath, ".containers", "keys"));
            var dataProtectionBuilder = services.AddDataProtection()
            .PersistKeysToFileSystem(keysDirectory);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                dataProtectionBuilder.ProtectKeysWithDpapi();
            }
        }

        public static void ConfigureNoSqlDB(this IServiceCollection services, IConfiguration configuration)
        {
            var noSqlConfiguration = new NoSqlConfiguration();
            configuration.Bind(noSqlConfiguration.Section, noSqlConfiguration);
            services.AddSingleton<IMongoClient>(new MongoClient(configuration.GetConnectionString(noSqlConfiguration.ConnectionStringName!)));
        }
        #endregion
    }
}
