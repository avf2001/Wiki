using Serilog;

namespace ReferenceProject.Presentation.Razor.Extensions
{
    public static class AddServices
    {
        public static IServiceCollection AddPresentationServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region Razor Pages

            services.AddRazorPages();

            #endregion

            #region MediatR

            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()));

            #endregion

            #region Serilog

            new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
            services.AddLogging(builder => builder.AddSerilog());

            #endregion

            return services;
        }
    }
}
