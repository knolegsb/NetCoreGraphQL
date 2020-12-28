using GraphQL;
using GraphQL.Types;
using NetCoreGraphQL.Interfaces;
using NetCoreGraphQL.Models;
using NetCoreGraphQL.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {

            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
             resolve: context =>
             {
                 return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
             });

        }
    }
}
