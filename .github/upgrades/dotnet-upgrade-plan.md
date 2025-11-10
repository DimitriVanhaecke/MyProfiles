# .NET8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET8.0 upgrade.
3. Upgrade MyProfiles.csproj
4. Run unit tests to validate upgrade in the projects listed below:

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name | Description |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name | Current Version | New Version | Description |
|:-------------------------------------------------|:---------------:|:-----------:|:--------------------------------------------------------|
| Microsoft.AspNetCore.Components.WebAssembly |3.2.1 |8.0.21 | Recommended for .NET8.0 |
| Microsoft.AspNetCore.Components.WebAssembly.Build |3.2.1 | | Functionality included in framework reference |
| Microsoft.AspNetCore.Components.WebAssembly.DevServer |3.2.1 |8.0.21 | Recommended for .NET8.0 |
| System.Net.Http.Json |3.2.0 |8.0.1;9.0.10 | Recommended / deprecated - upgrade to latest |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### MyProfiles.csproj modifications

Project properties changes:
 - Target framework should be changed from `netstandard2.1` to `net8.0`

NuGet packages changes:
 - Microsoft.AspNetCore.Components.WebAssembly should be updated from `3.2.1` to `8.0.21` (*recommended for .NET8.0*)
 - Microsoft.AspNetCore.Components.WebAssembly.DevServer should be updated from `3.2.1` to `8.0.21` (*recommended for .NET8.0*)
 - Microsoft.AspNetCore.Components.WebAssembly.Build should be removed (`3.2.1`) because functionality is included with framework reference.
 - System.Net.Http.Json should be updated from `3.2.0` to `8.0.1` (*recommended for .NET8.0*). Package deprecated, consider updating further to `9.0.10` after .NET8.0 upgrade if needed.

Feature upgrades:
 - None

Other changes:
 - Update project SDK style if necessary.
