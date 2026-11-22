namespace NetSuiteIntegration.Core.Interfaces;

public interface INetSuiteTokenProvider
{
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default);
}
