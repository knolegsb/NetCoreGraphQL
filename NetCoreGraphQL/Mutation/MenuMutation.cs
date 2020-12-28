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
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context =>
                {
                    return menuService.AddMenu(context.GetArgument<Menu>("menu"));
                });
        }
    }
}
