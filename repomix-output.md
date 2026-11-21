This file is a merged representation of a subset of the codebase, containing files not matching ignore patterns, combined into a single document by Repomix.

# File Summary

## Purpose
This file contains a packed representation of a subset of the repository's contents that is considered the most important context.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching these patterns are excluded: */.log, bin/, obj/, packages/, .vs/, .git/, tmp/, .gitignore, README.md
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
```
src/
  NetSuiteIntegration.Api/
    bin/
      Debug/
        net9.0/
          appsettings.Development.json
          appsettings.json
          Microsoft.AspNetCore.OpenApi.dll
          Microsoft.OpenApi.dll
          NetSuiteIntegration.Api.deps.json
          NetSuiteIntegration.Api.dll
          NetSuiteIntegration.Api.exe
          NetSuiteIntegration.Api.pdb
          NetSuiteIntegration.Api.runtimeconfig.json
          NetSuiteIntegration.Api.staticwebassets.endpoints.json
          NetSuiteIntegration.Core.dll
          NetSuiteIntegration.Core.pdb
          NetSuiteIntegration.Infrastructure.dll
          NetSuiteIntegration.Infrastructure.pdb
    Controllers/
      WeatherForecastController.cs
    obj/
      Debug/
        net9.0/
          ref/
            NetSuiteIntegration.Api.dll
          refint/
            NetSuiteIntegration.Api.dll
          staticwebassets/
            msbuild.build.NetSuiteIntegration.Api.props
            msbuild.buildMultiTargeting.NetSuiteIntegration.Api.props
            msbuild.buildTransitive.NetSuiteIntegration.Api.props
          .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
          apphost.exe
          NetSuite.3F1592C6.Up2Date
          NetSuiteIntegration.Api.AssemblyInfo.cs
          NetSuiteIntegration.Api.AssemblyInfoInputs.cache
          NetSuiteIntegration.Api.assets.cache
          NetSuiteIntegration.Api.csproj.AssemblyReference.cache
          NetSuiteIntegration.Api.csproj.BuildWithSkipAnalyzers
          NetSuiteIntegration.Api.csproj.CoreCompileInputs.cache
          NetSuiteIntegration.Api.csproj.FileListAbsolute.txt
          NetSuiteIntegration.Api.dll
          NetSuiteIntegration.Api.GeneratedMSBuildEditorConfig.editorconfig
          NetSuiteIntegration.Api.genruntimeconfig.cache
          NetSuiteIntegration.Api.GlobalUsings.g.cs
          NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cache
          NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cs
          NetSuiteIntegration.Api.pdb
          rjsmcshtml.dswa.cache.json
          rjsmrazor.dswa.cache.json
          rpswa.dswa.cache.json
          staticwebassets.build.endpoints.json
          staticwebassets.build.json
          staticwebassets.build.json.cache
          staticwebassets.references.upToDateCheck.txt
          staticwebassets.removed.txt
          swae.build.ex.cache
      NetSuiteIntegration.Api.csproj.nuget.dgspec.json
      NetSuiteIntegration.Api.csproj.nuget.g.props
      NetSuiteIntegration.Api.csproj.nuget.g.targets
      project.assets.json
      project.nuget.cache
    Properties/
      launchSettings.json
    appsettings.Development.json
    appsettings.json
    NetSuiteIntegration.Api.csproj
    NetSuiteIntegration.Api.csproj.user
    NetSuiteIntegration.Api.http
    Program.cs
    WeatherForecast.cs
  NetSuiteIntegration.Core/
    bin/
      Debug/
        net9.0/
          NetSuiteIntegration.Core.deps.json
          NetSuiteIntegration.Core.dll
          NetSuiteIntegration.Core.pdb
    obj/
      Debug/
        net9.0/
          ref/
            NetSuiteIntegration.Core.dll
          refint/
            NetSuiteIntegration.Core.dll
          .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
          NetSuiteIntegration.Core.AssemblyInfo.cs
          NetSuiteIntegration.Core.AssemblyInfoInputs.cache
          NetSuiteIntegration.Core.assets.cache
          NetSuiteIntegration.Core.csproj.BuildWithSkipAnalyzers
          NetSuiteIntegration.Core.csproj.CoreCompileInputs.cache
          NetSuiteIntegration.Core.csproj.FileListAbsolute.txt
          NetSuiteIntegration.Core.dll
          NetSuiteIntegration.Core.GeneratedMSBuildEditorConfig.editorconfig
          NetSuiteIntegration.Core.GlobalUsings.g.cs
          NetSuiteIntegration.Core.pdb
      NetSuiteIntegration.Core.csproj.nuget.dgspec.json
      NetSuiteIntegration.Core.csproj.nuget.g.props
      NetSuiteIntegration.Core.csproj.nuget.g.targets
      project.assets.json
      project.nuget.cache
    Class1.cs
    NetSuiteIntegration.Core.csproj
  NetSuiteIntegration.Infrastructure/
    bin/
      Debug/
        net9.0/
          NetSuiteIntegration.Core.dll
          NetSuiteIntegration.Core.pdb
          NetSuiteIntegration.Infrastructure.deps.json
          NetSuiteIntegration.Infrastructure.dll
          NetSuiteIntegration.Infrastructure.pdb
    obj/
      Debug/
        net9.0/
          ref/
            NetSuiteIntegration.Infrastructure.dll
          refint/
            NetSuiteIntegration.Infrastructure.dll
          .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
          NetSuite.37C38856.Up2Date
          NetSuiteIntegration.Infrastructure.AssemblyInfo.cs
          NetSuiteIntegration.Infrastructure.AssemblyInfoInputs.cache
          NetSuiteIntegration.Infrastructure.assets.cache
          NetSuiteIntegration.Infrastructure.csproj.AssemblyReference.cache
          NetSuiteIntegration.Infrastructure.csproj.BuildWithSkipAnalyzers
          NetSuiteIntegration.Infrastructure.csproj.CoreCompileInputs.cache
          NetSuiteIntegration.Infrastructure.csproj.FileListAbsolute.txt
          NetSuiteIntegration.Infrastructure.dll
          NetSuiteIntegration.Infrastructure.GeneratedMSBuildEditorConfig.editorconfig
          NetSuiteIntegration.Infrastructure.GlobalUsings.g.cs
          NetSuiteIntegration.Infrastructure.pdb
      NetSuiteIntegration.Infrastructure.csproj.nuget.dgspec.json
      NetSuiteIntegration.Infrastructure.csproj.nuget.g.props
      NetSuiteIntegration.Infrastructure.csproj.nuget.g.targets
      project.assets.json
      project.nuget.cache
    Class1.cs
    NetSuiteIntegration.Infrastructure.csproj
tests/
  NetSuiteIntegration.Tests/
    bin/
      Debug/
        net9.0/
          cs/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          de/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          es/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          fr/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          it/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          ja/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          ko/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          pl/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          pt-BR/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          ru/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          tr/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          zh-Hans/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          zh-Hant/
            Microsoft.TestPlatform.CommunicationUtilities.resources.dll
            Microsoft.TestPlatform.CoreUtilities.resources.dll
            Microsoft.TestPlatform.CrossPlatEngine.resources.dll
            Microsoft.VisualStudio.TestPlatform.Common.resources.dll
            Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
          .msCoverageSourceRootsMapping_NetSuiteIntegration.Tests
          CoverletSourceRootsMapping_NetSuiteIntegration.Tests
          Microsoft.TestPlatform.CommunicationUtilities.dll
          Microsoft.TestPlatform.CoreUtilities.dll
          Microsoft.TestPlatform.CrossPlatEngine.dll
          Microsoft.TestPlatform.PlatformAbstractions.dll
          Microsoft.TestPlatform.Utilities.dll
          Microsoft.VisualStudio.CodeCoverage.Shim.dll
          Microsoft.VisualStudio.TestPlatform.Common.dll
          Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
          NetSuiteIntegration.Core.dll
          NetSuiteIntegration.Core.pdb
          NetSuiteIntegration.Infrastructure.dll
          NetSuiteIntegration.Infrastructure.pdb
          NetSuiteIntegration.Tests.deps.json
          NetSuiteIntegration.Tests.dll
          NetSuiteIntegration.Tests.pdb
          NetSuiteIntegration.Tests.runtimeconfig.json
          Newtonsoft.Json.dll
          testhost.dll
          testhost.exe
          xunit.abstractions.dll
          xunit.assert.dll
          xunit.core.dll
          xunit.execution.dotnet.dll
          xunit.runner.reporters.netcoreapp10.dll
          xunit.runner.utility.netcoreapp10.dll
          xunit.runner.visualstudio.testadapter.dll
    obj/
      Debug/
        net9.0/
          ref/
            NetSuiteIntegration.Tests.dll
          refint/
            NetSuiteIntegration.Tests.dll
          .NETCoreApp,Version=v9.0.AssemblyAttributes.cs
          NetSuite.59E87DD7.Up2Date
          NetSuiteIntegration.Tests.AssemblyInfo.cs
          NetSuiteIntegration.Tests.AssemblyInfoInputs.cache
          NetSuiteIntegration.Tests.assets.cache
          NetSuiteIntegration.Tests.csproj.AssemblyReference.cache
          NetSuiteIntegration.Tests.csproj.CoreCompileInputs.cache
          NetSuiteIntegration.Tests.csproj.FileListAbsolute.txt
          NetSuiteIntegration.Tests.dll
          NetSuiteIntegration.Tests.GeneratedMSBuildEditorConfig.editorconfig
          NetSuiteIntegration.Tests.genruntimeconfig.cache
          NetSuiteIntegration.Tests.GlobalUsings.g.cs
          NetSuiteIntegration.Tests.pdb
      NetSuiteIntegration.Tests.csproj.nuget.dgspec.json
      NetSuiteIntegration.Tests.csproj.nuget.g.props
      NetSuiteIntegration.Tests.csproj.nuget.g.targets
      project.assets.json
      project.nuget.cache
    NetSuiteIntegration.Tests.csproj
    UnitTest1.cs
NetSuiteErpIntegration.sln
```

# Files

