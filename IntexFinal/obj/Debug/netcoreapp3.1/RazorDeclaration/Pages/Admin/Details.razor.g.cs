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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/incidents/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Pages\Admin\Details.razor"
       
    [Inject]
    public ICrashRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public crash_data crash_Data { get; set; }

    protected override void OnParametersSet()
    {
        //set up to pull the crash data with the id we sent in
        crash_Data = repo.Crash_Data.FirstOrDefault(x => x.crash_ID == Id);
    }

    public string EditUrl => $"/admin/incidents/edit/{crash_Data.crash_ID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
