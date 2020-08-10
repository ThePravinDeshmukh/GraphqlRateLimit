using GraphQL;
using GraphQL.Types;

namespace CarvedRockApi.GraphQL
{
    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}
