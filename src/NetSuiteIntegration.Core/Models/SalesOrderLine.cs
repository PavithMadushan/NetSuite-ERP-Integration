
namespace NetSuiteIntegration.Core.Models;

public class SalesOrderLine
{
    public int LineNumber { get; set; }

    // Reference to the NetSuite item
    public string? ItemInternalId { get; set; }
    public string? Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
}
