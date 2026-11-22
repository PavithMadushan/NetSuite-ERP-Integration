
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
