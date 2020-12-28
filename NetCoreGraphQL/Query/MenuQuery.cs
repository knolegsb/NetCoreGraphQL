using GraphQL.Types;
using NetCoreGraphQL.Interfaces;
using NetCoreGraphQL.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menu", resolve: context => { return menuService.GetMenus(); });
        }
    }
}
