# .NET8 Upgrade Report

## Project target framework modifications

| Project name | Old Target Framework | New Target Framework | Commits |
|:-----------------------------------------------|:--------------------:|:--------------------:|-------------------------------------------|
| MyProfiles.csproj | netstandard2.1 | net8.0 |4cec83de |

## NuGet Packages

| Package Name | Old Version | New Version | Commit Id |
|:------------------------------------------------|:-----------:|:-----------:|------------|
| Microsoft.AspNetCore.Components.WebAssembly |3.2.1 |8.0.21 |8f396150 |
| Microsoft.AspNetCore.Components.WebAssembly.DevServer |3.2.1 |8.0.21 |8f396150 |
| System.Net.Http.Json |3.2.0 |9.0.10 |8f396150 |
| Microsoft.AspNetCore.Components.WebAssembly.Build |3.2.1 | (removed) |8f396150 |

## All commits

| Commit ID | Description |
|:-----------|:-------------------------------------------|
| e2171900 | Commit upgrade plan |
|4cec83de | Update MyProfiles.csproj to target net8.0 |
|8f396150 | Update package versions in MyProfiles.csproj |

## Project feature upgrades

Contains summary of modifications made to the project assets during different upgrade stages.

### MyProfiles.csproj

Here is what changed for the project during upgrade:

- Target framework updated from netstandard2.1 to net8.0.
- Removed Microsoft.AspNetCore.Components.WebAssembly.Build (functionality now provided by SDK/framework baseline).
- Upgraded Microsoft.AspNetCore.Components.WebAssembly and DevServer from3.2.1 to8.0.21.
- Upgraded System.Net.Http.Json from3.2.0 (deprecated) to9.0.10 via intermediate8.0.x compatibility.

## Next steps

- Verify application runs correctly with `dotnet run` and test UI interactions manually (no automated tests present).
- Consider enabling nullable reference types and implicit usings for further modernization.
- Review for any obsolete APIs at runtime logs and update accordingly.
