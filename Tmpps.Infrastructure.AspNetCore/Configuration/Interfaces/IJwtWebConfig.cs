using Tmpps.Infrastructure.JsonWebToken.Interfaces;

namespace Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces
{
    public interface IJwtWebConfig : IJwtConfig
    {
        bool UseSecure { get; }
    }
}