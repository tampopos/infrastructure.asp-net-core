using System.Linq;
using Microsoft.AspNetCore.Builder;
using Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces;

namespace Tmpps.Infrastructure.AspNetCore.Middlewares.Extensions
{
    /// <summary>
    /// ミドルウェア登録用拡張メソッド
    /// </summary>
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLogger(this IApplicationBuilder builder) => builder.UseMiddleware<RequestLoggerMiddleware>();

        public static IApplicationBuilder UseCors(this IApplicationBuilder builder, ICorsConfig config)
        {
            builder.UseCors(option =>
            {
                option
                    .WithOrigins(config.GetCorsOrigins().ToArray())
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
            });
            return builder;
        }

        public static IApplicationBuilder UseJwtAuthentication<TClaim>(this IApplicationBuilder builder)
        {
            builder.UseAuthentication();
            builder.UseMiddleware<ClaimContextMiddleware<TClaim>>();
            return builder;
        }

        public static IApplicationBuilder UseMvc(this IApplicationBuilder builder, IMvcConfig config)
        {
            builder.UseMvc(config.CreateMvcConfigureRoutes);
            return builder;
        }
    }
}