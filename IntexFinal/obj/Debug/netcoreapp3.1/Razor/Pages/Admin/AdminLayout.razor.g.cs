#pragma checksum "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0bb7bdef7bf0e198d1f9c020e73766e62c14a2a"
// <auto-generated/>
#pragma warning disable 1591
namespace IntexFinal.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""big-info text-white p-2"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col"">
                <span class=""navbar-brand m-lg-2"">Utah CarCrash Admin</span>
            </div>

            <div class=""col-2 text-right"">
                <a href=""/account/logout"" class=""btn btn-sm btn-primary"">Log Out</a>
            </div>
        </div>

    </div>

</div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2 d-grid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddMarkupContent(9, "\r\n            ");
#nullable restore
#line 30 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\AdminLayout.razor"
__builder.AddContent(10, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
