using NetSuiteIntegration.Core.Interfaces;

namespace NetSuiteIntegration.Infrastructure.Authentication;

public class MockNetSuiteTokenProvider : INetSuiteTokenProvider
{
    public Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        // This is only a placeholder.
        // It is NOT a real NetSuite access token.
        const string mockAccessToken = "mock-access-token";

        return Task.FromResult(mockAccessToken);
    }
}
