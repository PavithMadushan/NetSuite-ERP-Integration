
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
