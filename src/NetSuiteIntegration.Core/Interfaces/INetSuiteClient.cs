using NetSuiteIntegration.Core.Models;

namespace NetSuiteIntegration.Core.Interfaces
{
    public interface INetSuiteClient
    {
        // Customers
        Task<Customer?> GetCustomerByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Customer>> GetCustomersAsync(CancellationToken cancellationToken = default);

        // Items
        Task<Item?> GetItemByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Item>> GetItemsAsync(CancellationToken cancellationToken = default);

        // Sales Orders
        Task<SalesOrder?> GetSalesOrderByIdAsync(string internalId,CancellationToken cancellationToken = default);
        Task<IReadOnlyList<SalesOrder>> GetSalesOrdersAsync(CancellationToken cancellationToken = default);

        // SuiteQL
        Task<string> ExecuteSuiteQlAsync(string query,CancellationToken cancellationToken = default);
    }
}
