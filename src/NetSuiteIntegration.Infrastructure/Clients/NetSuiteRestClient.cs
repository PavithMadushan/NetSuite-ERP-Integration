using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Infrastructure.Clients;

public class NetSuiteRestClient : INetSuiteClient
{
    private readonly HttpClient _httpClient;
    private readonly INetSuiteTokenProvider _tokenProvider;

    // Constructor injection:
    // HttpClient sends HTTP requests.
    // INetSuiteTokenProvider supplies the access token.
    public NetSuiteRestClient(HttpClient httpClient,INetSuiteTokenProvider tokenProvider)
    {
        _httpClient = httpClient;
        _tokenProvider = tokenProvider;
    }

    // CUSTOMER- GET CUSTOMER BY INTERNAL ID
    public async Task<Customer?> GetCustomerByIdAsync(string internalId, CancellationToken cancellationToken = default)
    {
        // Validate the supplied customer ID.
        ArgumentException.ThrowIfNullOrWhiteSpace(internalId);

        // Obtain an access token.
        var accessToken = await _tokenProvider.GetAccessTokenAsync(
            cancellationToken);

        // Construct the NetSuite REST API endpoint.
        var requestUrl =
            $"services/rest/record/v1/customer/{Uri.EscapeDataString(internalId)}";

        //Create an HTTP GET request.
        using var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

        //Attach bearer-token authentication.
        request.Headers.Authorization =
            new AuthenticationHeaderValue("Bearer", accessToken);

        //Specify that we expect JSON.
        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        //Send the request to the server.
        using var response = await _httpClient.SendAsync(
            request,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken);

        //Handle the case where the customer does not exist.
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }

        // Throw an HttpRequestException for other unsuccessful responses.
        response.EnsureSuccessStatusCode();

        //Read the JSON response.
        await using var responseStream =
            await response.Content.ReadAsStreamAsync(cancellationToken);

        using var document = await JsonDocument.ParseAsync(
            responseStream,
            cancellationToken: cancellationToken);

        var root = document.RootElement;

        //Extract subsidiary internal ID.
        string? subsidiaryInternalId = null;

        if (root.TryGetProperty("subsidiary", out var subsidiary) &&
            subsidiary.ValueKind == JsonValueKind.Object)
        {
            subsidiaryInternalId = ReadString(subsidiary, "id");
        }

        // Map NetSuite JSON properties to our Customer model.
        var customer = new Customer
        {
            InternalId = ReadString(root, "id"),
            ExternalId = ReadString(root, "externalId"),
            CompanyName = ReadString(root, "companyName"),
            FirstName = ReadString(root, "firstName"),
            LastName = ReadString(root, "lastName"),
            Email = ReadString(root, "email"),
            Phone = ReadString(root, "phone"),
            SubsidiaryInternalId = subsidiaryInternalId,
            IsInactive = ReadBoolean(root, "isInactive")
        };

        return customer;
    }

    // HELPER-READ JSON STRING
    private static string? ReadString(
        JsonElement element,
        string propertyName)
    {
        if (!element.TryGetProperty(propertyName, out var property))
        {
            return null;
        }

        return property.ValueKind switch
        {
            JsonValueKind.String => property.GetString(),

            // Some API identifiers may be represented as numbers.
            JsonValueKind.Number => property.ToString(),

            _ => null
        };
    }

    // HELPER- READ JSON BOOLEAN
    private static bool ReadBoolean(
        JsonElement element,
        string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) &&
               property.ValueKind == JsonValueKind.True;
    }

    // CUSTOMER: GET ALL CUSTOMERS
    public Task<IReadOnlyList<Customer>> GetCustomersAsync(
        CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Customer collection retrieval is not implemented yet.");
    }


    // ITEM- GET ITEM BY INTERNAL ID
    public Task<Item?> GetItemByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Item retrieval is not implemented yet.");
    }

    // ITEM - GET ALL ITEMS
    public Task<IReadOnlyList<Item>> GetItemsAsync(
        CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Item collection retrieval is not implemented yet.");
    }

    // SALES ORDER - GET BY INTERNAL ID
    public Task<SalesOrder?> GetSalesOrderByIdAsync(string internalId,CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Sales order retrieval is not implemented yet.");
    }

    // SALES ORDER - GET ALL SALES ORDERS
    public Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(
        CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Sales order collection retrieval is not implemented yet.");
    }

    // SUITEQL- EXECUTE QUERY
    public Task<string> ExecuteSuiteQlAsync(
        string query,
        CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "SuiteQL execution is not implemented yet.");
    }
}
