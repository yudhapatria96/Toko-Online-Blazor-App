// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