## File: src/NetSuiteIntegration.Api/bin/Debug/net9.0/appsettings.Development.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/bin/Debug/net9.0/appsettings.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## File: src/NetSuiteIntegration.Api/bin/Debug/net9.0/NetSuiteIntegration.Api.deps.json
```json
{
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v9.0",
    "signature": ""
  },
  "compilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v9.0": {
      "NetSuiteIntegration.Api/1.0.0": {
        "dependencies": {
          "Microsoft.AspNetCore.OpenApi": "9.0.0",
          "NetSuiteIntegration.Core": "1.0.0",
          "NetSuiteIntegration.Infrastructure": "1.0.0"
        },
        "runtime": {
          "NetSuiteIntegration.Api.dll": {}
        }
      },
      "Microsoft.AspNetCore.OpenApi/9.0.0": {
        "dependencies": {
          "Microsoft.OpenApi": "1.6.17"
        },
        "runtime": {
          "lib/net9.0/Microsoft.AspNetCore.OpenApi.dll": {
            "assemblyVersion": "9.0.0.0",
            "fileVersion": "9.0.24.52903"
          }
        }
      },
      "Microsoft.OpenApi/1.6.17": {
        "runtime": {
          "lib/netstandard2.0/Microsoft.OpenApi.dll": {
            "assemblyVersion": "1.6.17.0",
            "fileVersion": "1.6.17.0"
          }
        }
      },
      "NetSuiteIntegration.Core/1.0.0": {
        "runtime": {
          "NetSuiteIntegration.Core.dll": {
            "assemblyVersion": "1.0.0.0",
            "fileVersion": "1.0.0.0"
          }
        }
      },
      "NetSuiteIntegration.Infrastructure/1.0.0": {
        "dependencies": {
          "NetSuiteIntegration.Core": "1.0.0"
        },
        "runtime": {
          "NetSuiteIntegration.Infrastructure.dll": {
            "assemblyVersion": "1.0.0.0",
            "fileVersion": "1.0.0.0"
          }
        }
      }
    }
  },
  "libraries": {
    "NetSuiteIntegration.Api/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    },
    "Microsoft.AspNetCore.OpenApi/9.0.0": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-FqUK5j1EOPNuFT7IafltZQ3cakqhSwVzH5ZW1MhZDe4pPXs9sJ2M5jom1Omsu+mwF2tNKKlRAzLRHQTZzbd+6Q==",
      "path": "microsoft.aspnetcore.openapi/9.0.0",
      "hashPath": "microsoft.aspnetcore.openapi.9.0.0.nupkg.sha512"
    },
    "Microsoft.OpenApi/1.6.17": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-Le+kehlmrlQfuDFUt1zZ2dVwrhFQtKREdKBo+rexOwaCoYP0/qpgT9tLxCsZjsgR5Itk1UKPcbgO+FyaNid/bA==",
      "path": "microsoft.openapi/1.6.17",
      "hashPath": "microsoft.openapi.1.6.17.nupkg.sha512"
    },
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    },
    "NetSuiteIntegration.Infrastructure/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/bin/Debug/net9.0/NetSuiteIntegration.Api.runtimeconfig.json
```json
{
  "runtimeOptions": {
    "tfm": "net9.0",
    "frameworks": [
      {
        "name": "Microsoft.NETCore.App",
        "version": "9.0.0"
      },
      {
        "name": "Microsoft.AspNetCore.App",
        "version": "9.0.0"
      }
    ],
    "configProperties": {
      "System.GC.Server": true,
      "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/bin/Debug/net9.0/NetSuiteIntegration.Api.staticwebassets.endpoints.json
```json
{
  "Version": 1,
  "ManifestType": "Build",
  "Endpoints": []
}
```

## File: src/NetSuiteIntegration.Api/Controllers/WeatherForecastController.cs
```csharp
using Microsoft.AspNetCore.Mvc;

namespace NetSuiteIntegration.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets/msbuild.build.NetSuiteIntegration.Api.props
```
<Project>
  <Import Project="Microsoft.AspNetCore.StaticWebAssetEndpoints.props" />
  <Import Project="Microsoft.AspNetCore.StaticWebAssets.props" />
</Project>
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets/msbuild.buildMultiTargeting.NetSuiteIntegration.Api.props
```
<Project>
  <Import Project="..\build\NetSuiteIntegration.Api.props" />
</Project>
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets/msbuild.buildTransitive.NetSuiteIntegration.Api.props
```
<Project>
  <Import Project="..\buildMultiTargeting\NetSuiteIntegration.Api.props" />
</Project>
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")]
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuite.3F1592C6.Up2Date
```

```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.AssemblyInfo.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: System.Reflection.AssemblyCompanyAttribute("NetSuiteIntegration.Api")]
[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly: System.Reflection.AssemblyProductAttribute("NetSuiteIntegration.Api")]
[assembly: System.Reflection.AssemblyTitleAttribute("NetSuiteIntegration.Api")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]

// Generated by the MSBuild WriteCodeFragment class.
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.AssemblyInfoInputs.cache
```
fa231bab0fcc7b16649c92d0a450236e2f85159fbf244cf21284e03a97a1fc83
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.csproj.BuildWithSkipAnalyzers
```

```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.csproj.CoreCompileInputs.cache
```
dfa394fadd9c82f010f904becfa5f5685935476cdc09b653a20b1c3a8c9d614f
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.csproj.FileListAbsolute.txt
```
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\appsettings.Development.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\appsettings.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.staticwebassets.endpoints.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.exe
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.deps.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.runtimeconfig.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Api.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\Microsoft.AspNetCore.OpenApi.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\Microsoft.OpenApi.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Core.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.csproj.AssemblyReference.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\rpswa.dswa.cache.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.GeneratedMSBuildEditorConfig.editorconfig
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.AssemblyInfoInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.AssemblyInfo.cs
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.csproj.CoreCompileInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cs
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\rjimswa.dswa.cache.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\rjsmrazor.dswa.cache.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\rjsmcshtml.dswa.cache.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\scopedcss\bundle\NetSuiteIntegration.Api.styles.css
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.build.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.build.json.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.development.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.build.endpoints.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\swae.build.ex.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuite.3F1592C6.Up2Date
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\refint\NetSuiteIntegration.Api.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\NetSuiteIntegration.Api.genruntimeconfig.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\ref\NetSuiteIntegration.Api.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets\msbuild.NetSuiteIntegration.Api.Microsoft.AspNetCore.StaticWebAssets.props
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets\msbuild.NetSuiteIntegration.Api.Microsoft.AspNetCore.StaticWebAssetEndpoints.props
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets\msbuild.build.NetSuiteIntegration.Api.props
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets\msbuild.buildMultiTargeting.NetSuiteIntegration.Api.props
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets\msbuild.buildTransitive.NetSuiteIntegration.Api.props
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.pack.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\obj\Debug\net9.0\staticwebassets.upToDateCheck.txt
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.GeneratedMSBuildEditorConfig.editorconfig
```
is_global = true
build_property.TargetFramework = net9.0
build_property.TargetPlatformMinVersion = 
build_property.UsingMicrosoftNETSdkWeb = true
build_property.ProjectTypeGuids = 
build_property.InvariantGlobalization = 
build_property.PlatformNeutralAssembly = 
build_property.EnforceExtendedAnalyzerRules = 
build_property._SupportedPlatformList = Linux,macOS,Windows
build_property.RootNamespace = NetSuiteIntegration.Api
build_property.RootNamespace = NetSuiteIntegration.Api
build_property.ProjectDir = D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api\
build_property.EnableComHosting = 
build_property.EnableGeneratedComInterfaceComImportInterop = 
build_property.RazorLangVersion = 9.0
build_property.SupportLocalizedComponentNames = 
build_property.GenerateRazorMetadataSourceChecksumAttributes = 
build_property.MSBuildProjectDirectory = D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Api
build_property._RazorSourceGeneratorDebug = 
build_property.EffectiveAnalysisLevelStyle = 9.0
build_property.EnableCodeStyleSeverity =
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.genruntimeconfig.cache
```
ceeffc5f80c678bc40d52d642f2431d374bc5493e5a519799fe594575065506a
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.GlobalUsings.g.cs
```csharp
// <auto-generated/>
global using global::Microsoft.AspNetCore.Builder;
global using global::Microsoft.AspNetCore.Hosting;
global using global::Microsoft.AspNetCore.Http;
global using global::Microsoft.AspNetCore.Routing;
global using global::Microsoft.Extensions.Configuration;
global using global::Microsoft.Extensions.DependencyInjection;
global using global::Microsoft.Extensions.Hosting;
global using global::Microsoft.Extensions.Logging;
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Net.Http.Json;
global using global::System.Threading;
global using global::System.Threading.Tasks;
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cache
```

```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/NetSuiteIntegration.Api.MvcApplicationPartsAssemblyInfo.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartAttribute("Microsoft.AspNetCore.OpenApi")]

// Generated by the MSBuild WriteCodeFragment class.
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/rjsmcshtml.dswa.cache.json
```json
{"GlobalPropertiesHash":"kwSV+M8UhZNzDh+vbLSKFetvHvb6qnKa2BO6OzUp6XQ=","FingerprintPatternsHash":"gq3WsqcKBUGTSNle7RKKyXRIwh7M8ccEqOqYvIzoM04=","PropertyOverridesHash":"8ZRc1sGeVrPBx4lD717BgRaQekyh78QKV9SKsdt638U=","InputHashes":["eM2M4Pstq\u002B3Ba97G0qDfxvcojmeEMSGTomppGyTRpv0=","MIBkLTBzw5quEfnDxNe35tC0diQ38V8yz2IWsWaXfIo=","EAlNCZlKtu\u002BHUsvBUK0mUMLrzdx2EQjj3MBEffGdOCg=","lAF8uOUzr/Kmnn8r97okcp6NwXQtIinVH27FVCM6CT8=","XM0PRd//U19we8YpAVvWj2FqjAE63g25bVAntXp4N/8="],"CachedAssets":{},"CachedCopyCandidates":{}}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/rjsmrazor.dswa.cache.json
```json
{"GlobalPropertiesHash":"pv7EAXSOlaHm8fdFGHD0JYuWbzpq1qlv+qk/4zPOCrA=","FingerprintPatternsHash":"gq3WsqcKBUGTSNle7RKKyXRIwh7M8ccEqOqYvIzoM04=","PropertyOverridesHash":"8ZRc1sGeVrPBx4lD717BgRaQekyh78QKV9SKsdt638U=","InputHashes":["eM2M4Pstq\u002B3Ba97G0qDfxvcojmeEMSGTomppGyTRpv0=","MIBkLTBzw5quEfnDxNe35tC0diQ38V8yz2IWsWaXfIo=","EAlNCZlKtu\u002BHUsvBUK0mUMLrzdx2EQjj3MBEffGdOCg=","lAF8uOUzr/Kmnn8r97okcp6NwXQtIinVH27FVCM6CT8=","XM0PRd//U19we8YpAVvWj2FqjAE63g25bVAntXp4N/8="],"CachedAssets":{},"CachedCopyCandidates":{}}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/rpswa.dswa.cache.json
```json
{"GlobalPropertiesHash":"2O62sjUhQ/LeX8gTbdp6HjciD5IaL/B8eUv4HxdWIkw=","FingerprintPatternsHash":"gq3WsqcKBUGTSNle7RKKyXRIwh7M8ccEqOqYvIzoM04=","PropertyOverridesHash":"8ZRc1sGeVrPBx4lD717BgRaQekyh78QKV9SKsdt638U=","InputHashes":["eM2M4Pstq\u002B3Ba97G0qDfxvcojmeEMSGTomppGyTRpv0=","MIBkLTBzw5quEfnDxNe35tC0diQ38V8yz2IWsWaXfIo="],"CachedAssets":{},"CachedCopyCandidates":{}}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets.build.endpoints.json
```json
{
  "Version": 1,
  "ManifestType": "Build",
  "Endpoints": []
}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets.build.json
```json
{
  "Version": 1,
  "Hash": "Olqgj9FrZ31Tw3wx3PEKNl9WmL8LFf8TFTFw7aCTWYc=",
  "Source": "NetSuiteIntegration.Api",
  "BasePath": "_content/NetSuiteIntegration.Api",
  "Mode": "Default",
  "ManifestType": "Build",
  "ReferencedProjectsConfiguration": [],
  "DiscoveryPatterns": [],
  "Assets": [],
  "Endpoints": []
}
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets.build.json.cache
```
4RFNKA8risEZrayCAGkdOpa3ja10IUGHi1hS9GvOPXM=
```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets.references.upToDateCheck.txt
```

```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/staticwebassets.removed.txt
```

```

## File: src/NetSuiteIntegration.Api/obj/Debug/net9.0/swae.build.ex.cache
```

```

## File: src/NetSuiteIntegration.Api/obj/NetSuiteIntegration.Api.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj": {}
  },
  "projects": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj",
        "projectName": "NetSuiteIntegration.Api",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
              },
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj"
              }
            }
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "dependencies": {
            "Microsoft.AspNetCore.OpenApi": {
              "target": "Package",
              "version": "[9.0.0, )"
            }
          },
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.AspNetCore.App": {
              "privateAssets": "none"
            },
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    },
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "projectName": "NetSuiteIntegration.Core",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    },
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "projectName": "NetSuiteIntegration.Infrastructure",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
              }
            }
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/obj/NetSuiteIntegration.Api.csproj.nuget.g.props
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>
    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\PAVITH\.nuget\packages\;C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages</NuGetPackageFolders>
    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>
    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.12.1</NuGetToolVersion>
  </PropertyGroup>
  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <SourceRoot Include="C:\Users\PAVITH\.nuget\packages\" />
    <SourceRoot Include="C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\" />
  </ItemGroup>
</Project>
```

## File: src/NetSuiteIntegration.Api/obj/NetSuiteIntegration.Api.csproj.nuget.g.targets
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />
```

## File: src/NetSuiteIntegration.Api/obj/project.assets.json
```json
{
  "version": 3,
  "targets": {
    "net9.0": {
      "Microsoft.AspNetCore.OpenApi/9.0.0": {
        "type": "package",
        "dependencies": {
          "Microsoft.OpenApi": "1.6.17"
        },
        "compile": {
          "lib/net9.0/Microsoft.AspNetCore.OpenApi.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/net9.0/Microsoft.AspNetCore.OpenApi.dll": {
            "related": ".xml"
          }
        },
        "frameworkReferences": [
          "Microsoft.AspNetCore.App"
        ]
      },
      "Microsoft.OpenApi/1.6.17": {
        "type": "package",
        "compile": {
          "lib/netstandard2.0/Microsoft.OpenApi.dll": {
            "related": ".pdb;.xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/Microsoft.OpenApi.dll": {
            "related": ".pdb;.xml"
          }
        }
      },
      "NetSuiteIntegration.Core/1.0.0": {
        "type": "project",
        "framework": ".NETCoreApp,Version=v9.0",
        "compile": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        },
        "runtime": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        }
      },
      "NetSuiteIntegration.Infrastructure/1.0.0": {
        "type": "project",
        "framework": ".NETCoreApp,Version=v9.0",
        "dependencies": {
          "NetSuiteIntegration.Core": "1.0.0"
        },
        "compile": {
          "bin/placeholder/NetSuiteIntegration.Infrastructure.dll": {}
        },
        "runtime": {
          "bin/placeholder/NetSuiteIntegration.Infrastructure.dll": {}
        }
      }
    }
  },
  "libraries": {
    "Microsoft.AspNetCore.OpenApi/9.0.0": {
      "sha512": "FqUK5j1EOPNuFT7IafltZQ3cakqhSwVzH5ZW1MhZDe4pPXs9sJ2M5jom1Omsu+mwF2tNKKlRAzLRHQTZzbd+6Q==",
      "type": "package",
      "path": "microsoft.aspnetcore.openapi/9.0.0",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "Icon.png",
        "PACKAGE.md",
        "THIRD-PARTY-NOTICES.TXT",
        "lib/net9.0/Microsoft.AspNetCore.OpenApi.dll",
        "lib/net9.0/Microsoft.AspNetCore.OpenApi.xml",
        "microsoft.aspnetcore.openapi.9.0.0.nupkg.sha512",
        "microsoft.aspnetcore.openapi.nuspec"
      ]
    },
    "Microsoft.OpenApi/1.6.17": {
      "sha512": "Le+kehlmrlQfuDFUt1zZ2dVwrhFQtKREdKBo+rexOwaCoYP0/qpgT9tLxCsZjsgR5Itk1UKPcbgO+FyaNid/bA==",
      "type": "package",
      "path": "microsoft.openapi/1.6.17",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "lib/netstandard2.0/Microsoft.OpenApi.dll",
        "lib/netstandard2.0/Microsoft.OpenApi.pdb",
        "lib/netstandard2.0/Microsoft.OpenApi.xml",
        "microsoft.openapi.1.6.17.nupkg.sha512",
        "microsoft.openapi.nuspec"
      ]
    },
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "path": "../NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj",
      "msbuildProject": "../NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj"
    },
    "NetSuiteIntegration.Infrastructure/1.0.0": {
      "type": "project",
      "path": "../NetSuiteIntegration.Infrastructure/NetSuiteIntegration.Infrastructure.csproj",
      "msbuildProject": "../NetSuiteIntegration.Infrastructure/NetSuiteIntegration.Infrastructure.csproj"
    }
  },
  "projectFileDependencyGroups": {
    "net9.0": [
      "Microsoft.AspNetCore.OpenApi >= 9.0.0",
      "NetSuiteIntegration.Core >= 1.0.0",
      "NetSuiteIntegration.Infrastructure >= 1.0.0"
    ]
  },
  "packageFolders": {
    "C:\\Users\\PAVITH\\.nuget\\packages\\": {},
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": {}
  },
  "project": {
    "version": "1.0.0",
    "restore": {
      "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj",
      "projectName": "NetSuiteIntegration.Api",
      "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj",
      "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
      "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net9.0"
      ],
      "sources": {
        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
        "https://api.nuget.org/v3/index.json": {}
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "projectReferences": {
            "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
              "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
            },
            "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
              "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj"
            }
          }
        }
      },
      "warningProperties": {
        "warnAsError": [
          "NU1605"
        ]
      },
      "restoreAuditProperties": {
        "enableAudit": "true",
        "auditLevel": "low",
        "auditMode": "all"
      },
      "SdkAnalysisLevel": "9.0.100"
    },
    "frameworks": {
      "net9.0": {
        "targetAlias": "net9.0",
        "dependencies": {
          "Microsoft.AspNetCore.OpenApi": {
            "target": "Package",
            "version": "[9.0.0, )"
          }
        },
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
        ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
          "Microsoft.AspNetCore.App": {
            "privateAssets": "none"
          },
          "Microsoft.NETCore.App": {
            "privateAssets": "all"
          }
        },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/obj/project.nuget.cache
```
{
  "version": 2,
  "dgSpecHash": "mwrHfWocCTU=",
  "success": true,
  "projectFilePath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Api\\NetSuiteIntegration.Api.csproj",
  "expectedPackageFiles": [
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.aspnetcore.openapi\\9.0.0\\microsoft.aspnetcore.openapi.9.0.0.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.openapi\\1.6.17\\microsoft.openapi.1.6.17.nupkg.sha512"
  ],
  "logs": []
}
```

## File: src/NetSuiteIntegration.Api/Properties/launchSettings.json
```json
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": false,
      "applicationUrl": "http://localhost:5242",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": false,
      "applicationUrl": "https://localhost:7186;http://localhost:5242",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/appsettings.Development.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
```

## File: src/NetSuiteIntegration.Api/appsettings.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## File: src/NetSuiteIntegration.Api/NetSuiteIntegration.Api.csproj
```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="9.0.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj" />
    <ProjectReference Include="..\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj" />
  </ItemGroup>

</Project>
```

## File: src/NetSuiteIntegration.Api/NetSuiteIntegration.Api.csproj.user
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <ActiveDebugProfile>https</ActiveDebugProfile>
  </PropertyGroup>
</Project>
```

## File: src/NetSuiteIntegration.Api/NetSuiteIntegration.Api.http
```
@NetSuiteIntegration.Api_HostAddress = http://localhost:5242

GET {{NetSuiteIntegration.Api_HostAddress}}/weatherforecast/
Accept: application/json

###
```

## File: src/NetSuiteIntegration.Api/Program.cs
```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

## File: src/NetSuiteIntegration.Api/WeatherForecast.cs
```csharp
namespace NetSuiteIntegration.Api;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
```

## File: src/NetSuiteIntegration.Core/bin/Debug/net9.0/NetSuiteIntegration.Core.deps.json
```json
{
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v9.0",
    "signature": ""
  },
  "compilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v9.0": {
      "NetSuiteIntegration.Core/1.0.0": {
        "runtime": {
          "NetSuiteIntegration.Core.dll": {}
        }
      }
    }
  },
  "libraries": {
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    }
  }
}
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")]
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.AssemblyInfo.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: System.Reflection.AssemblyCompanyAttribute("NetSuiteIntegration.Core")]
[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly: System.Reflection.AssemblyProductAttribute("NetSuiteIntegration.Core")]
[assembly: System.Reflection.AssemblyTitleAttribute("NetSuiteIntegration.Core")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]

// Generated by the MSBuild WriteCodeFragment class.
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.AssemblyInfoInputs.cache
```
142f711d62d2f6478f3eea6f6b065270d3b66ca534a590bc3eff22f736ab95fe
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.csproj.BuildWithSkipAnalyzers
```

```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.csproj.CoreCompileInputs.cache
```
acc75d558df9be7c46f7acd73c279c77f67825d821414de7f20fb6c1eca6f994
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.csproj.FileListAbsolute.txt
```
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\bin\Debug\net9.0\NetSuiteIntegration.Core.deps.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\bin\Debug\net9.0\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\bin\Debug\net9.0\NetSuiteIntegration.Core.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.GeneratedMSBuildEditorConfig.editorconfig
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.AssemblyInfoInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.AssemblyInfo.cs
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.csproj.CoreCompileInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\refint\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\NetSuiteIntegration.Core.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\obj\Debug\net9.0\ref\NetSuiteIntegration.Core.dll
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.GeneratedMSBuildEditorConfig.editorconfig
```
is_global = true
build_property.TargetFramework = net9.0
build_property.TargetPlatformMinVersion = 
build_property.UsingMicrosoftNETSdkWeb = 
build_property.ProjectTypeGuids = 
build_property.InvariantGlobalization = 
build_property.PlatformNeutralAssembly = 
build_property.EnforceExtendedAnalyzerRules = 
build_property._SupportedPlatformList = Linux,macOS,Windows
build_property.RootNamespace = NetSuiteIntegration.Core
build_property.ProjectDir = D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\
build_property.EnableComHosting = 
build_property.EnableGeneratedComInterfaceComImportInterop = 
build_property.EffectiveAnalysisLevelStyle = 9.0
build_property.EnableCodeStyleSeverity =
```

## File: src/NetSuiteIntegration.Core/obj/Debug/net9.0/NetSuiteIntegration.Core.GlobalUsings.g.cs
```csharp
// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
```

## File: src/NetSuiteIntegration.Core/obj/NetSuiteIntegration.Core.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {}
  },
  "projects": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "projectName": "NetSuiteIntegration.Core",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Core/obj/NetSuiteIntegration.Core.csproj.nuget.g.props
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>
    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\PAVITH\.nuget\packages\;C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages</NuGetPackageFolders>
    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>
    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.12.1</NuGetToolVersion>
  </PropertyGroup>
  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <SourceRoot Include="C:\Users\PAVITH\.nuget\packages\" />
    <SourceRoot Include="C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\" />
  </ItemGroup>
