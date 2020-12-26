using NetCoreGraphQL.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Schema
{
    public class ProductSchema : GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery)
        {
            Query = productQuery;
        }
    }
}
