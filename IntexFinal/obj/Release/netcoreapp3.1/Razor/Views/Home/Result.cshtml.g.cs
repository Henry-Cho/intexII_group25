#pragma checksum "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d894a1866de3895617038032a082233f82c3603f"
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
#line 1 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/_ViewImports.cshtml"
using IntexFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d894a1866de3895617038032a082233f82c3603f", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f013c28b563bf241ea45272ccf6933b75901831", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prediction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("multi-range-field my-10 pb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeverityCalculator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
  
    ViewBag.Title = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
 if (Model.PredictedValue < 2.0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-area no-injury"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 offset-lg-2 text-center"">
                    <div class=""hero-text"">
                        <div class=""hero-text-tablecell"">
                            <p class=""subtitle"">Predicted Results</p>
                            <h1 class=""result-comment"">NO INJURY</h1>
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f5930", async() => {
                WriteLiteral("\n                                    <input type=\"range\" class=\"form-range\" id=\"disabledRange\" display=\"color: red; background-color: red;\" min=\"0.00\" max=\"5.00\" step=\"0.01\"\n                                           color=\"red\"");
                BeginWriteAttribute("value", " value=\"", 951, "\"", 998, 1);
#nullable restore
#line 22 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
WriteAttributeValue("", 959, Math.Round((@Model.PredictedValue), 2), 959, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <p class=\"result-score\">Severity Score: ");
#nullable restore
#line 25 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
                                                               Write(Math.Round((@Model.PredictedValue), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <div class=\"hero-btns\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f8405", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n       \n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 36 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
}

else if (Model.PredictedValue < 3.0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-area possible-injury"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 offset-lg-2 text-center"">
                    <div class=""hero-text"">
                        <div class=""hero-text-tablecell"">
                            <p class=""subtitle"">Predicted Results</p>
                            <h1 class=""result-comment"">POSSIBLE INJURY</h1>
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f10738", async() => {
                WriteLiteral("\n                                    <input type=\"range\" class=\"form-range\" id=\"disabledRange\" display=\"color: red; background-color: red;\" min=\"0.00\" max=\"5.00\" step=\"0.01\"\n                                           color=\"red\"");
                BeginWriteAttribute("value", " value=\"", 2333, "\"", 2380, 1);
#nullable restore
#line 51 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
WriteAttributeValue("", 2341, Math.Round((@Model.PredictedValue), 2), 2341, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <p class=\"result-score\">Severity Score: ");
#nullable restore
#line 54 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
                                                               Write(Math.Round((@Model.PredictedValue), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <div class=\"hero-btns\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f13218", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n       \n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 65 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
}

else if (Model.PredictedValue < 4.0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-area suspected-minor-injury"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 offset-lg-2 text-center"">
                    <div class=""hero-text"">
                        <div class=""hero-text-tablecell"">
                            <p class=""subtitle"">Predicted Results</p>
                            <h1 class=""result-comment"">SUSPECTED MINOR INJURY</h1>
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f15566", async() => {
                WriteLiteral("\n                                    <input type=\"range\" class=\"form-range\" id=\"disabledRange\" display=\"color: red; background-color: red;\" min=\"0.00\" max=\"5.00\" step=\"0.01\"\n                                           color=\"red\"");
                BeginWriteAttribute("value", " value=\"", 3729, "\"", 3776, 1);
#nullable restore
#line 80 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
WriteAttributeValue("", 3737, Math.Round((@Model.PredictedValue), 2), 3737, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <p class=\"result-score\">Severity Score: ");
#nullable restore
#line 83 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
                                                               Write(Math.Round((@Model.PredictedValue), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <div class=\"hero-btns\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f18046", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 93 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
}

else if (Model.PredictedValue < 5.0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-area suspected-serious-injury"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 offset-lg-2 text-center"">
                    <div class=""hero-text"">
                        <div class=""hero-text-tablecell"">
                            <p class=""subtitle"">Predicted Results</p>
                            <h1 class=""result-comment"">SUSPECTED SERIOUS INJURY</h1>
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f20389", async() => {
                WriteLiteral("\n                                    <input type=\"range\" class=\"form-range\" id=\"disabledRange\" display=\"color: red; background-color: red;\" min=\"0.00\" max=\"5.00\" step=\"0.01\"\n                                           color=\"red\"");
                BeginWriteAttribute("value", " value=\"", 5121, "\"", 5168, 1);
#nullable restore
#line 108 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
WriteAttributeValue("", 5129, Math.Round((@Model.PredictedValue), 2), 5129, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <p class=\"result-score\">Severity Score: ");
#nullable restore
#line 111 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
                                                               Write(Math.Round((@Model.PredictedValue), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <div class=\"hero-btns\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f22871", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 121 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-area fatal"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 offset-lg-2 text-center"">
                    <div class=""hero-text"">
                        <div class=""hero-text-tablecell"">
                            <p class=""subtitle"">Predicted Results</p>
                            <h1 class=""result-comment"">FATAL</h1>
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f25145", async() => {
                WriteLiteral("\n                                    <input type=\"range\" class=\"form-range\" id=\"disabledRange\" display=\"color: red; background-color: red;\" min=\"0.00\" max=\"5.00\" step=\"0.01\"\n                                           color=\"red\"");
                BeginWriteAttribute("value", " value=\"", 6443, "\"", 6490, 1);
#nullable restore
#line 136 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
WriteAttributeValue("", 6451, Math.Round((@Model.PredictedValue), 2), 6451, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <p class=\"result-score\">Predicted Severity Score: ");
#nullable restore
#line 139 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
                                                                         Write(Math.Round((@Model.PredictedValue), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <div class=\"hero-btns\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d894a1866de3895617038032a082233f82c3603f27647", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n       \n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 150 "/Users/dongking/Documents/GitHub/intexII_group25/IntexFinal/Views/Home/Result.cshtml"
}

#line default
#line hidden
#nullable disable
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