using Microsoft.Extensions.Options;
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Infrastructure.Clients;
using NetSuiteIntegration.Infrastructure.Configuration;
using NetSuiteIntegration.Infrastructure.Authentication;

var builder = WebApplication.CreateBuilder(args);

// 1. Register application services

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// 2. Register NetSuite configuration

builder.Services.Configure<NetSuiteOptions>(
    builder.Configuration.GetSection("NetSuite"));

// 3. Configure NetSuite HttpClient

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
            baseUri.Scheme != Uri.UriSchemeHttps)
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

// 4. Register NetSuite implementation

builder.Services.AddSingleton<INetSuiteClient, MockNetSuiteClient>();

builder.Services.AddSingleton<INetSuiteTokenProvider, MockNetSuiteTokenProvider>();

// 5. Build application

var app = builder.Build();

// 6. Configure HTTP request pipeline

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();


// 7. Temporary integration test endpoint

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

app.Run();
