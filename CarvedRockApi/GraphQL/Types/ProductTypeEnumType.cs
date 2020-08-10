using GraphQL.Types;

namespace CarvedRockApi.GraphQL.Types
{
    public class ProductTypeEnumType : EnumerationGraphType<CarvedRock.Repositories.Models.ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of the product";
        }
    }
}