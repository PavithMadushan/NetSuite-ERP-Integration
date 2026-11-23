using System.Net;
using System.Text;
using NetSuiteIntegration.Infrastructure.Authentication;
using NetSuiteIntegration.Infrastructure.Clients;
using NetSuiteIntegration.Tests.Fakes;

namespace NetSuiteIntegration.Tests;

public class NetSuiteRestClientTests
{
    // TEST 1- SUCCESSFUL CUSTOMER RETRIEVAL
    [Fact]
    public async Task GetCustomerByIdAsync_ReturnsCustomer_WhenApiReturns200()
    {
        // Arrange

        // Simulated JSON response from NetSuite.
        const string jsonResponse =
            """
            {
                "id": "105",
                "externalId": "CUST-001",
                "companyName": "ABC Technologies (Pvt) Ltd",
                "firstName": "John",
                "lastName": "Perera",
                "email": "john@abctech.com",
                "phone": "0771234567",
                "subsidiary": {
                    "id": "1",
                    "refName": "Parent Company"
                },
                "isInactive": false
            }
            """;

        // Create a fake HTTP handler that returns HTTP 200.
        var fakeHandler = new FakeNetSuiteHttpMessageHandler(
            (request, cancellationToken) =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        jsonResponse,
                        Encoding.UTF8,
                        "application/json")
                };

                return Task.FromResult(response);
            });

        // Create HttpClient using our fake handler.
        using var httpClient = new HttpClient(fakeHandler)
        {
            BaseAddress = new Uri("https://example.test/")
        };

        // Use our existing mock token provider.
        var tokenProvider = new MockNetSuiteTokenProvider();

        // Create the REST client.
        var restClient = new NetSuiteRestClient(
            httpClient,
            tokenProvider);

        // Act

        var customer = await restClient.GetCustomerByIdAsync("105");

        // Assert: Customer mapping

        Assert.NotNull(customer);

        Assert.Equal("105", customer.InternalId);
        Assert.Equal("CUST-001", customer.ExternalId);
        Assert.Equal("ABC Technologies (Pvt) Ltd", customer.CompanyName);
        Assert.Equal("John", customer.FirstName);
        Assert.Equal("Perera", customer.LastName);
        Assert.Equal("john@abctech.com", customer.Email);
        Assert.Equal("0771234567", customer.Phone);
        Assert.Equal("1", customer.SubsidiaryInternalId);
        Assert.False(customer.IsInactive);

        // Assert: HTTP request details

        Assert.Equal(HttpMethod.Get, fakeHandler.LastMethod);

        Assert.Equal(
            "https://example.test/services/rest/record/v1/customer/105",
            fakeHandler.LastRequestUri?.ToString());

        Assert.Equal("Bearer", fakeHandler.LastAuthorizationScheme);

        Assert.Equal(
            "mock-access-token",
            fakeHandler.LastAuthorizationParameter);

        Assert.Contains(
            "application/json",
            fakeHandler.LastAcceptHeader);
    }

    // TEST 2- CUSTOMER NOT FOUND
    [Fact]
    public async Task GetCustomerByIdAsync_ReturnsNull_WhenApiReturns404()
    {
        // Arrange

        var fakeHandler = new FakeNetSuiteHttpMessageHandler(
            (request, cancellationToken) =>
            {
                var response = new HttpResponseMessage(
                    HttpStatusCode.NotFound);

                return Task.FromResult(response);
            });

        using var httpClient = new HttpClient(fakeHandler)
        {
            BaseAddress = new Uri("https://example.test/")
        };

        var tokenProvider = new MockNetSuiteTokenProvider();

        var restClient = new NetSuiteRestClient(
            httpClient,
            tokenProvider);

        // Act

        var customer = await restClient.GetCustomerByIdAsync("999");

        // Assert

        Assert.Null(customer);

        Assert.Equal(
            "https://example.test/services/rest/record/v1/customer/999",
            fakeHandler.LastRequestUri?.ToString());
    }

    // TEST 3- SERVER ERROR

    [Fact]
    public async Task GetCustomerByIdAsync_ThrowsException_WhenApiReturns500()
    {
        // Arrange

        var fakeHandler = new FakeNetSuiteHttpMessageHandler(
            (request, cancellationToken) =>
            {
                var response = new HttpResponseMessage(
                    HttpStatusCode.InternalServerError);

                return Task.FromResult(response);
            });

        using var httpClient = new HttpClient(fakeHandler)
        {
            BaseAddress = new Uri("https://example.test/")
        };

        var tokenProvider = new MockNetSuiteTokenProvider();

        var restClient = new NetSuiteRestClient(
            httpClient,
            tokenProvider);

        // Act & Assert

        await Assert.ThrowsAsync<HttpRequestException>(
            () => restClient.GetCustomerByIdAsync("105"));
    }
}
