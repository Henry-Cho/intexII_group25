#pragma checksum "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416e0b065f5b2786cfde17938a16078ed18a93cc"
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
#line 1 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\_Imports.razor"
using IntexFinal.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"~/lib/items/bootstrap/css/bootstrap.min.css\">\r\n    \r\n    <link rel=\"icon\" type=\"image/x-icon\" href=\"/img/car2-removebg-preview.png\">\r\n    \r\n    <link href=\"https://fonts.googleapis.com/css?family=Open+Sans:300,400,700\" rel=\"stylesheet\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=Poppins:400,700&display=swap\" rel=\"stylesheet\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/bootstrap/css/all.min.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/bootstrap/css/bootstrap.min.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/owl.carousel.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/magnific-popup.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/animate.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/meanmenu.min.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/main.css\">\r\n    \r\n    <link rel=\"stylesheet\" href=\"~/lib/items/css/responsive.css\">\r\n    <link rel=\"stylesheet\" href=\"~/css/site.css\">\r\n    <style>\r\n        a.boxed-btn {\r\n            font-family: \'Poppins\', sans-serif;\r\n            display: inline-block;\r\n            background-color: #F28123;\r\n            color: #fff;\r\n            padding: 10px 20px;\r\n            border-radius: 50px;\r\n            -webkit-transition: 0.3s;\r\n            -o-transition: 0.3s;\r\n            transition: 0.3s;\r\n        }\r\n\r\n            a.boxed-btn:hover {\r\n                background-color: #051922;\r\n                color: #F28123;\r\n            }\r\n\r\n        a.bordered-btn {\r\n            border-radius: 50px;\r\n            -webkit-transition: 0.3s;\r\n            -o-transition: 0.3s;\r\n            transition: 0.3s;\r\n            font-family: \'Poppins\', sans-serif;\r\n            display: inline-block;\r\n            color: #fff;\r\n            border: 2px solid #F28123;\r\n            padding: 10px 20px;\r\n        }\r\n\r\n            a.bordered-btn:hover {\r\n                background-color: #F28123 !important;\r\n                color: #fff;\r\n            }\r\n\r\n        button.boxed-btn {\r\n            font-family: \'Poppins\', sans-serif;\r\n            display: inline-block;\r\n            background-color: #F28123;\r\n            color: #fff;\r\n            padding: 10px 20px;\r\n            border-radius: 50px;\r\n            -webkit-transition: 0.3s;\r\n            -o-transition: 0.3s;\r\n            transition: 0.3s;\r\n        }\r\n\r\n            button.boxed-btn:hover {\r\n                background-color: #051922;\r\n                color: #F28123;\r\n            }\r\n\r\n        button.bordered-btn {\r\n            border-radius: 50px;\r\n            -webkit-transition: 0.3s;\r\n            -o-transition: 0.3s;\r\n            transition: 0.3s;\r\n            font-family: \'Poppins\', sans-serif;\r\n            display: inline-block;\r\n            color: #fff;\r\n            border: 2px solid #F28123;\r\n            padding: 10px 20px;\r\n        }\r\n\r\n            button.bordered-btn:hover {\r\n                background-color: #F28123 !important;\r\n                color: #fff;\r\n            }\r\n\r\n        .hero-image {\r\n            /* Use \"linear-gradient\" to add a darken background effect to the image (photographer.jpg). This will make the text easier to read */\r\n            background-image: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url(\'/img/hero.jpg\');\r\n            /* Set a specific height */\r\n            height: 25%;\r\n            /* Position and center the image to scale nicely on all screens */\r\n            background-position: center;\r\n            background-repeat: no-repeat;\r\n            background-size: cover;\r\n            position: relative;\r\n        }\r\n\r\n        /* Place text in the middle of the image */\r\n        .hero-text {\r\n            text-align: center;\r\n            position: absolute;\r\n            top: 50%;\r\n            left: 50%;\r\n            transform: translate(-50%, -50%);\r\n            color: white;\r\n        }\r\n    </style>\r\n</head>\r\n");
            __builder.AddMarkupContent(1, @"<div class=""big-info text-white p-2 bg-dark"">
    <div class=""container-fluid"">
        <div class=""row justify-content-between align-items-center"">
            <div class=""ml-3"">
                <span class=""navbar-brand m-lg-2"">Incidents Admin</span>
            </div>
            <div class=""d-flex align-items-center mr-3"">
                    <a href=""/accountmanage"" class=""btn bordered-btn mr-3"">My Account</a>
                    <a href=""/account/logout"" class=""btn bordered-btn"">Log Out</a>
            </div>
        </div>

    </div>

</div>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row d-grid");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col px-0 mx-0");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddContent(11, 
#nullable restore
#line 149 "C:\Users\Ransom Allphin\source\repos\intexII_group25\IntexFinal\Pages\Admin\AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
