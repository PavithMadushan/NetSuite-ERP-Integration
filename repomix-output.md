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
    Controllers/
      WeatherForecastController.cs
    appsettings.Development.json
    appsettings.json
    NetSuiteIntegration.Api.csproj
    NetSuiteIntegration.Api.http
    Program.cs
    WeatherForecast.cs
  NetSuiteIntegration.Core/
    Interfaces/
      INetSuiteClient.cs
    Models/
      Customer.cs
      Item.cs
      SalesOrder.cs
      SalesOrderLine.cs
    NetSuiteIntegration.Core.csproj
  NetSuiteIntegration.Infrastructure/
    Client/
      MockNetSuiteClient.cs
    Configuration/
      NetSuiteOptions.cs
    Class1.cs
    NetSuiteIntegration.Infrastructure.csproj
tests/
  NetSuiteIntegration.Tests/
    NetSuiteIntegration.Tests.csproj
    UnitTest1.cs
NetSuiteErpIntegration.sln
```

# Files

## File: src/NetSuiteIntegration.Infrastructure/Configuration/NetSuiteOptions.cs
```csharp
namespace NetSuiteIntegration.Infrastructure.Configuration
{
    public class NetSuiteOptions
    {
        public string AccountId { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
        public bool UseMock { get; set; } = true;
    }
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
  "AllowedHosts": "*",

  "NetSuite": {
    "AccountId": "",
    "BaseUrl": "",
    "UseMock": true
  }
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

## File: src/NetSuiteIntegration.Api/NetSuiteIntegration.Api.http
```
@NetSuiteIntegration.Api_HostAddress = http://localhost:5242

GET {{NetSuiteIntegration.Api_HostAddress}}/weatherforecast/
Accept: application/json

###
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

## File: src/NetSuiteIntegration.Core/Interfaces/INetSuiteClient.cs
```csharp
using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Core.Interfaces
{
    public interface INetSuiteClient
    {
        // Customers
        Task<Customer?> GetCustomerByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Customer>> GetCustomersAsync(CancellationToken cancellationToken = default);

        // Items
        Task<Item?> GetItemByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Item>> GetItemsAsync(CancellationToken cancellationToken = default);

        // Sales Orders
        Task<SalesOrder?> GetSalesOrderByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(CancellationToken cancellationToken = default);

        // SuiteQL
        Task<string> ExecuteSuiteQlAsync(string query,CancellationToken cancellationToken = default);
    }
}
```

## File: src/NetSuiteIntegration.Core/Models/Customer.cs
```csharp
namespace NetSuiteIntegration.Core.Models;

public class Customer
{
    // NetSuite's internal record identifier
    public string? InternalId { get; set; }

    // External identifier used by another system
    public string? ExternalId { get; set; }    
    public string? CompanyName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    // Contact information
    public string? Email { get; set; }
    public string? Phone { get; set; }

    // NetSuite-related information
    public string? SubsidiaryInternalId { get; set; }
    public bool IsInactive { get; set; }
}
```

## File: src/NetSuiteIntegration.Core/Models/Item.cs
```csharp
namespace NetSuiteIntegration.Core.Models;

public class Item
{
    // NetSuite identifiers
    public string? InternalId { get; set; }
    public string? ExternalId { get; set; }

    // Item information
    public string? ItemName { get; set; }
    public string? DisplayName { get; set; }
    public string? ItemType { get; set; }
    public string? SKU { get; set; }
    public string? Description { get; set; }

    // Pricing information
    public decimal? BasePrice { get; set; }
    public bool IsInactive { get; set; }
}
```

## File: src/NetSuiteIntegration.Core/Models/SalesOrder.cs
```csharp
namespace NetSuiteIntegration.Core.Models;

public class SalesOrder
{
    // NetSuite identifiers
    public string? InternalId { get; set; }
    public string? ExternalId { get; set; }
    public string? TransactionNumber { get; set; }

    // Customer reference
    public string? CustomerInternalId { get; set; }

    // Transaction information
    public DateOnly TransactionDate { get; set; }
    public string? Status { get; set; }
    public string? CurrencyInternalId { get; set; }
    public string? Memo { get; set; }

    // Financial information
    public decimal Total { get; set; }

    // Multiple products in one sales order
    public List<SalesOrderLine> Lines { get; set; } = [];
}
```

## File: src/NetSuiteIntegration.Core/Models/SalesOrderLine.cs
```csharp
namespace NetSuiteIntegration.Core.Models;

public class SalesOrderLine
{
    public int LineNumber { get; set; }

