
namespace NetSuiteIntegration.Core.Models;

public class SalesOrder
{
    // NetSuite identifiers
    public string? InternalId { get; set; }
    public string? ExternalId { get; set; }
    public string? TransactionNumber { get; set; }

    // Customer reference
    public string? CustomerInternalId { get; set; }

    // Transaction information
    public DateOnly TransactionDate { get; set; }
    public string? Status { get; set; }
    public string? CurrencyInternalId { get; set; }
    public string? Memo { get; set; }

    // Financial information
    public decimal Total { get; set; }

    // Multiple products in one sales order
    public List<SalesOrderLine> Lines { get; set; } = [];
}
