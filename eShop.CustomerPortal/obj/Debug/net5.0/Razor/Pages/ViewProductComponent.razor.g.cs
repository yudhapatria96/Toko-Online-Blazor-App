#pragma checksum "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd9d77fbb9b2804555c72abae4428cac6e3443c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Product Details</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "style", "width: 28rem;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 9 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor"
                   product.LinkImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor"
                                product.NamaProduk

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "h6");
            __builder.AddAttribute(14, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(15, 
#nullable restore
#line 11 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor"
                                                   product.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        <hr>\n        ");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "\n            Price: ");
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "style", "color:darkred");
            __builder.AddContent(21, 
#nullable restore
#line 14 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor"
                                                 product.Harga.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n<br>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "href", "products");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(26, "Back to Products");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\yudha\source\repos\eShop\eShop.CustomerPortal\Pages\ViewProductComponent.razor"
        private Product product;

            [Parameter]
            public int Id { get; set; }

            protected override void OnParametersSet()
            {
                base.OnParametersSet();

                if (Id > 0)
                    product = viewProductUseCase.Execute(Id);

            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewProductUseCase viewProductUseCase { get; set; }
    }
}
#pragma warning restore 1591
