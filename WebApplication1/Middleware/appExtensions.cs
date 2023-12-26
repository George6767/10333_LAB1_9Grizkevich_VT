using Microsoft.AspNetCore.Builder;
using WebApplication1.Middleware;
namespace WebLabsV06.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this
       IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}