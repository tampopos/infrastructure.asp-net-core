using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using Tmpps.Infrastructure.JsonWebToken.Interfaces;

namespace Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces
{
    public interface IWebConfig : IJwtConfig
    {
        bool IsEnableCors { get; }
        bool UseAuthentication { get; }
        bool IsUseSecure { get; }

        IEnumerable<string> GetCorsOrigins();
        void CreateMvcConfigureRoutes(IRouteBuilder routes);
    }
}