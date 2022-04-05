// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\Paging.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\Paging.razor"
using IntexFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class Paging : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\Paging.razor"
       
    [Parameter]
    public PagingInfo PI { get; set; }

    [Parameter]
    public bool PageClassesEnabled { get; set; } = false;

    [Parameter]
    public string PageClass { get; set; }

    [Parameter]
    public string PageClassSelected { get; set; }

    public string CreatePaging()
    {
        TagBuilder result = new TagBuilder("div");
        string anchorInnerHtml = "";

        for (int i = PI.CurrentPage - 3; i <= PI.TotalPages; i++)
        {
            if (i <= 0)
            {
                continue;
            }
            if (i > PI.CurrentPage + 3 || (i == PI.CurrentPage - 3))
            {
                TagBuilder tag = new TagBuilder("a");
                anchorInnerHtml = "...";

                if (anchorInnerHtml == "..")
                    tag.Attributes["href"] = "#";
                else if (i == 1)
                    tag.Attributes["href"] = "/admin";
                else
                    tag.Attributes["href"] = "/admin/Incidents/" + i;

                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PI.CurrentPage ? PageClassSelected : "");
                }

                tag.InnerHtml.Append(anchorInnerHtml);

                if (anchorInnerHtml != "")
                {
                    result.InnerHtml.AppendHtml(tag);
                }
                if (i > PI.CurrentPage + 3)
                {
                    break;
                }

            }
            else
            {
                TagBuilder tag = new TagBuilder("a");
                anchorInnerHtml = AnchorInnerHtml(i, PI);

                if (anchorInnerHtml == "..")
                    tag.Attributes["href"] = "#";
                else if (i == 1)
                    tag.Attributes["href"] = "/admin";
                else
                    tag.Attributes["href"] = "/admin/Incidents/" + i;

                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PI.CurrentPage ? PageClassSelected : "");
                }

                tag.InnerHtml.Append(anchorInnerHtml);

                if (anchorInnerHtml != "")
                    result.InnerHtml.AppendHtml(tag);
            }
        }

        System.IO.StringWriter writer = new System.IO.StringWriter();
        result.InnerHtml.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
        return writer.ToString();
    }

    public static string AnchorInnerHtml(int i, PagingInfo pagingInfo)
    {
        string anchorInnerHtml = "";
        if (pagingInfo.TotalPages <= 10)
            anchorInnerHtml = i.ToString();
        else
        {
            if (pagingInfo.CurrentPage <= 5)
            {
                if ((i <= 8) || (i == pagingInfo.TotalPages))
                    anchorInnerHtml = i.ToString();
                else if (i == pagingInfo.TotalPages - 1)
                    anchorInnerHtml = "..";
            }
            else if ((pagingInfo.CurrentPage > 5) && (pagingInfo.TotalPages - pagingInfo.CurrentPage >= 5))
            {
                if ((i == 1) || (i == pagingInfo.TotalPages) || ((pagingInfo.CurrentPage - i >= -3) && (pagingInfo.CurrentPage - i <= 3)))
                    anchorInnerHtml = i.ToString();
                else if ((i == pagingInfo.CurrentPage - 4) || (i == pagingInfo.CurrentPage + 4))
                    anchorInnerHtml = "..";
            }
            else if (pagingInfo.TotalPages - pagingInfo.CurrentPage < 5)
            {
                if ((i == 1) || (pagingInfo.TotalPages - i <= 7))
                    anchorInnerHtml = i.ToString();
                else if (pagingInfo.TotalPages - i == 8)
                    anchorInnerHtml = "..";
            }
        }
        return anchorInnerHtml;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591