</Project>
```

## File: src/NetSuiteIntegration.Core/obj/NetSuiteIntegration.Core.csproj.nuget.g.targets
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />
```

## File: src/NetSuiteIntegration.Core/obj/project.assets.json
```json
{
  "version": 3,
  "targets": {
    "net9.0": {}
  },
  "libraries": {},
  "projectFileDependencyGroups": {
    "net9.0": []
  },
  "packageFolders": {
    "C:\\Users\\PAVITH\\.nuget\\packages\\": {},
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": {}
  },
  "project": {
    "version": "1.0.0",
    "restore": {
      "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
      "projectName": "NetSuiteIntegration.Core",
      "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
      "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
      "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net9.0"
      ],
      "sources": {
        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
        "https://api.nuget.org/v3/index.json": {}
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "projectReferences": {}
        }
      },
      "warningProperties": {
        "warnAsError": [
          "NU1605"
        ]
      },
      "restoreAuditProperties": {
        "enableAudit": "true",
        "auditLevel": "low",
        "auditMode": "all"
      },
      "SdkAnalysisLevel": "9.0.100"
    },
    "frameworks": {
      "net9.0": {
        "targetAlias": "net9.0",
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
        ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
          "Microsoft.NETCore.App": {
            "privateAssets": "all"
          }
        },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Core/obj/project.nuget.cache
```
{
  "version": 2,
  "dgSpecHash": "FDEGhGzGLKc=",
  "success": true,
  "projectFilePath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
  "expectedPackageFiles": [],
  "logs": []
}
```

## File: src/NetSuiteIntegration.Core/Class1.cs
```csharp
namespace NetSuiteIntegration.Core;

public class Class1
{

}
```

## File: src/NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

## File: src/NetSuiteIntegration.Infrastructure/bin/Debug/net9.0/NetSuiteIntegration.Infrastructure.deps.json
```json
{
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v9.0",
    "signature": ""
  },
  "compilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v9.0": {
      "NetSuiteIntegration.Infrastructure/1.0.0": {
        "dependencies": {
          "NetSuiteIntegration.Core": "1.0.0"
        },
        "runtime": {
          "NetSuiteIntegration.Infrastructure.dll": {}
        }
      },
      "NetSuiteIntegration.Core/1.0.0": {
        "runtime": {
          "NetSuiteIntegration.Core.dll": {
            "assemblyVersion": "1.0.0",
            "fileVersion": "1.0.0.0"
          }
        }
      }
    }
  },
  "libraries": {
    "NetSuiteIntegration.Infrastructure/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    },
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    }
  }
}
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")]
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuite.37C38856.Up2Date
```

```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.AssemblyInfo.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: System.Reflection.AssemblyCompanyAttribute("NetSuiteIntegration.Infrastructure")]
[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly: System.Reflection.AssemblyProductAttribute("NetSuiteIntegration.Infrastructure")]
[assembly: System.Reflection.AssemblyTitleAttribute("NetSuiteIntegration.Infrastructure")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]

