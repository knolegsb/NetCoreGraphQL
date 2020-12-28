using GraphQL;
using GraphQL.Types;
using NetCoreGraphQL.Interfaces;
using NetCoreGraphQL.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(); });
            Field<ListGraphType<SubMenuType>>("submenuById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
              resolve: context =>
              {
                  return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
              });
        }
    }
}
