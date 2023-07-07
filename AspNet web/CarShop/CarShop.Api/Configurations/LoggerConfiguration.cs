using Microsoft.AspNetCore.Builder;
using Serilog;

namespace CarShop.Api.Configurations
{
    public static class LoggerConfiguration
    {
        public static void ConfigurationLogger(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((hostingContext, loggerConfiguration)=>
                         loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));
        }
    }
}