// Generated by the MSBuild WriteCodeFragment class.
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.AssemblyInfoInputs.cache
```
339d21da7526920746c3975f564414945c93229cb0dde9573ea021d8b1daa7d7
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.csproj.BuildWithSkipAnalyzers
```

```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.csproj.CoreCompileInputs.cache
```
b5cbd93843cdae19f74d35be36ff7486efddde72cdac8b156e1f3a68a7020f6a
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.csproj.FileListAbsolute.txt
```
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.deps.json
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\bin\Debug\net9.0\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\bin\Debug\net9.0\NetSuiteIntegration.Core.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.csproj.AssemblyReference.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.GeneratedMSBuildEditorConfig.editorconfig
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.AssemblyInfoInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.AssemblyInfo.cs
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.csproj.CoreCompileInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuite.37C38856.Up2Date
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\refint\NetSuiteIntegration.Infrastructure.dll
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\NetSuiteIntegration.Infrastructure.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\obj\Debug\net9.0\ref\NetSuiteIntegration.Infrastructure.dll
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.GeneratedMSBuildEditorConfig.editorconfig
```
is_global = true
build_property.TargetFramework = net9.0
build_property.TargetPlatformMinVersion = 
build_property.UsingMicrosoftNETSdkWeb = 
build_property.ProjectTypeGuids = 
build_property.InvariantGlobalization = 
build_property.PlatformNeutralAssembly = 
build_property.EnforceExtendedAnalyzerRules = 
build_property._SupportedPlatformList = Linux,macOS,Windows
build_property.RootNamespace = NetSuiteIntegration.Infrastructure
build_property.ProjectDir = D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\
build_property.EnableComHosting = 
build_property.EnableGeneratedComInterfaceComImportInterop = 
build_property.EffectiveAnalysisLevelStyle = 9.0
build_property.EnableCodeStyleSeverity =
```

## File: src/NetSuiteIntegration.Infrastructure/obj/Debug/net9.0/NetSuiteIntegration.Infrastructure.GlobalUsings.g.cs
```csharp
// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
```

## File: src/NetSuiteIntegration.Infrastructure/obj/NetSuiteIntegration.Infrastructure.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {}
  },
  "projects": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "projectName": "NetSuiteIntegration.Core",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    },
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "projectName": "NetSuiteIntegration.Infrastructure",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
              }
            }
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Infrastructure/obj/NetSuiteIntegration.Infrastructure.csproj.nuget.g.props
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>
    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\PAVITH\.nuget\packages\;C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages</NuGetPackageFolders>
    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>
    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.12.1</NuGetToolVersion>
  </PropertyGroup>
  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <SourceRoot Include="C:\Users\PAVITH\.nuget\packages\" />
    <SourceRoot Include="C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\" />
  </ItemGroup>
</Project>
```

## File: src/NetSuiteIntegration.Infrastructure/obj/NetSuiteIntegration.Infrastructure.csproj.nuget.g.targets
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />
```

## File: src/NetSuiteIntegration.Infrastructure/obj/project.assets.json
```json
{
  "version": 3,
  "targets": {
    "net9.0": {
      "NetSuiteIntegration.Core/1.0.0": {
        "type": "project",
        "framework": ".NETCoreApp,Version=v9.0",
        "compile": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        },
        "runtime": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        }
      }
    }
  },
  "libraries": {
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "path": "../NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj",
      "msbuildProject": "../NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj"
    }
  },
  "projectFileDependencyGroups": {
    "net9.0": [
      "NetSuiteIntegration.Core >= 1.0.0"
    ]
  },
  "packageFolders": {
    "C:\\Users\\PAVITH\\.nuget\\packages\\": {},
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": {}
  },
  "project": {
    "version": "1.0.0",
    "restore": {
      "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
      "projectName": "NetSuiteIntegration.Infrastructure",
      "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
      "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
      "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net9.0"
      ],
      "sources": {
        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
        "https://api.nuget.org/v3/index.json": {}
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "projectReferences": {
            "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
              "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
            }
          }
        }
      },
      "warningProperties": {
        "warnAsError": [
          "NU1605"
        ]
      },
      "restoreAuditProperties": {
        "enableAudit": "true",
        "auditLevel": "low",
        "auditMode": "all"
      },
      "SdkAnalysisLevel": "9.0.100"
    },
    "frameworks": {
      "net9.0": {
        "targetAlias": "net9.0",
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
        ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
          "Microsoft.NETCore.App": {
            "privateAssets": "all"
          }
        },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
      }
    }
  }
}
```

## File: src/NetSuiteIntegration.Infrastructure/obj/project.nuget.cache
```
{
  "version": 2,
  "dgSpecHash": "ZD2S2qCoEuo=",
  "success": true,
  "projectFilePath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
  "expectedPackageFiles": [],
  "logs": []
}
```

## File: src/NetSuiteIntegration.Infrastructure/Class1.cs
```csharp
namespace NetSuiteIntegration.Infrastructure;

public class Class1
{

}
```

## File: src/NetSuiteIntegration.Infrastructure/NetSuiteIntegration.Infrastructure.csproj
```
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

## File: tests/NetSuiteIntegration.Tests/bin/Debug/net9.0/.msCoverageSourceRootsMapping_NetSuiteIntegration.Tests
```
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj|C:\Users\PAVITH\.nuget\packages\=C:\Users\PAVITH\.nuget\packages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj|C:\Users\PAVITH\.nuget\packages\=C:\Users\PAVITH\.nuget\packages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj|C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\=C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj|C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\=C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\
```

## File: tests/NetSuiteIntegration.Tests/bin/Debug/net9.0/CoverletSourceRootsMapping_NetSuiteIntegration.Tests
```
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj|C:\Users\PAVITH\.nuget\packages\=C:\Users\PAVITH\.nuget\packages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj|C:\Users\PAVITH\.nuget\packages\=C:\Users\PAVITH\.nuget\packages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj|C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\=C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\
D:\Projects\dotNet\NetSuiteErpIntegration\src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj|C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\=C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\
```

## File: tests/NetSuiteIntegration.Tests/bin/Debug/net9.0/NetSuiteIntegration.Tests.deps.json
```json
{
  "runtimeTarget": {
    "name": ".NETCoreApp,Version=v9.0",
    "signature": ""
  },
  "compilationOptions": {},
  "targets": {
    ".NETCoreApp,Version=v9.0": {
      "NetSuiteIntegration.Tests/1.0.0": {
        "dependencies": {
          "Microsoft.NET.Test.Sdk": "17.11.1",
          "NetSuiteIntegration.Core": "1.0.0",
          "NetSuiteIntegration.Infrastructure": "1.0.0",
          "xunit": "2.9.2"
        },
        "runtime": {
          "NetSuiteIntegration.Tests.dll": {}
        }
      },
      "Microsoft.CodeCoverage/17.11.1": {
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.VisualStudio.CodeCoverage.Shim.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.424.36701"
          }
        }
      },
      "Microsoft.NET.Test.Sdk/17.11.1": {
        "dependencies": {
          "Microsoft.CodeCoverage": "17.11.1",
          "Microsoft.TestPlatform.TestHost": "17.11.1"
        }
      },
      "Microsoft.TestPlatform.ObjectModel/17.11.1": {
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          }
        },
        "resources": {
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "zh-Hant"
          }
        }
      },
      "Microsoft.TestPlatform.TestHost/17.11.1": {
        "dependencies": {
          "Microsoft.TestPlatform.ObjectModel": "17.11.1",
          "Newtonsoft.Json": "13.0.1"
        },
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CommunicationUtilities.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CrossPlatEngine.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/Microsoft.TestPlatform.Utilities.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.Common.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          },
          "lib/netcoreapp3.1/testhost.dll": {
            "assemblyVersion": "15.0.0.0",
            "fileVersion": "17.1100.124.45402"
          }
        },
        "resources": {
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "zh-Hant"
          }
        }
      },
      "Newtonsoft.Json/13.0.1": {
        "runtime": {
          "lib/netstandard2.0/Newtonsoft.Json.dll": {
            "assemblyVersion": "13.0.0.0",
            "fileVersion": "13.0.1.25517"
          }
        }
      },
      "xunit/2.9.2": {
        "dependencies": {
          "xunit.assert": "2.9.2",
          "xunit.core": "2.9.2"
        }
      },
      "xunit.abstractions/2.0.3": {
        "runtime": {
          "lib/netstandard2.0/xunit.abstractions.dll": {
            "assemblyVersion": "2.0.0.0",
            "fileVersion": "2.0.0.0"
          }
        }
      },
      "xunit.assert/2.9.2": {
        "runtime": {
          "lib/net6.0/xunit.assert.dll": {
            "assemblyVersion": "2.9.2.0",
            "fileVersion": "2.9.2.0"
          }
        }
      },
      "xunit.core/2.9.2": {
        "dependencies": {
          "xunit.extensibility.core": "2.9.2",
          "xunit.extensibility.execution": "2.9.2"
        }
      },
      "xunit.extensibility.core/2.9.2": {
        "dependencies": {
          "xunit.abstractions": "2.0.3"
        },
        "runtime": {
          "lib/netstandard1.1/xunit.core.dll": {
            "assemblyVersion": "2.9.2.0",
            "fileVersion": "2.9.2.0"
          }
        }
      },
      "xunit.extensibility.execution/2.9.2": {
        "dependencies": {
          "xunit.extensibility.core": "2.9.2"
        },
        "runtime": {
          "lib/netstandard1.1/xunit.execution.dotnet.dll": {
            "assemblyVersion": "2.9.2.0",
            "fileVersion": "2.9.2.0"
          }
        }
      },
      "NetSuiteIntegration.Core/1.0.0": {
        "runtime": {
          "NetSuiteIntegration.Core.dll": {
            "assemblyVersion": "1.0.0.0",
            "fileVersion": "1.0.0.0"
          }
        }
      },
      "NetSuiteIntegration.Infrastructure/1.0.0": {
        "dependencies": {
          "NetSuiteIntegration.Core": "1.0.0"
        },
        "runtime": {
          "NetSuiteIntegration.Infrastructure.dll": {
            "assemblyVersion": "1.0.0.0",
            "fileVersion": "1.0.0.0"
          }
        }
      }
    }
  },
  "libraries": {
    "NetSuiteIntegration.Tests/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    },
    "Microsoft.CodeCoverage/17.11.1": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-nPJqrcA5iX+Y0kqoT3a+pD/8lrW/V7ayqnEJQsTonSoPz59J8bmoQhcSN4G8+UJ64Hkuf0zuxnfuj2lkHOq4cA==",
      "path": "microsoft.codecoverage/17.11.1",
      "hashPath": "microsoft.codecoverage.17.11.1.nupkg.sha512"
    },
    "Microsoft.NET.Test.Sdk/17.11.1": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-U3Ty4BaGoEu+T2bwSko9tWqWUOU16WzSFkq6U8zve75oRBMSLTBdMAZrVNNz1Tq12aCdDom9fcOcM9QZaFHqFg==",
      "path": "microsoft.net.test.sdk/17.11.1",
      "hashPath": "microsoft.net.test.sdk.17.11.1.nupkg.sha512"
    },
    "Microsoft.TestPlatform.ObjectModel/17.11.1": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-E2jZqAU6JeWEVsyOEOrSW1o1bpHLgb25ypvKNB/moBXPVsFYBPd/Jwi7OrYahG50J83LfHzezYI+GaEkpAotiA==",
      "path": "microsoft.testplatform.objectmodel/17.11.1",
      "hashPath": "microsoft.testplatform.objectmodel.17.11.1.nupkg.sha512"
    },
    "Microsoft.TestPlatform.TestHost/17.11.1": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-DnG+GOqJXO/CkoqlJWeDFTgPhqD/V6VqUIL3vINizCWZ3X+HshCtbbyDdSHQQEjrc2Sl/K3yaxX6s+5LFEdYuw==",
      "path": "microsoft.testplatform.testhost/17.11.1",
      "hashPath": "microsoft.testplatform.testhost.17.11.1.nupkg.sha512"
    },
    "Newtonsoft.Json/13.0.1": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-ppPFpBcvxdsfUonNcvITKqLl3bqxWbDCZIzDWHzjpdAHRFfZe0Dw9HmA0+za13IdyrgJwpkDTDA9fHaxOrt20A==",
      "path": "newtonsoft.json/13.0.1",
      "hashPath": "newtonsoft.json.13.0.1.nupkg.sha512"
    },
    "xunit/2.9.2": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-7LhFS2N9Z6Xgg8aE5lY95cneYivRMfRI8v+4PATa4S64D5Z/Plkg0qa8dTRHSiGRgVZ/CL2gEfJDE5AUhOX+2Q==",
      "path": "xunit/2.9.2",
      "hashPath": "xunit.2.9.2.nupkg.sha512"
    },
    "xunit.abstractions/2.0.3": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-pot1I4YOxlWjIb5jmwvvQNbTrZ3lJQ+jUGkGjWE3hEFM0l5gOnBWS+H3qsex68s5cO52g+44vpGzhAt+42vwKg==",
      "path": "xunit.abstractions/2.0.3",
      "hashPath": "xunit.abstractions.2.0.3.nupkg.sha512"
    },
    "xunit.assert/2.9.2": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-QkNBAQG4pa66cholm28AxijBjrmki98/vsEh4Sx5iplzotvPgpiotcxqJQMRC8d7RV7nIT8ozh97957hDnZwsQ==",
      "path": "xunit.assert/2.9.2",
      "hashPath": "xunit.assert.2.9.2.nupkg.sha512"
    },
    "xunit.core/2.9.2": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-O6RrNSdmZ0xgEn5kT927PNwog5vxTtKrWMihhhrT0Sg9jQ7iBDciYOwzBgP2krBEk5/GBXI18R1lKvmnxGcb4w==",
      "path": "xunit.core/2.9.2",
      "hashPath": "xunit.core.2.9.2.nupkg.sha512"
    },
    "xunit.extensibility.core/2.9.2": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-Ol+KlBJz1x8BrdnhN2DeOuLrr1I/cTwtHCggL9BvYqFuVd/TUSzxNT5O0NxCIXth30bsKxgMfdqLTcORtM52yQ==",
      "path": "xunit.extensibility.core/2.9.2",
      "hashPath": "xunit.extensibility.core.2.9.2.nupkg.sha512"
    },
    "xunit.extensibility.execution/2.9.2": {
      "type": "package",
      "serviceable": true,
      "sha512": "sha512-rKMpq4GsIUIJibXuZoZ8lYp5EpROlnYaRpwu9Zr0sRZXE7JqJfEEbCsUriZqB+ByXCLFBJyjkTRULMdC+U566g==",
      "path": "xunit.extensibility.execution/2.9.2",
      "hashPath": "xunit.extensibility.execution.2.9.2.nupkg.sha512"
    },
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    },
    "NetSuiteIntegration.Infrastructure/1.0.0": {
      "type": "project",
      "serviceable": false,
      "sha512": ""
    }
  }
}
```

