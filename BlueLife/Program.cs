using BlueLife.ActionFilters;
using BlueLife.Extensions;
using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository;

namespace BlueLife
{
    public class Program
    {
        private const string _CORS_VALUE = "CorsPolicy";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.ConfigureCors();

            builder.Services.ConfigureIISIntegration();

            builder.Host.ConfigureSerilog();

            builder.Services.ConfigureLoggerService();

            builder.Services.ConfigureDbContext(builder.Configuration);

            builder.Services.ConfigureRepositoryManager();

            builder.Services.ConfigureServiceManager();

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            builder.Services.AddScoped<ValidationFilterAttribute>();

            builder.Services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
                config.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            }).AddXmlDataContractSerializerFormatters();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<RepositoryContext>();
                dbContext.Database.Migrate();
            }

            var logger = app.Services.GetRequiredService<ILoggerManager>();
            app.ConfigureExceptionHandler(logger);

            if (app.Environment.IsProduction())
                app.UseHsts();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseCors(_CORS_VALUE);

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        //This method is used to allow patch-json type media
        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() =>
                    new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson()
                    .Services.BuildServiceProvider()
                    .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
                    .OfType<NewtonsoftJsonPatchInputFormatter>().First();
    }
}