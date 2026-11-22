
using System.Text.Json;
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Infrastructure.Clients;

public class MockNetSuiteClient : INetSuiteClient
{
    // Sample customer data
    private readonly IReadOnlyList<Customer> _customers =
    [
        new Customer
        {
            InternalId = "105",
            ExternalId = "CUST-001",
            CompanyName = "ABC Technologies (Pvt) Ltd",
            FirstName = "John",
            LastName = "Perera",
            Email = "john@abctech.com",
            Phone = "0771234567",
            SubsidiaryInternalId = "1",
            IsInactive = false
        },
        new Customer
        {
            InternalId = "106",
            ExternalId = "CUST-002",
            CompanyName = "XYZ Solutions (Pvt) Ltd",
            FirstName = "Sarah",
            LastName = "Fernando",
            Email = "sarah@xyzsolutions.com",
            Phone = "0719876543",
            SubsidiaryInternalId = "1",
            IsInactive = false
        }
    ];

    // Sample item data
    private readonly IReadOnlyList<Item> _items =
    [
        new Item
        {
            InternalId = "205",
            ExternalId = "ITEM-001",
            ItemName = "LAPTOP-001",
            DisplayName = "Dell Laptop",
            ItemType = "Inventory",
            SKU = "DELL-LAP-001",
            Description = "Dell business laptop",
            BasePrice = 250000m,
            IsInactive = false
        },
        new Item
        {
            InternalId = "206",
            ExternalId = "ITEM-002",
            ItemName = "MOUSE-001",
            DisplayName = "Wireless Mouse",
            ItemType = "Inventory",
            SKU = "MOU-WRL-001",
            Description = "Wireless optical mouse",
            BasePrice = 13000m,
            IsInactive = false
        }
    ];

    // Sample sales order data
    private readonly IReadOnlyList<SalesOrder> _salesOrders =
    [
        new SalesOrder
        {
            InternalId = "5001",
            ExternalId = "SO-EXT-001",
            TransactionNumber = "SO1001",
            CustomerInternalId = "105",
            TransactionDate = new DateOnly(2026, 11, 20),
            Status = "Pending Fulfillment",
            CurrencyInternalId = "1",
            Memo = "Sample sales order",
            Total = 526000m,

            Lines =
            [
                new SalesOrderLine
                {
                    LineNumber = 1,
                    ItemInternalId = "205",
                    Description = "Dell Laptop",
                    Quantity = 2,
                    Rate = 250000m,
                    Amount = 500000m
                },
                new SalesOrderLine
                {
                    LineNumber = 2,
                    ItemInternalId = "206",
                    Description = "Wireless Mouse",
                    Quantity = 2,
                    Rate = 13000m,
                    Amount = 26000m
                }
            ]
        }
    ];

    // Customer operations
    public Task<Customer?> GetCustomerByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var customer = _customers.FirstOrDefault(
            c => c.InternalId == internalId);

        return Task.FromResult(customer);
    }

    public Task<IReadOnlyList<Customer>> GetCustomersAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_customers);
    }

    // Item operations
    public Task<Item?> GetItemByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var item = _items.FirstOrDefault(
            i => i.InternalId == internalId);

        return Task.FromResult(item);
    }

    public Task<IReadOnlyList<Item>> GetItemsAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_items);
    }

    // Sales order operations

    public Task<SalesOrder?> GetSalesOrderByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var salesOrder = _salesOrders.FirstOrDefault(
            so => so.InternalId == internalId);

        return Task.FromResult(salesOrder);
    }

    public Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(_salesOrders);
    }

    // SuiteQL operation

    public Task<string> ExecuteSuiteQlAsync(
        string query,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        ArgumentException.ThrowIfNullOrWhiteSpace(query);

        var response = new
        {
            IsMock = true,
            Query = query,
            Message = "This is a mock SuiteQL response. " +
                      "No query was executed against NetSuite."
        };

        var jsonResponse = JsonSerializer.Serialize(
            response,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        return Task.FromResult(jsonResponse);
    }
}