    // Reference to the NetSuite item
    public string? ItemInternalId { get; set; }
    public string? Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
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

## File: src/NetSuiteIntegration.Infrastructure/Client/MockNetSuiteClient.cs
```csharp
using System.Text.Json;
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Infrastructure.Clients;

public class MockNetSuiteClient : INetSuiteClient
{
    // Sample customer data
    private readonly IReadOnlyList<Customer> _customers =
    [
        new Customer
        {
            InternalId = "105",
            ExternalId = "CUST-001",
            CompanyName = "ABC Technologies (Pvt) Ltd",
            FirstName = "John",
            LastName = "Perera",
            Email = "john@abctech.com",
            Phone = "0771234567",
            SubsidiaryInternalId = "1",
            IsInactive = false
        },
        new Customer
        {
            InternalId = "106",
            ExternalId = "CUST-002",
            CompanyName = "XYZ Solutions (Pvt) Ltd",
            FirstName = "Sarah",
            LastName = "Fernando",
            Email = "sarah@xyzsolutions.com",
            Phone = "0719876543",
            SubsidiaryInternalId = "1",
            IsInactive = false
        }
    ];

    // Sample item data
    private readonly IReadOnlyList<Item> _items =
    [
        new Item
        {
            InternalId = "205",
            ExternalId = "ITEM-001",
            ItemName = "LAPTOP-001",
            DisplayName = "Dell Laptop",
            ItemType = "Inventory",
            SKU = "DELL-LAP-001",
            Description = "Dell business laptop",
            BasePrice = 250000m,
            IsInactive = false
        },
        new Item
        {
            InternalId = "206",
            ExternalId = "ITEM-002",
            ItemName = "MOUSE-001",
            DisplayName = "Wireless Mouse",
            ItemType = "Inventory",
            SKU = "MOU-WRL-001",
            Description = "Wireless optical mouse",
            BasePrice = 13000m,
            IsInactive = false
        }
    ];

    // Sample sales order data
    private readonly IReadOnlyList<SalesOrder> _salesOrders =
    [
        new SalesOrder
        {
            InternalId = "5001",
            ExternalId = "SO-EXT-001",
            TransactionNumber = "SO1001",
            CustomerInternalId = "105",
            TransactionDate = new DateOnly(2026, 11, 20),
            Status = "Pending Fulfillment",
            CurrencyInternalId = "1",
            Memo = "Sample sales order",
            Total = 526000m,

            Lines =
            [
                new SalesOrderLine
                {
                    LineNumber = 1,
                    ItemInternalId = "205",
                    Description = "Dell Laptop",
                    Quantity = 2,
                    Rate = 250000m,
                    Amount = 500000m
                },
                new SalesOrderLine
                {
                    LineNumber = 2,
                    ItemInternalId = "206",
                    Description = "Wireless Mouse",
                    Quantity = 2,
                    Rate = 13000m,
                    Amount = 26000m
                }
            ]
        }
    ];

    // Customer operations
    public Task<Customer?> GetCustomerByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var customer = _customers.FirstOrDefault(
            c => c.InternalId == internalId);

        return Task.FromResult(customer);
    }

    public Task<IReadOnlyList<Customer>> GetCustomersAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_customers);
    }

    // Item operations
    public Task<Item?> GetItemByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var item = _items.FirstOrDefault(
            i => i.InternalId == internalId);

        return Task.FromResult(item);
    }

    public Task<IReadOnlyList<Item>> GetItemsAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_items);
    }

    // Sales order operations

    public Task<SalesOrder?> GetSalesOrderByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var salesOrder = _salesOrders.FirstOrDefault(
            so => so.InternalId == internalId);

        return Task.FromResult(salesOrder);
    }

    public Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_salesOrders);
    }

    // SuiteQL operation

    public Task<string> ExecuteSuiteQlAsync(
        string query,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        var response = new
        {
            IsMock = true,
            Query = query,
            Message = "This is a mock SuiteQL response. " +
                      "No query was executed against NetSuite."
        };

        var jsonResponse = JsonSerializer.Serialize(
            response,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        return Task.FromResult(jsonResponse);
    }
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

## File: src/NetSuiteIntegration.Api/Program.cs
```csharp
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Infrastructure.Clients;
using Microsoft.Extensions.Options;
using NetSuiteIntegration.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSingleton<INetSuiteClient, MockNetSuiteClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Temporary integration test endpoint
app.MapGet(
    "/integration-test/customer/{internalId}",
    async (
        string internalId,
        INetSuiteClient netSuiteClient,
        CancellationToken cancellationToken) =>
    {
        var customer = await netSuiteClient.GetCustomerByIdAsync(
            internalId,
            cancellationToken);

        return customer is null
            ? Results.NotFound(new { message = "Customer not found" })
            : Results.Ok(customer);
    });

// Bind NetSuite configuration
builder.Services.Configure<NetSuiteOptions>(
    builder.Configuration.GetSection("NetSuite"));

// Configure HTTP client for NetSuite REST API
builder.Services.AddHttpClient("NetSuite", (serviceProvider, client) =>
{
    var options = serviceProvider
        .GetRequiredService<IOptions<NetSuiteOptions>>()
        .Value;

    if (!string.IsNullOrWhiteSpace(options.BaseUrl))
    {
        if (!Uri.TryCreate(
            options.BaseUrl,
            UriKind.Absolute,
            out var baseUri) ||
            (baseUri.Scheme != Uri.UriSchemeHttps))
        {
            throw new InvalidOperationException(
                "NetSuite BaseUrl must be a valid HTTPS URL.");
        }

        client.BaseAddress = new Uri(
            options.BaseUrl.TrimEnd('/') + "/");
    }

    client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

    client.Timeout = TimeSpan.FromSeconds(30);
});


app.Run();
```
