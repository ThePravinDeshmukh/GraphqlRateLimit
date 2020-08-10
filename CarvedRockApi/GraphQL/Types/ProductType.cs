using CarvedRock.Repositories.Models;
using CarvedRockApi.Repositories;
using CarvedRockApi.Repositories.Models;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace CarvedRockApi.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(IProductReviewRepository reviewRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id);
            Field(t => t.Name).Description("The name of the product");
            Field(t => t.Description).Description("The description of the product");
            Field(t => t.Price).Description("The price of the product");
            Field(t => t.Stock).Description("The stock of the product");
            Field(t => t.Rating).Description("The rating of the product");
            Field(t => t.IntroducedAt).Description("When the product was introduced");
            Field(t => t.PhotoFileName).Description("The photo file name of the product");
            Field<ProductTypeEnumType>("Type", "The product type");

            Field<ListGraphType<ProductReviewType>>(
                "reviews",
                resolve: context => 
                {
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, ProductReview>(
                        "GetReviewsByProductId", reviewRepository.GetReviewsByProductId);
                    
                    return loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
