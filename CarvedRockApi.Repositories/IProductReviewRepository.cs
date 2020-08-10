using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRockApi.Repositories.Models;

namespace CarvedRockApi.Repositories
{
    public interface IProductReviewRepository : IRepository<ProductReview, int>
    {
        Task<ILookup<int, ProductReview>> GetReviewsByProductId(IEnumerable<int> productIds);
    }
}