using System.Collections.Generic;

namespace Tmpps.Infrastructure.AspNetCore.Configuration.Interfaces
{
    public interface ICorsConfig
    {
        IEnumerable<string> GetCorsOrigins();
    }
}