## File: tests/NetSuiteIntegration.Tests/bin/Debug/net9.0/NetSuiteIntegration.Tests.runtimeconfig.json
```json
{
  "runtimeOptions": {
    "tfm": "net9.0",
    "framework": {
      "name": "Microsoft.NETCore.App",
      "version": "9.0.0"
    },
    "configProperties": {
      "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false
    }
  }
}
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs
```csharp
// <autogenerated />
using System;
using System.Reflection;
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")]
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuite.59E87DD7.Up2Date
```

```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.AssemblyInfo.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

[assembly: System.Reflection.AssemblyCompanyAttribute("NetSuiteIntegration.Tests")]
[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly: System.Reflection.AssemblyProductAttribute("NetSuiteIntegration.Tests")]
[assembly: System.Reflection.AssemblyTitleAttribute("NetSuiteIntegration.Tests")]
[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")]

// Generated by the MSBuild WriteCodeFragment class.
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.AssemblyInfoInputs.cache
```
aa0b12b9a3d090de064eeffd3dcbe71918696f742a36e9dafb90b08131d1b028
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.csproj.CoreCompileInputs.cache
```
8342274d5069839a8196ac63daf970da95a751827177234d4cb91110af1f73c8
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.csproj.FileListAbsolute.txt
```
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\.msCoverageSourceRootsMapping_NetSuiteIntegration.Tests
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\CoverletSourceRootsMapping_NetSuiteIntegration.Tests
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\testhost.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\testhost.exe
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.runner.visualstudio.testadapter.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.runner.reporters.netcoreapp10.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.runner.utility.netcoreapp10.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Tests.deps.json
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Tests.runtimeconfig.json
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Tests.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Tests.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.VisualStudio.CodeCoverage.Shim.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.TestPlatform.CoreUtilities.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.TestPlatform.PlatformAbstractions.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.VisualStudio.TestPlatform.ObjectModel.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.TestPlatform.CommunicationUtilities.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.TestPlatform.CrossPlatEngine.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.TestPlatform.Utilities.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Microsoft.VisualStudio.TestPlatform.Common.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\Newtonsoft.Json.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.abstractions.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.assert.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\xunit.execution.dotnet.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\cs\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\cs\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\de\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\de\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\es\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\es\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\fr\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\fr\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\it\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\it\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ja\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ja\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ko\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ko\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pl\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pl\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pt-BR\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pt-BR\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ru\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ru\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\tr\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\tr\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hans\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hans\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hant\Microsoft.TestPlatform.CoreUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hant\Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\cs\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\cs\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\cs\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\de\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\de\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\de\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\es\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\es\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\es\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\fr\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\fr\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\fr\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\it\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\it\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\it\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ja\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ja\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ja\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ko\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ko\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ko\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pl\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pl\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pl\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pt-BR\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pt-BR\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\pt-BR\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ru\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ru\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\ru\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\tr\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\tr\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\tr\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hans\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hans\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hans\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hant\Microsoft.TestPlatform.CommunicationUtilities.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hant\Microsoft.TestPlatform.CrossPlatEngine.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\zh-Hant\Microsoft.VisualStudio.TestPlatform.Common.resources.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Core.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Core.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\bin\Debug\net9.0\NetSuiteIntegration.Infrastructure.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.csproj.AssemblyReference.cache
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.GeneratedMSBuildEditorConfig.editorconfig
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.AssemblyInfoInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.AssemblyInfo.cs
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.csproj.CoreCompileInputs.cache
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuite.59E87DD7.Up2Date
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\refint\NetSuiteIntegration.Tests.dll
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.pdb
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\NetSuiteIntegration.Tests.genruntimeconfig.cache
D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\obj\Debug\net9.0\ref\NetSuiteIntegration.Tests.dll
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.GeneratedMSBuildEditorConfig.editorconfig
```
is_global = true
build_property.TargetFramework = net9.0
build_property.TargetPlatformMinVersion = 
build_property.UsingMicrosoftNETSdkWeb = 
build_property.ProjectTypeGuids = 
build_property.InvariantGlobalization = 
build_property.PlatformNeutralAssembly = 
build_property.EnforceExtendedAnalyzerRules = 
build_property._SupportedPlatformList = Linux,macOS,Windows
build_property.RootNamespace = NetSuiteIntegration.Tests
build_property.ProjectDir = D:\Projects\dotNet\NetSuiteErpIntegration\tests\NetSuiteIntegration.Tests\
build_property.EnableComHosting = 
build_property.EnableGeneratedComInterfaceComImportInterop = 
build_property.EffectiveAnalysisLevelStyle = 9.0
build_property.EnableCodeStyleSeverity =
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.genruntimeconfig.cache
```
e20adb192a14dab07b412b03bf664ece829fa57a9021783bdb460ddd89ac6fac
```

## File: tests/NetSuiteIntegration.Tests/obj/Debug/net9.0/NetSuiteIntegration.Tests.GlobalUsings.g.cs
```csharp
// <auto-generated/>
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using global::Xunit;
```

## File: tests/NetSuiteIntegration.Tests/obj/NetSuiteIntegration.Tests.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj": {}
  },
  "projects": {
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "projectName": "NetSuiteIntegration.Core",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    },
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "projectName": "NetSuiteIntegration.Infrastructure",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
              }
            }
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    },
    "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj",
        "projectName": "NetSuiteIntegration.Tests",
        "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj",
        "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
        "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net9.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net9.0": {
            "targetAlias": "net9.0",
            "projectReferences": {
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
              },
              "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
                "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj"
              }
            }
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "all"
        },
        "SdkAnalysisLevel": "9.0.100"
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "dependencies": {
            "Microsoft.NET.Test.Sdk": {
              "target": "Package",
              "version": "[17.11.1, )"
            },
            "coverlet.collector": {
              "target": "Package",
              "version": "[6.0.2, )"
            },
            "xunit": {
              "target": "Package",
              "version": "[2.9.2, )"
            },
            "xunit.runner.visualstudio": {
              "target": "Package",
              "version": "[2.8.2, )"
            }
          },
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

## File: tests/NetSuiteIntegration.Tests/obj/NetSuiteIntegration.Tests.csproj.nuget.g.props
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>
    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>
    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>
    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>
    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\PAVITH\.nuget\packages\;C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages</NuGetPackageFolders>
    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>
    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.12.1</NuGetToolVersion>
  </PropertyGroup>
  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <SourceRoot Include="C:\Users\PAVITH\.nuget\packages\" />
    <SourceRoot Include="C:\Program Files (x86)\Microsoft Visual Studio\Shared\NuGetPackages\" />
  </ItemGroup>
  <ImportGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <Import Project="$(NuGetPackageRoot)xunit.runner.visualstudio\2.8.2\build\net6.0\xunit.runner.visualstudio.props" Condition="Exists('$(NuGetPackageRoot)xunit.runner.visualstudio\2.8.2\build\net6.0\xunit.runner.visualstudio.props')" />
    <Import Project="$(NuGetPackageRoot)xunit.core\2.9.2\build\xunit.core.props" Condition="Exists('$(NuGetPackageRoot)xunit.core\2.9.2\build\xunit.core.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.testplatform.testhost\17.11.1\build\netcoreapp3.1\Microsoft.TestPlatform.TestHost.props" Condition="Exists('$(NuGetPackageRoot)microsoft.testplatform.testhost\17.11.1\build\netcoreapp3.1\Microsoft.TestPlatform.TestHost.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.codecoverage\17.11.1\build\netstandard2.0\Microsoft.CodeCoverage.props" Condition="Exists('$(NuGetPackageRoot)microsoft.codecoverage\17.11.1\build\netstandard2.0\Microsoft.CodeCoverage.props')" />
    <Import Project="$(NuGetPackageRoot)microsoft.net.test.sdk\17.11.1\build\netcoreapp3.1\Microsoft.NET.Test.Sdk.props" Condition="Exists('$(NuGetPackageRoot)microsoft.net.test.sdk\17.11.1\build\netcoreapp3.1\Microsoft.NET.Test.Sdk.props')" />
  </ImportGroup>
  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <Pkgxunit_analyzers Condition=" '$(Pkgxunit_analyzers)' == '' ">C:\Users\PAVITH\.nuget\packages\xunit.analyzers\1.16.0</Pkgxunit_analyzers>
  </PropertyGroup>
