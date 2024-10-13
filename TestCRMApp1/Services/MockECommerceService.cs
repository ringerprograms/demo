using CRMApp1.Models.ECommerce;

namespace CRMApp1.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<RevenueType>> GetRevenueList()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}
