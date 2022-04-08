#pragma checksum "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc20303728fa88d360ca8670205a5fe4252d48e"
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
#line 1 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/_Imports.razor"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
using IntexFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/incidents/{Page:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Incidents : OwningComponentBase<ICrashRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"hero-image\">\n    <div class=\"hero-text\">\n        <h1 style=\"font-size: 5rem;\">Admin</h1>\n    </div>\n</div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container mt-2 mb-2");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "class", "btn boxed-btn mb-2");
            __builder.AddAttribute(6, "href", "/admin/incidents/create");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Enter New Data");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-sm table-striped table-bordered ");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, @"<thead class=""thead-dark""> 
            <tr>
                <th>Crash Id</th>
                <th>Crash Datetime</th>
                <th>City</th>
                <th>Mainroad Name</th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 26 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
             if (IncidentData?.Count() > 0)
            {
                //List the Data
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                 foreach (crash_data c in IncidentData)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                    ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                             c.crash_ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 33 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                             c.crash_datetime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 34 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                             c.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 35 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                             c.main_road_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\n                            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "d-flex justify-content-center");
            __builder.AddMarkupContent(35, "\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "btn boxed-btn mr-2");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 38 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                                                                           GetDetailsUrl(c.crash_ID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "btn bordered-btn text-dark bg-white mr-2");
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 39 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                                                                                                 GetEditUrl(c.crash_ID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "btn btn-danger text-white");
            __builder.AddAttribute(50, "style", "border-radius: 50px; padding-top: 10px;");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                                                                                                                                     () => RemoveCrashData(c)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Delete");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n");
#nullable restore
#line 44 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.AddMarkupContent(59, "<tr>\n                    <td colspan=\"5\" class=\"text-center\">No Incidents to Show</td>\n                </tr>\n");
#nullable restore
#line 51 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n    ");
            __builder.OpenComponent<IntexFinal.Pages.Admin.Paging>(63);
            __builder.AddAttribute(64, "PI", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IntexFinal.Models.ViewModels.PagingInfo>(
#nullable restore
#line 54 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                pagingInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "PageClassesEnabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "PageClass", "Paging");
            __builder.AddAttribute(67, "PageClassSelected", "active");
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Pages/Admin/Incidents.razor"
       
        [Parameter]
        public int page { get; set; }

        PagingInfo pagingInfo = new PagingInfo();

    public ICrashRepository repo => Service;

    public IEnumerable<crash_data> IncidentData { get; set; }

    //protected async override Task OnInitializedAsync()
    //{
    //    await UpdateData();
    //}

    //public async Task UpdateData()
    //{
    //    IncidentData = await repo.crash_data.ToListAsync();

    //}

    protected override void OnParametersSet()
    {
        CreatePagingInfo();
    }

    public string GetDetailsUrl(long id) => $"/admin/incidents/details/{id}";
    public string GetEditUrl(long id) => $"/admin/incidents/edit/{id}";

    public async Task RemoveCrashData(crash_data c)
    {
        if (!await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete this incident?"))
        {
            return;
        }

        repo.DeleteCrashData(c);
        CreatePagingInfo();
    }
    public void CreatePagingInfo()
    {
        var AllData = repo.crash_data;

        int PageSize = 7;
        pagingInfo = new PagingInfo();
        page = page == 0 ? 1 : page;
        pagingInfo.CurrentPage = page;
        pagingInfo.TotalItems = AllData.Count();
        pagingInfo.ItemsPerPage = PageSize;

        var skip = PageSize * (Convert.ToInt32(page) - 1);
        IncidentData = AllData.Skip(skip).Take(PageSize).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591