</Project>
```

## File: tests/NetSuiteIntegration.Tests/obj/NetSuiteIntegration.Tests.csproj.nuget.g.targets
```
<?xml version="1.0" encoding="utf-8" standalone="no"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <ImportGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">
    <Import Project="$(NuGetPackageRoot)xunit.core\2.9.2\build\xunit.core.targets" Condition="Exists('$(NuGetPackageRoot)xunit.core\2.9.2\build\xunit.core.targets')" />
    <Import Project="$(NuGetPackageRoot)microsoft.codecoverage\17.11.1\build\netstandard2.0\Microsoft.CodeCoverage.targets" Condition="Exists('$(NuGetPackageRoot)microsoft.codecoverage\17.11.1\build\netstandard2.0\Microsoft.CodeCoverage.targets')" />
    <Import Project="$(NuGetPackageRoot)microsoft.net.test.sdk\17.11.1\build\netcoreapp3.1\Microsoft.NET.Test.Sdk.targets" Condition="Exists('$(NuGetPackageRoot)microsoft.net.test.sdk\17.11.1\build\netcoreapp3.1\Microsoft.NET.Test.Sdk.targets')" />
    <Import Project="$(NuGetPackageRoot)coverlet.collector\6.0.2\build\netstandard2.0\coverlet.collector.targets" Condition="Exists('$(NuGetPackageRoot)coverlet.collector\6.0.2\build\netstandard2.0\coverlet.collector.targets')" />
  </ImportGroup>
