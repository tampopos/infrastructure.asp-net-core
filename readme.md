# tmpps.infrastructure.asp-net-core

## command

#### build

`dotnet build Tmpps.Infrastructure.AspNetCore.Tests/`

#### test

`dotnet test Tmpps.Infrastructure.AspNetCore.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Infrastructure.AspNetCore
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Infrastructure.AspNetCore
dotnet nuget push ./Tmpps.Infrastructure.AspNetCore/bin/Release/Tmpps.Infrastructure.AspNetCore.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
