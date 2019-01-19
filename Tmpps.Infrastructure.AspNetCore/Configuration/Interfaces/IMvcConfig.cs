using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using Tmpps.Infrastructure.JsonWebToken.Interfaces;

namespace Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces
{
    public interface IMvcConfig
    {
        void CreateMvcConfigureRoutes(IRouteBuilder routes);
    }
}