</Project>
```

## File: tests/NetSuiteIntegration.Tests/obj/project.assets.json
```json
{
  "version": 3,
  "targets": {
    "net9.0": {
      "coverlet.collector/6.0.2": {
        "type": "package",
        "build": {
          "build/netstandard2.0/coverlet.collector.targets": {}
        }
      },
      "Microsoft.CodeCoverage/17.11.1": {
        "type": "package",
        "compile": {
          "lib/netcoreapp3.1/Microsoft.VisualStudio.CodeCoverage.Shim.dll": {}
        },
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.VisualStudio.CodeCoverage.Shim.dll": {}
        },
        "build": {
          "build/netstandard2.0/Microsoft.CodeCoverage.props": {},
          "build/netstandard2.0/Microsoft.CodeCoverage.targets": {}
        }
      },
      "Microsoft.NET.Test.Sdk/17.11.1": {
        "type": "package",
        "dependencies": {
          "Microsoft.CodeCoverage": "17.11.1",
          "Microsoft.TestPlatform.TestHost": "17.11.1"
        },
        "compile": {
          "lib/netcoreapp3.1/_._": {}
        },
        "runtime": {
          "lib/netcoreapp3.1/_._": {}
        },
        "build": {
          "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.props": {},
          "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.targets": {}
        },
        "buildMultiTargeting": {
          "buildMultiTargeting/Microsoft.NET.Test.Sdk.props": {}
        }
      },
      "Microsoft.TestPlatform.ObjectModel/17.11.1": {
        "type": "package",
        "dependencies": {
          "System.Reflection.Metadata": "1.6.0"
        },
        "compile": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll": {}
        },
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll": {}
        },
        "resource": {
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll": {
            "locale": "zh-Hant"
          }
        }
      },
      "Microsoft.TestPlatform.TestHost/17.11.1": {
        "type": "package",
        "dependencies": {
          "Microsoft.TestPlatform.ObjectModel": "17.11.1",
          "Newtonsoft.Json": "13.0.1"
        },
        "compile": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CommunicationUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CrossPlatEngine.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.Utilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.Common.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll": {},
          "lib/netcoreapp3.1/testhost.dll": {
            "related": ".deps.json"
          }
        },
        "runtime": {
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CommunicationUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.CrossPlatEngine.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll": {},
          "lib/netcoreapp3.1/Microsoft.TestPlatform.Utilities.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.Common.dll": {},
          "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll": {},
          "lib/netcoreapp3.1/testhost.dll": {
            "related": ".deps.json"
          }
        },
        "resource": {
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "cs"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "de"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "es"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "fr"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "it"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ja"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ko"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "pl"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "pt-BR"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "ru"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "tr"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "zh-Hans"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CommunicationUtilities.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CrossPlatEngine.resources.dll": {
            "locale": "zh-Hant"
          },
          "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.Common.resources.dll": {
            "locale": "zh-Hant"
          }
        },
        "build": {
          "build/netcoreapp3.1/Microsoft.TestPlatform.TestHost.props": {}
        }
      },
      "Newtonsoft.Json/13.0.1": {
        "type": "package",
        "compile": {
          "lib/netstandard2.0/Newtonsoft.Json.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/Newtonsoft.Json.dll": {
            "related": ".xml"
          }
        }
      },
      "System.Reflection.Metadata/1.6.0": {
        "type": "package",
        "compile": {
          "lib/netstandard2.0/System.Reflection.Metadata.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/System.Reflection.Metadata.dll": {
            "related": ".xml"
          }
        }
      },
      "xunit/2.9.2": {
        "type": "package",
        "dependencies": {
          "xunit.analyzers": "1.16.0",
          "xunit.assert": "2.9.2",
          "xunit.core": "[2.9.2]"
        }
      },
      "xunit.abstractions/2.0.3": {
        "type": "package",
        "compile": {
          "lib/netstandard2.0/xunit.abstractions.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/xunit.abstractions.dll": {
            "related": ".xml"
          }
        }
      },
      "xunit.analyzers/1.16.0": {
        "type": "package"
      },
      "xunit.assert/2.9.2": {
        "type": "package",
        "compile": {
          "lib/net6.0/xunit.assert.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/net6.0/xunit.assert.dll": {
            "related": ".xml"
          }
        }
      },
      "xunit.core/2.9.2": {
        "type": "package",
        "dependencies": {
          "xunit.extensibility.core": "[2.9.2]",
          "xunit.extensibility.execution": "[2.9.2]"
        },
        "build": {
          "build/xunit.core.props": {},
          "build/xunit.core.targets": {}
        },
        "buildMultiTargeting": {
          "buildMultiTargeting/xunit.core.props": {},
          "buildMultiTargeting/xunit.core.targets": {}
        }
      },
      "xunit.extensibility.core/2.9.2": {
        "type": "package",
        "dependencies": {
          "xunit.abstractions": "2.0.3"
        },
        "compile": {
          "lib/netstandard1.1/xunit.core.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard1.1/xunit.core.dll": {
            "related": ".xml"
          }
        }
      },
      "xunit.extensibility.execution/2.9.2": {
        "type": "package",
        "dependencies": {
          "xunit.extensibility.core": "[2.9.2]"
        },
        "compile": {
          "lib/netstandard1.1/xunit.execution.dotnet.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard1.1/xunit.execution.dotnet.dll": {
            "related": ".xml"
          }
        }
      },
      "xunit.runner.visualstudio/2.8.2": {
        "type": "package",
        "compile": {
          "lib/net6.0/_._": {}
        },
        "runtime": {
          "lib/net6.0/_._": {}
        },
        "build": {
          "build/net6.0/xunit.runner.visualstudio.props": {}
        }
      },
      "NetSuiteIntegration.Core/1.0.0": {
        "type": "project",
        "framework": ".NETCoreApp,Version=v9.0",
        "compile": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        },
        "runtime": {
          "bin/placeholder/NetSuiteIntegration.Core.dll": {}
        }
      },
      "NetSuiteIntegration.Infrastructure/1.0.0": {
        "type": "project",
        "framework": ".NETCoreApp,Version=v9.0",
        "dependencies": {
          "NetSuiteIntegration.Core": "1.0.0"
        },
        "compile": {
          "bin/placeholder/NetSuiteIntegration.Infrastructure.dll": {}
        },
        "runtime": {
          "bin/placeholder/NetSuiteIntegration.Infrastructure.dll": {}
        }
      }
    }
  },
  "libraries": {
    "coverlet.collector/6.0.2": {
      "sha512": "bJShQ6uWRTQ100ZeyiMqcFlhP7WJ+bCuabUs885dJiBEzMsJMSFr7BOyeCw4rgvQokteGi5rKQTlkhfQPUXg2A==",
      "type": "package",
      "path": "coverlet.collector/6.0.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "VSTestIntegration.md",
        "build/netstandard2.0/Microsoft.Bcl.AsyncInterfaces.dll",
        "build/netstandard2.0/Microsoft.Extensions.DependencyInjection.Abstractions.dll",
        "build/netstandard2.0/Microsoft.Extensions.DependencyInjection.dll",
        "build/netstandard2.0/Microsoft.Extensions.DependencyModel.dll",
        "build/netstandard2.0/Microsoft.Extensions.FileSystemGlobbing.dll",
        "build/netstandard2.0/Microsoft.TestPlatform.CoreUtilities.dll",
        "build/netstandard2.0/Microsoft.TestPlatform.PlatformAbstractions.dll",
        "build/netstandard2.0/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll",
        "build/netstandard2.0/Mono.Cecil.Mdb.dll",
        "build/netstandard2.0/Mono.Cecil.Pdb.dll",
        "build/netstandard2.0/Mono.Cecil.Rocks.dll",
        "build/netstandard2.0/Mono.Cecil.dll",
        "build/netstandard2.0/Newtonsoft.Json.dll",
        "build/netstandard2.0/NuGet.Frameworks.dll",
        "build/netstandard2.0/NuGet.Versioning.dll",
        "build/netstandard2.0/System.Buffers.dll",
        "build/netstandard2.0/System.Collections.Immutable.dll",
        "build/netstandard2.0/System.Memory.dll",
        "build/netstandard2.0/System.Numerics.Vectors.dll",
        "build/netstandard2.0/System.Reflection.Metadata.dll",
        "build/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "build/netstandard2.0/System.Text.Encodings.Web.dll",
        "build/netstandard2.0/System.Text.Json.dll",
        "build/netstandard2.0/System.Threading.Tasks.Extensions.dll",
        "build/netstandard2.0/coverlet.collector.deps.json",
        "build/netstandard2.0/coverlet.collector.dll",
        "build/netstandard2.0/coverlet.collector.pdb",
        "build/netstandard2.0/coverlet.collector.targets",
        "build/netstandard2.0/coverlet.core.dll",
        "build/netstandard2.0/coverlet.core.pdb",
        "build/netstandard2.0/coverlet.core.xml",
        "build/netstandard2.0/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/de/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/es/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/it/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "build/netstandard2.0/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "build/netstandard2.0/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "coverlet-icon.png",
        "coverlet.collector.6.0.2.nupkg.sha512",
        "coverlet.collector.nuspec"
      ]
    },
    "Microsoft.CodeCoverage/17.11.1": {
      "sha512": "nPJqrcA5iX+Y0kqoT3a+pD/8lrW/V7ayqnEJQsTonSoPz59J8bmoQhcSN4G8+UJ64Hkuf0zuxnfuj2lkHOq4cA==",
      "type": "package",
      "path": "microsoft.codecoverage/17.11.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "Icon.png",
        "ThirdPartyNotices.txt",
        "build/netstandard2.0/CodeCoverage/CodeCoverage.config",
        "build/netstandard2.0/CodeCoverage/CodeCoverage.exe",
        "build/netstandard2.0/CodeCoverage/VanguardInstrumentationProfiler_x86.config",
        "build/netstandard2.0/CodeCoverage/amd64/CodeCoverage.exe",
        "build/netstandard2.0/CodeCoverage/amd64/VanguardInstrumentationProfiler_x64.config",
        "build/netstandard2.0/CodeCoverage/amd64/covrun64.dll",
        "build/netstandard2.0/CodeCoverage/amd64/msdia140.dll",
        "build/netstandard2.0/CodeCoverage/arm64/VanguardInstrumentationProfiler_arm64.config",
        "build/netstandard2.0/CodeCoverage/arm64/covrunarm64.dll",
        "build/netstandard2.0/CodeCoverage/arm64/msdia140.dll",
        "build/netstandard2.0/CodeCoverage/codecoveragemessages.dll",
        "build/netstandard2.0/CodeCoverage/coreclr/Microsoft.VisualStudio.CodeCoverage.Shim.dll",
        "build/netstandard2.0/CodeCoverage/covrun32.dll",
        "build/netstandard2.0/CodeCoverage/msdia140.dll",
        "build/netstandard2.0/InstrumentationEngine/alpine/x64/VanguardInstrumentationProfiler_x64.config",
        "build/netstandard2.0/InstrumentationEngine/alpine/x64/libCoverageInstrumentationMethod.so",
        "build/netstandard2.0/InstrumentationEngine/alpine/x64/libInstrumentationEngine.so",
        "build/netstandard2.0/InstrumentationEngine/arm64/MicrosoftInstrumentationEngine_arm64.dll",
        "build/netstandard2.0/InstrumentationEngine/macos/x64/VanguardInstrumentationProfiler_x64.config",
        "build/netstandard2.0/InstrumentationEngine/macos/x64/libCoverageInstrumentationMethod.dylib",
        "build/netstandard2.0/InstrumentationEngine/macos/x64/libInstrumentationEngine.dylib",
        "build/netstandard2.0/InstrumentationEngine/ubuntu/x64/VanguardInstrumentationProfiler_x64.config",
        "build/netstandard2.0/InstrumentationEngine/ubuntu/x64/libCoverageInstrumentationMethod.so",
        "build/netstandard2.0/InstrumentationEngine/ubuntu/x64/libInstrumentationEngine.so",
        "build/netstandard2.0/InstrumentationEngine/x64/MicrosoftInstrumentationEngine_x64.dll",
        "build/netstandard2.0/InstrumentationEngine/x86/MicrosoftInstrumentationEngine_x86.dll",
        "build/netstandard2.0/Microsoft.CodeCoverage.Core.dll",
        "build/netstandard2.0/Microsoft.CodeCoverage.Instrumentation.Core.dll",
        "build/netstandard2.0/Microsoft.CodeCoverage.Instrumentation.dll",
        "build/netstandard2.0/Microsoft.CodeCoverage.Interprocess.dll",
        "build/netstandard2.0/Microsoft.CodeCoverage.props",
        "build/netstandard2.0/Microsoft.CodeCoverage.targets",
        "build/netstandard2.0/Microsoft.DiaSymReader.dll",
        "build/netstandard2.0/Microsoft.VisualStudio.TraceDataCollector.dll",
        "build/netstandard2.0/Mono.Cecil.Pdb.dll",
        "build/netstandard2.0/Mono.Cecil.Rocks.dll",
        "build/netstandard2.0/Mono.Cecil.dll",
        "build/netstandard2.0/ThirdPartyNotices.txt",
        "build/netstandard2.0/cs/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/de/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/es/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/fr/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/it/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/ja/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/ko/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/pl/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/pt-BR/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/ru/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/tr/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/zh-Hans/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "build/netstandard2.0/zh-Hant/Microsoft.VisualStudio.TraceDataCollector.resources.dll",
        "lib/net462/Microsoft.VisualStudio.CodeCoverage.Shim.dll",
        "lib/netcoreapp3.1/Microsoft.VisualStudio.CodeCoverage.Shim.dll",
        "microsoft.codecoverage.17.11.1.nupkg.sha512",
        "microsoft.codecoverage.nuspec"
      ]
    },
    "Microsoft.NET.Test.Sdk/17.11.1": {
      "sha512": "U3Ty4BaGoEu+T2bwSko9tWqWUOU16WzSFkq6U8zve75oRBMSLTBdMAZrVNNz1Tq12aCdDom9fcOcM9QZaFHqFg==",
      "type": "package",
      "path": "microsoft.net.test.sdk/17.11.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "Icon.png",
        "build/net462/Microsoft.NET.Test.Sdk.props",
        "build/net462/Microsoft.NET.Test.Sdk.targets",
        "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.Program.cs",
        "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.Program.fs",
        "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.Program.vb",
        "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.props",
        "build/netcoreapp3.1/Microsoft.NET.Test.Sdk.targets",
        "buildMultiTargeting/Microsoft.NET.Test.Sdk.props",
        "lib/net462/_._",
        "lib/netcoreapp3.1/_._",
        "microsoft.net.test.sdk.17.11.1.nupkg.sha512",
        "microsoft.net.test.sdk.nuspec"
      ]
    },
    "Microsoft.TestPlatform.ObjectModel/17.11.1": {
      "sha512": "E2jZqAU6JeWEVsyOEOrSW1o1bpHLgb25ypvKNB/moBXPVsFYBPd/Jwi7OrYahG50J83LfHzezYI+GaEkpAotiA==",
      "type": "package",
      "path": "microsoft.testplatform.objectmodel/17.11.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "Icon.png",
        "lib/net462/Microsoft.TestPlatform.CoreUtilities.dll",
        "lib/net462/Microsoft.TestPlatform.PlatformAbstractions.dll",
        "lib/net462/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll",
        "lib/net462/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/de/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/es/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/it/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/net462/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/net462/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll",
        "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll",
        "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/Microsoft.TestPlatform.CoreUtilities.dll",
        "lib/netstandard2.0/Microsoft.TestPlatform.PlatformAbstractions.dll",
        "lib/netstandard2.0/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll",
        "lib/netstandard2.0/cs/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/cs/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/de/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/de/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/es/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/es/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/fr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/fr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/it/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/it/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/ja/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/ja/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/ko/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/ko/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/pl/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/pl/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/pt-BR/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/pt-BR/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/ru/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/ru/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/tr/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/tr/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/zh-Hans/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/zh-Hans/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "lib/netstandard2.0/zh-Hant/Microsoft.TestPlatform.CoreUtilities.resources.dll",
        "lib/netstandard2.0/zh-Hant/Microsoft.VisualStudio.TestPlatform.ObjectModel.resources.dll",
        "microsoft.testplatform.objectmodel.17.11.1.nupkg.sha512",
        "microsoft.testplatform.objectmodel.nuspec"
      ]
    },
    "Microsoft.TestPlatform.TestHost/17.11.1": {
      "sha512": "DnG+GOqJXO/CkoqlJWeDFTgPhqD/V6VqUIL3vINizCWZ3X+HshCtbbyDdSHQQEjrc2Sl/K3yaxX6s+5LFEdYuw==",
      "type": "package",
      "path": "microsoft.testplatform.testhost/17.11.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "Icon.png",
        "ThirdPartyNotices.txt",
        "build/netcoreapp3.1/Microsoft.TestPlatform.TestHost.props",
        "build/netcoreapp3.1/x64/testhost.dll",
        "build/netcoreapp3.1/x64/testhost.exe",
        "build/netcoreapp3.1/x86/testhost.x86.dll",
        "build/netcoreapp3.1/x86/testhost.x86.exe",
        "lib/net462/_._",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.CommunicationUtilities.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.CoreUtilities.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.CrossPlatEngine.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.PlatformAbstractions.dll",
        "lib/netcoreapp3.1/Microsoft.TestPlatform.Utilities.dll",
        "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.Common.dll",
        "lib/netcoreapp3.1/Microsoft.VisualStudio.TestPlatform.ObjectModel.dll",
        "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/cs/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/cs/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/de/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/de/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/es/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/es/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/fr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/fr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/it/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/it/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/ja/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/ja/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/ko/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/ko/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/pl/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/pl/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/pt-BR/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/pt-BR/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/ru/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/ru/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/testhost.deps.json",
        "lib/netcoreapp3.1/testhost.dll",
        "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/tr/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/tr/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/x64/msdia140.dll",
        "lib/netcoreapp3.1/x86/msdia140.dll",
        "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/zh-Hans/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/zh-Hans/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CommunicationUtilities.resources.dll",
        "lib/netcoreapp3.1/zh-Hant/Microsoft.TestPlatform.CrossPlatEngine.resources.dll",
        "lib/netcoreapp3.1/zh-Hant/Microsoft.VisualStudio.TestPlatform.Common.resources.dll",
        "microsoft.testplatform.testhost.17.11.1.nupkg.sha512",
        "microsoft.testplatform.testhost.nuspec"
      ]
    },
    "Newtonsoft.Json/13.0.1": {
      "sha512": "ppPFpBcvxdsfUonNcvITKqLl3bqxWbDCZIzDWHzjpdAHRFfZe0Dw9HmA0+za13IdyrgJwpkDTDA9fHaxOrt20A==",
      "type": "package",
      "path": "newtonsoft.json/13.0.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "LICENSE.md",
        "lib/net20/Newtonsoft.Json.dll",
        "lib/net20/Newtonsoft.Json.xml",
        "lib/net35/Newtonsoft.Json.dll",
        "lib/net35/Newtonsoft.Json.xml",
        "lib/net40/Newtonsoft.Json.dll",
        "lib/net40/Newtonsoft.Json.xml",
        "lib/net45/Newtonsoft.Json.dll",
        "lib/net45/Newtonsoft.Json.xml",
        "lib/netstandard1.0/Newtonsoft.Json.dll",
        "lib/netstandard1.0/Newtonsoft.Json.xml",
        "lib/netstandard1.3/Newtonsoft.Json.dll",
        "lib/netstandard1.3/Newtonsoft.Json.xml",
        "lib/netstandard2.0/Newtonsoft.Json.dll",
        "lib/netstandard2.0/Newtonsoft.Json.xml",
        "newtonsoft.json.13.0.1.nupkg.sha512",
        "newtonsoft.json.nuspec",
        "packageIcon.png"
      ]
    },
    "System.Reflection.Metadata/1.6.0": {
      "sha512": "COC1aiAJjCoA5GBF+QKL2uLqEBew4JsCkQmoHKbN3TlOZKa2fKLz5CpiRQKDz0RsAOEGsVKqOD5bomsXq/4STQ==",
      "type": "package",
      "path": "system.reflection.metadata/1.6.0",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "LICENSE.TXT",
        "THIRD-PARTY-NOTICES.TXT",
        "lib/netstandard1.1/System.Reflection.Metadata.dll",
        "lib/netstandard1.1/System.Reflection.Metadata.xml",
        "lib/netstandard2.0/System.Reflection.Metadata.dll",
        "lib/netstandard2.0/System.Reflection.Metadata.xml",
        "lib/portable-net45+win8/System.Reflection.Metadata.dll",
        "lib/portable-net45+win8/System.Reflection.Metadata.xml",
        "system.reflection.metadata.1.6.0.nupkg.sha512",
        "system.reflection.metadata.nuspec",
        "useSharedDesignerContext.txt",
        "version.txt"
      ]
    },
    "xunit/2.9.2": {
      "sha512": "7LhFS2N9Z6Xgg8aE5lY95cneYivRMfRI8v+4PATa4S64D5Z/Plkg0qa8dTRHSiGRgVZ/CL2gEfJDE5AUhOX+2Q==",
      "type": "package",
      "path": "xunit/2.9.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "xunit.2.9.2.nupkg.sha512",
        "xunit.nuspec"
      ]
    },
    "xunit.abstractions/2.0.3": {
      "sha512": "pot1I4YOxlWjIb5jmwvvQNbTrZ3lJQ+jUGkGjWE3hEFM0l5gOnBWS+H3qsex68s5cO52g+44vpGzhAt+42vwKg==",
      "type": "package",
      "path": "xunit.abstractions/2.0.3",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "lib/net35/xunit.abstractions.dll",
        "lib/net35/xunit.abstractions.xml",
        "lib/netstandard1.0/xunit.abstractions.dll",
        "lib/netstandard1.0/xunit.abstractions.xml",
        "lib/netstandard2.0/xunit.abstractions.dll",
        "lib/netstandard2.0/xunit.abstractions.xml",
        "xunit.abstractions.2.0.3.nupkg.sha512",
        "xunit.abstractions.nuspec"
      ]
    },
    "xunit.analyzers/1.16.0": {
      "sha512": "hptYM7vGr46GUIgZt21YHO4rfuBAQS2eINbFo16CV/Dqq+24Tp+P5gDCACu1AbFfW4Sp/WRfDPSK8fmUUb8s0Q==",
      "type": "package",
      "path": "xunit.analyzers/1.16.0",
      "hasTools": true,
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "analyzers/dotnet/cs/xunit.analyzers.dll",
        "analyzers/dotnet/cs/xunit.analyzers.fixes.dll",
        "tools/install.ps1",
        "tools/uninstall.ps1",
        "xunit.analyzers.1.16.0.nupkg.sha512",
        "xunit.analyzers.nuspec"
      ]
    },
    "xunit.assert/2.9.2": {
      "sha512": "QkNBAQG4pa66cholm28AxijBjrmki98/vsEh4Sx5iplzotvPgpiotcxqJQMRC8d7RV7nIT8ozh97957hDnZwsQ==",
      "type": "package",
      "path": "xunit.assert/2.9.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "lib/net6.0/xunit.assert.dll",
        "lib/net6.0/xunit.assert.xml",
        "lib/netstandard1.1/xunit.assert.dll",
        "lib/netstandard1.1/xunit.assert.xml",
        "xunit.assert.2.9.2.nupkg.sha512",
        "xunit.assert.nuspec"
      ]
    },
    "xunit.core/2.9.2": {
      "sha512": "O6RrNSdmZ0xgEn5kT927PNwog5vxTtKrWMihhhrT0Sg9jQ7iBDciYOwzBgP2krBEk5/GBXI18R1lKvmnxGcb4w==",
      "type": "package",
      "path": "xunit.core/2.9.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "build/xunit.core.props",
        "build/xunit.core.targets",
        "buildMultiTargeting/xunit.core.props",
        "buildMultiTargeting/xunit.core.targets",
        "xunit.core.2.9.2.nupkg.sha512",
        "xunit.core.nuspec"
      ]
    },
    "xunit.extensibility.core/2.9.2": {
      "sha512": "Ol+KlBJz1x8BrdnhN2DeOuLrr1I/cTwtHCggL9BvYqFuVd/TUSzxNT5O0NxCIXth30bsKxgMfdqLTcORtM52yQ==",
      "type": "package",
      "path": "xunit.extensibility.core/2.9.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "lib/net452/xunit.core.dll",
        "lib/net452/xunit.core.dll.tdnet",
        "lib/net452/xunit.core.xml",
        "lib/net452/xunit.runner.tdnet.dll",
        "lib/net452/xunit.runner.utility.net452.dll",
        "lib/netstandard1.1/xunit.core.dll",
        "lib/netstandard1.1/xunit.core.xml",
        "xunit.extensibility.core.2.9.2.nupkg.sha512",
        "xunit.extensibility.core.nuspec"
      ]
    },
    "xunit.extensibility.execution/2.9.2": {
      "sha512": "rKMpq4GsIUIJibXuZoZ8lYp5EpROlnYaRpwu9Zr0sRZXE7JqJfEEbCsUriZqB+ByXCLFBJyjkTRULMdC+U566g==",
      "type": "package",
      "path": "xunit.extensibility.execution/2.9.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "lib/net452/xunit.execution.desktop.dll",
        "lib/net452/xunit.execution.desktop.xml",
        "lib/netstandard1.1/xunit.execution.dotnet.dll",
        "lib/netstandard1.1/xunit.execution.dotnet.xml",
        "xunit.extensibility.execution.2.9.2.nupkg.sha512",
        "xunit.extensibility.execution.nuspec"
      ]
    },
    "xunit.runner.visualstudio/2.8.2": {
      "sha512": "vm1tbfXhFmjFMUmS4M0J0ASXz3/U5XvXBa6DOQUL3fEz4Vt6YPhv+ESCarx6M6D+9kJkJYZKCNvJMas1+nVfmQ==",
      "type": "package",
      "path": "xunit.runner.visualstudio/2.8.2",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "_content/README.md",
        "_content/logo-128-transparent.png",
        "build/net462/xunit.abstractions.dll",
        "build/net462/xunit.runner.reporters.net452.dll",
        "build/net462/xunit.runner.utility.net452.dll",
        "build/net462/xunit.runner.visualstudio.props",
        "build/net462/xunit.runner.visualstudio.testadapter.dll",
        "build/net6.0/xunit.abstractions.dll",
        "build/net6.0/xunit.runner.reporters.netcoreapp10.dll",
        "build/net6.0/xunit.runner.utility.netcoreapp10.dll",
        "build/net6.0/xunit.runner.visualstudio.props",
        "build/net6.0/xunit.runner.visualstudio.testadapter.dll",
        "lib/net462/_._",
        "lib/net6.0/_._",
        "xunit.runner.visualstudio.2.8.2.nupkg.sha512",
        "xunit.runner.visualstudio.nuspec"
      ]
    },
    "NetSuiteIntegration.Core/1.0.0": {
      "type": "project",
      "path": "../../src/NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj",
      "msbuildProject": "../../src/NetSuiteIntegration.Core/NetSuiteIntegration.Core.csproj"
    },
    "NetSuiteIntegration.Infrastructure/1.0.0": {
      "type": "project",
      "path": "../../src/NetSuiteIntegration.Infrastructure/NetSuiteIntegration.Infrastructure.csproj",
      "msbuildProject": "../../src/NetSuiteIntegration.Infrastructure/NetSuiteIntegration.Infrastructure.csproj"
    }
  },
  "projectFileDependencyGroups": {
    "net9.0": [
      "Microsoft.NET.Test.Sdk >= 17.11.1",
      "NetSuiteIntegration.Core >= 1.0.0",
      "NetSuiteIntegration.Infrastructure >= 1.0.0",
      "coverlet.collector >= 6.0.2",
      "xunit >= 2.9.2",
      "xunit.runner.visualstudio >= 2.8.2"
    ]
  },
  "packageFolders": {
    "C:\\Users\\PAVITH\\.nuget\\packages\\": {},
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": {}
  },
  "project": {
    "version": "1.0.0",
    "restore": {
      "projectUniqueName": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj",
      "projectName": "NetSuiteIntegration.Tests",
      "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj",
      "packagesPath": "C:\\Users\\PAVITH\\.nuget\\packages\\",
      "outputPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\PAVITH\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net9.0"
      ],
      "sources": {
        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
        "https://api.nuget.org/v3/index.json": {}
      },
      "frameworks": {
        "net9.0": {
          "targetAlias": "net9.0",
          "projectReferences": {
            "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj": {
              "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Core\\NetSuiteIntegration.Core.csproj"
            },
            "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj": {
              "projectPath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\src\\NetSuiteIntegration.Infrastructure\\NetSuiteIntegration.Infrastructure.csproj"
            }
          }
        }
      },
      "warningProperties": {
        "warnAsError": [
          "NU1605"
        ]
      },
      "restoreAuditProperties": {
        "enableAudit": "true",
        "auditLevel": "low",
        "auditMode": "all"
      },
      "SdkAnalysisLevel": "9.0.100"
    },
    "frameworks": {
      "net9.0": {
        "targetAlias": "net9.0",
        "dependencies": {
          "Microsoft.NET.Test.Sdk": {
            "target": "Package",
            "version": "[17.11.1, )"
          },
          "coverlet.collector": {
            "target": "Package",
            "version": "[6.0.2, )"
          },
          "xunit": {
            "target": "Package",
            "version": "[2.9.2, )"
          },
          "xunit.runner.visualstudio": {
            "target": "Package",
            "version": "[2.8.2, )"
          }
        },
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
        ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
          "Microsoft.NETCore.App": {
            "privateAssets": "all"
          }
        },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.100/PortableRuntimeIdentifierGraph.json"
      }
    }
  }
}
```

## File: tests/NetSuiteIntegration.Tests/obj/project.nuget.cache
```
{
  "version": 2,
  "dgSpecHash": "6SBN+ofEvkU=",
  "success": true,
  "projectFilePath": "D:\\Projects\\dotNet\\NetSuiteErpIntegration\\tests\\NetSuiteIntegration.Tests\\NetSuiteIntegration.Tests.csproj",
  "expectedPackageFiles": [
    "C:\\Users\\PAVITH\\.nuget\\packages\\coverlet.collector\\6.0.2\\coverlet.collector.6.0.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.codecoverage\\17.11.1\\microsoft.codecoverage.17.11.1.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.net.test.sdk\\17.11.1\\microsoft.net.test.sdk.17.11.1.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.testplatform.objectmodel\\17.11.1\\microsoft.testplatform.objectmodel.17.11.1.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\microsoft.testplatform.testhost\\17.11.1\\microsoft.testplatform.testhost.17.11.1.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\newtonsoft.json\\13.0.1\\newtonsoft.json.13.0.1.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\system.reflection.metadata\\1.6.0\\system.reflection.metadata.1.6.0.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit\\2.9.2\\xunit.2.9.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.abstractions\\2.0.3\\xunit.abstractions.2.0.3.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.analyzers\\1.16.0\\xunit.analyzers.1.16.0.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.assert\\2.9.2\\xunit.assert.2.9.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.core\\2.9.2\\xunit.core.2.9.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.extensibility.core\\2.9.2\\xunit.extensibility.core.2.9.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.extensibility.execution\\2.9.2\\xunit.extensibility.execution.2.9.2.nupkg.sha512",
    "C:\\Users\\PAVITH\\.nuget\\packages\\xunit.runner.visualstudio\\2.8.2\\xunit.runner.visualstudio.2.8.2.nupkg.sha512"
  ],
  "logs": []
}
```

## File: tests/NetSuiteIntegration.Tests/NetSuiteIntegration.Tests.csproj
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="coverlet.collector" Version="6.0.2" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.11.1" />
    <PackageReference Include="xunit" Version="2.9.2" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.8.2" />
  </ItemGroup>

  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\..\src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj" />
    <ProjectReference Include="..\..\src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj" />
  </ItemGroup>

</Project>
```

