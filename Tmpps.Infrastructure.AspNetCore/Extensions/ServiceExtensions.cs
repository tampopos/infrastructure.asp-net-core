using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces;

namespace Tmpps.Infrastructure.AspNetCore.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddJwtAuthentication(this IServiceCollection services, IJwtWebConfig config)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Audience = config.JwtAudience;
                    options.ClaimsIssuer = config.JwtIssuer;
                    options.RequireHttpsMetadata = config.UseSecure;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidIssuer = config.JwtIssuer,
                        ValidAudience = config.JwtAudience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.JwtSecret)),
                    };
                });
        }
    }
}