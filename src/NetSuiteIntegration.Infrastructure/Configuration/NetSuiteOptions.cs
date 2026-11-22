namespace NetSuiteIntegration.Infrastructure.Configuration
{
    public class NetSuiteOptions
    {
        public string AccountId { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
        public bool UseMock { get; set; } = true;
    }
}
