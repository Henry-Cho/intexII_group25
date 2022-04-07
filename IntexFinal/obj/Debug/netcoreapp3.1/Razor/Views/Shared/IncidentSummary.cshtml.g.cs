#pragma checksum "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89babea498543642469b03a29f4388cf42d5e61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_IncidentSummary), @"mvc.1.0.view", @"/Views/Shared/IncidentSummary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\_ViewImports.cshtml"
using IntexFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\_ViewImports.cshtml"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\_ViewImports.cshtml"
using IntexFinal.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\_ViewImports.cshtml"
using IntexFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89babea498543642469b03a29f4388cf42d5e61", @"/Views/Shared/IncidentSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c8e6a47a7845cee0d2934b2b34c6dd443b75e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_IncidentSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crash_data>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
   string results = "";

    foreach (PropertyInfo prop in typeof(crash_data).GetProperties())
    {
        if (prop.PropertyType == typeof(bool))
        {
            if(Convert.ToBoolean(prop.GetValue(Model, null)) == true)
            {
                var temp = prop.Name.Replace("_", " ");
                temp = char.ToUpper(temp[0]) + temp.Substring(1);
                results += temp + ", ";
           }
        }
    }
    results = results.Remove(results.Length - 2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""flip-card"">
        <div class=""flip-card-inner"">
            <div class=""flip-card-front"">
                <div class=""d-flex justify-content-between align-items-center headerpart"">
                    <h4 class=""mb-0 ml-3 text-white"">");
#nullable restore
#line 26 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                                                Write(Model.crash_datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4> \r\n                    <h4 class=\"mb-0 mr-3 text-white\">Severity: ");
#nullable restore
#line 27 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                                                          Write(Model.crash_severity_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <h5 class=\"mt-4 mx-2\">Tags: ");
#nullable restore
#line 29 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                                       Write(results);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                \r\n\r\n            </div>\r\n            <div class=\"flip-card-back\">\r\n                <h3 class=\"mt-2\">Incident Details</h3>\r\n                <ul>\r\n                    <li>Route: ");
#nullable restore
#line 36 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                          Write(Model.route);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Road: ");
#nullable restore
#line 37 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                         Write(Model.main_road_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>City: ");
#nullable restore
#line 38 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                         Write(Model.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>County: ");
#nullable restore
#line 39 "C:\Users\annad\OneDrive\Documents\GitHub\intexII_group25\IntexFinal\Views\Shared\IncidentSummary.cshtml"
                           Write(Model.county_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n<br />  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crash_data> Html { get; private set; }
    }
}
#pragma warning restore 1591
