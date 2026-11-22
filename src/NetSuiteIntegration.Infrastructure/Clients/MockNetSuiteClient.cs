
using NetSuiteIntegration.Core.Interfaces;
using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Infrastructure.Clients;

public class MockNetSuiteClient : INetSuiteClient
{
    // Sample customer data
    private readonly List<Customer> _customers =
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
            Email = "sarah@xyz.com",
            Phone = "0779876543",
            SubsidiaryInternalId = "1",
            IsInactive = false
        }
    ];

    // Sample item data
    private readonly List<Item> _items =
    [
        new Item
        {
            InternalId = "205",
            ExternalId = "ITEM-001",
            ItemName = "Dell Laptop",
            DisplayName = "Dell Laptop",
            ItemType = "Inventory",
            SKU = "DELL-LAP-001",
            Description = "Dell business laptop",
            BasePrice = 250000,
            IsInactive = false
        },
        new Item
        {
            InternalId = "206",
            ExternalId = "ITEM-002",
            ItemName = "Wireless Mouse",
            DisplayName = "Wireless Mouse",
            ItemType = "Inventory",
            SKU = "MOU-WRL-001",
            Description = "Wireless computer mouse",
            BasePrice = 13000,
            IsInactive = false
        }
    ];

    // Sample sales order data
    private readonly List<SalesOrder> _salesOrders =
    [
        new SalesOrder
        {
            InternalId = "5001",
            ExternalId = "SO-001",
            TransactionNumber = "SO1001",
            CustomerInternalId = "105",
            TransactionDate = new DateOnly(2026, 1, 15),
            Status = "Pending Fulfillment",
            CurrencyInternalId = "1",
            Memo = "Sample sales order",
            Total = 526000,
            Lines =
            [
                new SalesOrderLine
                {
                    LineNumber = 1,
                    ItemInternalId = "205",
                    Description = "Dell Laptop",
                    Quantity = 2,
                    Rate = 250000,
                    Amount = 500000
                },
                new SalesOrderLine
                {
                    LineNumber = 2,
                    ItemInternalId = "206",
                    Description = "Wireless Mouse",
                    Quantity = 2,
                    Rate = 13000,
                    Amount = 26000
                }
            ]
        }
    ];

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

        return Task.FromResult<IReadOnlyList<Customer>>(_customers);
    }

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

        return Task.FromResult<IReadOnlyList<Item>>(_items);
    }

    public Task<SalesOrder?> GetSalesOrderByIdAsync(
        string internalId,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var order = _salesOrders.FirstOrDefault(
            s => s.InternalId == internalId);

        return Task.FromResult(order);
    }

    public Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult<IReadOnlyList<SalesOrder>>(_salesOrders);
    }

    public Task<string> ExecuteSuiteQlAsync(
        string query,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        const string mockResponse =
            """
            {
                "message": "This is a mock SuiteQL response",
                "queryExecuted": true
            }
            """;

        return Task.FromResult(mockResponse);
    }
}
