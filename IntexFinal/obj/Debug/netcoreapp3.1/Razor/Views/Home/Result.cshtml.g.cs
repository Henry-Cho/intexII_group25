#pragma checksum "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3026a6fe1e3791d30970c40c99f876f37a4f9488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3026a6fe1e3791d30970c40c99f876f37a4f9488", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f013c28b563bf241ea45272ccf6933b75901831", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prediction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>");
#nullable restore
#line 8 "/Users/hyungseokcho/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
Write(Model.PredictedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prediction> Html { get; private set; }
    }
}
#pragma warning restore 1591
