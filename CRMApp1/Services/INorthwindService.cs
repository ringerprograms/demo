using CRMApp1.Models.Northwind;

namespace CRMApp1.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
    }
}