## File: tests/NetSuiteIntegration.Tests/UnitTest1.cs
```csharp
namespace NetSuiteIntegration.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}
```

## File: NetSuiteErpIntegration.sln
```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.0.31903.59
MinimumVisualStudioVersion = 10.0.40219.1
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "src", "src", "{827E0CD3-B72D-47B6-A68D-7590B98EB39B}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "NetSuiteIntegration.Api", "src\NetSuiteIntegration.Api\NetSuiteIntegration.Api.csproj", "{646CD5B9-97F6-4669-AEC9-71394A4C0D05}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "NetSuiteIntegration.Core", "src\NetSuiteIntegration.Core\NetSuiteIntegration.Core.csproj", "{0E759397-A0DF-4376-ABDD-44BD81C9A511}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "NetSuiteIntegration.Infrastructure", "src\NetSuiteIntegration.Infrastructure\NetSuiteIntegration.Infrastructure.csproj", "{49BFA3DA-B737-48A3-B337-714D71E24A44}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "tests", "tests", "{0AB3BF05-4346-4AA6-1389-037BE0695223}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "NetSuiteIntegration.Tests", "tests\NetSuiteIntegration.Tests\NetSuiteIntegration.Tests.csproj", "{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Debug|x64 = Debug|x64
		Debug|x86 = Debug|x86
		Release|Any CPU = Release|Any CPU
		Release|x64 = Release|x64
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|x64.ActiveCfg = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|x64.Build.0 = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|x86.ActiveCfg = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Debug|x86.Build.0 = Debug|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|Any CPU.Build.0 = Release|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|x64.ActiveCfg = Release|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|x64.Build.0 = Release|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|x86.ActiveCfg = Release|Any CPU
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05}.Release|x86.Build.0 = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|x64.ActiveCfg = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|x64.Build.0 = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|x86.ActiveCfg = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Debug|x86.Build.0 = Debug|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|Any CPU.Build.0 = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|x64.ActiveCfg = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|x64.Build.0 = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|x86.ActiveCfg = Release|Any CPU
		{0E759397-A0DF-4376-ABDD-44BD81C9A511}.Release|x86.Build.0 = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|x64.ActiveCfg = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|x64.Build.0 = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|x86.ActiveCfg = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Debug|x86.Build.0 = Debug|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|Any CPU.Build.0 = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|x64.ActiveCfg = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|x64.Build.0 = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|x86.ActiveCfg = Release|Any CPU
		{49BFA3DA-B737-48A3-B337-714D71E24A44}.Release|x86.Build.0 = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|x64.ActiveCfg = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|x64.Build.0 = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|x86.ActiveCfg = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Debug|x86.Build.0 = Debug|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|Any CPU.Build.0 = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|x64.ActiveCfg = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|x64.Build.0 = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|x86.ActiveCfg = Release|Any CPU
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7}.Release|x86.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
		{646CD5B9-97F6-4669-AEC9-71394A4C0D05} = {827E0CD3-B72D-47B6-A68D-7590B98EB39B}
		{0E759397-A0DF-4376-ABDD-44BD81C9A511} = {827E0CD3-B72D-47B6-A68D-7590B98EB39B}
		{49BFA3DA-B737-48A3-B337-714D71E24A44} = {827E0CD3-B72D-47B6-A68D-7590B98EB39B}
		{9AF2C058-4E03-497C-9D6E-EFDD712F5EC7} = {0AB3BF05-4346-4AA6-1389-037BE0695223}
	EndGlobalSection
EndGlobal
```
