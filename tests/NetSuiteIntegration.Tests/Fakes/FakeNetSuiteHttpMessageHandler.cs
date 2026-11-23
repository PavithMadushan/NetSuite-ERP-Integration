
using System.Net;

namespace NetSuiteIntegration.Tests.Fakes;

public sealed class FakeNetSuiteHttpMessageHandler : HttpMessageHandler
{
    private readonly Func<
        HttpRequestMessage,
        CancellationToken,
        Task<HttpResponseMessage>> _responseFactory;

    // Properties used by tests to inspect the outgoing request.
    public HttpMethod? LastMethod { get; private set; }

    public Uri? LastRequestUri { get; private set; }

    public string? LastAuthorizationScheme { get; private set; }

    public string? LastAuthorizationParameter { get; private set; }

    public string? LastAcceptHeader { get; private set; }

    public FakeNetSuiteHttpMessageHandler(
        Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>
            responseFactory)
    {
        _responseFactory = responseFactory;
    }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        // Capture request details before HttpClient disposes the request.
        LastMethod = request.Method;
        LastRequestUri = request.RequestUri;

        LastAuthorizationScheme =
            request.Headers.Authorization?.Scheme;

        LastAuthorizationParameter =
            request.Headers.Authorization?.Parameter;

        LastAcceptHeader = string.Join(
            ",",
            request.Headers.Accept.Select(header => header.MediaType));

        // Return the simulated server response.
        return _responseFactory(request, cancellationToken);
    }
}
