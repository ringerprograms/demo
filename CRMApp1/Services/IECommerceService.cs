using CRMApp1.Models.ECommerce;

namespace CRMApp1.ECommerce
{
    public interface IECommerceService
    {
        Task<List<RevenueType>> GetRevenueList();
    }
}
