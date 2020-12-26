using GraphQL.Types;
using NetCoreGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
