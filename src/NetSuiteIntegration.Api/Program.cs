using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Infrastructure.Clients;

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


app.Run();
