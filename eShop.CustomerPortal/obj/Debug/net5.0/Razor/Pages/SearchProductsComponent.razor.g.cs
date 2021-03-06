#pragma checksum "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7b73adff2f6d885210741b4491345748771dd2"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.CustomerPortal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using eShop.UseCase.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using eShop.UseCase.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using eShop.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\_Imports.razor"
using eShop.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class SearchProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Products</h3>\n<br>\n\n");
            __builder.OpenComponent<eShop.Common.Controls.SearchBarComponent>(1);
            __builder.AddAttribute(2, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 8 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
                              HandleSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n<br>\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>\n                Name\n            </th>\n            <th>\n                Brand\n            </th>\n            <th>\n                Price\n            </th></tr></thead>\n    ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 26 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
         if (products != null && products.Count() > 0)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
 foreach (var product in products)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<eShop.CustomerPortal.Controls.ProductItemComponent>(8);
            __builder.AddAttribute(9, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<eShop.CoreBusiness.Models.Product>(
#nullable restore
#line 30 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
                               product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
                                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
                                                                 }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<tr><td colspan=\"3\">\n        Cannot find products\n    </td></tr>");
#nullable restore
#line 37 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\SearchProductsComponent.razor"
        private IEnumerable<Product> products;

            protected override void OnInitialized()
            {
                base.OnInitialized();

                products = searchProductUseCase.Execute();
            }

            private void HandleSearch(string filter)
            {
                products = searchProductUseCase.Execute(filter);
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProductUseCase searchProductUseCase { get; set; }
    }
}
#pragma warning restore 1591
