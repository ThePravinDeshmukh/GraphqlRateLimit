using CarvedRockApi.Repositories.Models;
using GraphQL.Types;

namespace CarvedRockApi.GraphQL.Types
{
    public class ProductReviewType : ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(t => t.Id).Description("The id of the review");
            Field(t => t.Title).Description("The title of the review");
            Field(t => t.Review).Description("The product review");
            Field(t => t.ProductId).Description("The id if the product, this review is for.");
        }
    }
}