# tmpps.infrastructure.asp-net-core

## register nuget

```bash
npm run publish
# replace version,api-key
dotnet nuget push ./Tmpps.Infrastructure.AspNetCore/bin/Release/Tmpps.Infrastructure.AspNetCore.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```
