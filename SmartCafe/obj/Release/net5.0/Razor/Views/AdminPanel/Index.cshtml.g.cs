#pragma checksum "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21583a2c7ca23143a537b62539aa931fe3292531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPanel_Index), @"mvc.1.0.view", @"/Views/AdminPanel/Index.cshtml")]
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
#line 1 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\_ViewImports.cshtml"
using SmartCafe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\_ViewImports.cshtml"
using SmartCafe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21583a2c7ca23143a537b62539aa931fe3292531", @"/Views/AdminPanel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"568aa064e73d545947419b6277d88513bebeabe2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminPanel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartCafe.Models.Drink>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lagoonLogoWhiteTransparent.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /* Stilovi za header */
    body {
        font-family: Montserrat sans-serif;
        margin: 0;
        padding: 0;
        background-image: url('/images/abstractBackground2.png');
        color: black;
    }

    .header {
        background-color: transparent;
        color: white;
        padding: 0px 10px;
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .nav {
        list-style-type: none;
        display: flex;
        align-items: center;
    }

        .nav li {
            margin-right: 35px;
            margin-top: -50px;
            text-transform: uppercase;
            font-size: 14px;
        }

        .nav a {
            color: white;
            text-decoration: none;
            padding-bottom: 3px;
            border-bottom: 2px solid transparent;
            transition: border-bottom-color 0.3s;
        }

            .nav a:hover {
                border-bottom-color: #fff;
 ");
            WriteLiteral(@"           }

    .logo img {
        max-width: 35%;
        margin-right: 0px;
        margin-left: 15px;
        margin-top: -20px;
    }

    /* Stilovi za statistiku */
    .statistics {
        display: flex;
        justify-content: space-between;
        margin-top: 0px;
        margin-left: 20%;
        margin-right: 20%;
    }

    .statistics-item {
        display: flex;
        flex-direction: column;
        align-items: center;
        text-align: center;
        background-color: rgba(0, 0, 0, 0.5); /* Polutransparentna pozadina */
        padding: 20px;
        margin-left: 5%;
        margin-right: 5%;
        border-radius: 5px;
        color: white;
    }

    .statistics-label {
        font-size: 18px;
        font-weight: bold;
        margin-bottom: 10px;
    }

    .statistics-value {
        font-size: 24px;
        font-weight: bold;
        margin-bottom: 10px;
    }

    /* Stilovi za Most Sold Cocktail */
    .most-sold-cocktail {
    ");
            WriteLiteral(@"    margin-left: 5%;
        margin-right: 5%;
        display: flex;
        flex-direction: column;
        align-items: center;
        text-align: center;
        background-color: rgba(0, 0, 0, 0.5); /* Polu transparentna pozadina */
        padding: 20px;
        border-radius: 5px;
        color: white;
    }

        .most-sold-cocktail img {
            max-width: 100%;
            height: 70%;
            margin-bottom: 10px;
        }

    .most-sold-cocktail-name {
        font-size: 24px;
        font-weight: bold;
        margin-bottom: 10px;
    }

    /* Stilovi za carousel */
    .carousel {
        display: grid;
        grid-template-columns: repeat(4, 1fr);
        grid-gap: 20px; /* Povećan razmak između boxova */
        margin: 20px;
    }

    .carousel-item {
        display: flex;
        flex-direction: column;
        align-items: center;
        text-align: center;
        background-color: #f5f5f5;
        padding: 10px;
        border-radiu");
            WriteLiteral(@"s: 5px;
        transition: background-color 0.3s;
        cursor: pointer;
        text-decoration: none; /* Uklonjen underline */
        color: black; /* Postavljena boja teksta na crnu */
    }

        .carousel-item:hover {
            background-color: #e0e0e0;
        }

    .carousel-image {
        max-width: 100%;
        height: auto;
        margin-bottom: 10px;
    }

    /* Stilovi za modalni prozor */
    .modal {
        display: none; /* Inicijalno sakriven */
        position: fixed;
        z-index: 1;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        overflow: auto;
        background-color: rgba(0, 0, 0, 0.4); /* Polu transparentna pozadina */
    }

    .modal-content {
        background-color: #fefefe;
        margin: 15% auto;
        padding: 20px;
        border: 1px solid #888;
        width: 80%;
        max-width: 600px;
        border-radius: 5px;
        position: relative;
    }

    .close {
        ");
            WriteLiteral(@"color: #aaa;
        position: absolute;
        top: 10px;
        right: 20px;
        font-size: 28px;
        font-weight: bold;
        cursor: pointer;
    }

        .close:hover,
        .close:focus {
            color: black;
            text-decoration: none;
            cursor: pointer;
        }

    .modal h1 {
        margin-top: 0;
    }

    .modal form {
        margin-top: 20px;
    }

    .form-group {
        margin-bottom: 20px;
    }

        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .form-group input[type=""text""],
        .form-group input[type=""number""] {
            width: 100%;
            padding: 5px;
            font-size: 16px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .form-group input[type=""submit""] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
   ");
            WriteLiteral(@"         font-size: 16px;
            border-radius: 5px;
            border: none;
            cursor: pointer;
        }

            .form-group input[type=""submit""]:hover {
                background-color: #45a049;
            }

    .logout-button {
        background-color: #4CAF50;
        color: white;
        padding: 10px 20px;
        font-size: 16px;
        border-radius: 5px;
        border: none;
        cursor: pointer;
        transition: background-color 0.3s;
    }

        .logout-button:hover {
            background-color: #45a049;
        }

</style>

<!DOCTYPE html>
<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21583a2c7ca23143a537b62539aa931fe329253112417", async() => {
                WriteLiteral("\r\n    <title>Lagoon\'s Cocktail Bar - Admin Panel</title>\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21583a2c7ca23143a537b62539aa931fe329253113560", async() => {
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <div class=\"logo\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21583a2c7ca23143a537b62539aa931fe329253113893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <ul class=\"navbar-nav\">\r\n            <h1>Admin Panel</h1>\r\n");
#nullable restore
#line 266 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21583a2c7ca23143a537b62539aa931fe329253115491", async() => {
                    WriteLiteral("\r\n                        <button type=\"submit\" class=\"nav-link btn btn-link text-dark\" id=\"logout-button\" style=\"text-transform: uppercase; font-size: 16px; color: black;\">LOG OUT</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 269 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                                                                                      WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 273 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n    </div>\r\n\r\n\r\n\r\n<div class=\"statistics\">\r\n    <div class=\"statistics-item\">\r\n        <span class=\"statistics-label\">Today\'s Profit</span>\r\n        <span class=\"statistics-value\">");
#nullable restore
#line 282 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                  Write(ViewBag.TodayProfit);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</span>\r\n    </div>\r\n    <div class=\"statistics-item\">\r\n        <span class=\"statistics-label\">Total Profit</span>\r\n        <span class=\"statistics-value\">");
#nullable restore
#line 286 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                  Write(ViewBag.TotalProfit);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" $</span>
    </div>
    <div class=""statistics-item"">
        <span class=""statistics-label"">Number of workers</span>
        <span class=""statistics-value"">10</span>
    </div>
    <div class=""statistics-item"">
        <span class=""statistics-label"">Number of customers</span>
        <span class=""statistics-value"">");
#nullable restore
#line 294 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                  Write(ViewBag.NumberOfCustomers);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"most-sold-cocktail\">\r\n    <span class=\"most-sold-cocktail-name\">Most Sold Cocktail: ");
#nullable restore
#line 299 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                                         Write(ViewBag.MostSoldCocktailName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    <div>\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 7859, "\"", 7903, 1);
#nullable restore
#line 301 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 7865, Url.Content("~/images/Kiwi Kiss.jpg"), 7865, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Most Sold Cocktail\" class=\"most-sold-cocktail-image\" />\r\n    </div>\r\n</div>\r\n\r\n\r\n    <div class=\"carousel\">\r\n");
#nullable restore
#line 307 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
         foreach (var drink in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"carousel-item\">\r\n                <h3>");
#nullable restore
#line 310 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
               Write(drink.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p>Price: ");
#nullable restore
#line 311 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                     Write(drink.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 8212, "\"", 8265, 1);
#nullable restore
#line 312 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 8218, Url.Content("~/images/" + drink.name + ".jpg"), 8218, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8266, "\"", 8283, 1);
#nullable restore
#line 312 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 8272, drink.name, 8272, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"carousel-image rounded\" />\r\n\r\n                <!-- Modalni prozor za uređivanje -->\r\n                <div");
                BeginWriteAttribute("id", " id=\"", 8397, "\"", 8417, 2);
                WriteAttributeValue("", 8402, "modal-", 8402, 6, true);
#nullable restore
#line 315 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 8408, drink.id, 8408, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"modal\">\r\n                    <div class=\"modal-content\">\r\n                        <span class=\"close\">&times;</span>\r\n                        <h1>Edit Drink</h1>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21583a2c7ca23143a537b62539aa931fe329253123864", async() => {
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"name\">Name:</label>\r\n                                <input type=\"text\" id=\"name\" name=\"name\"");
                    BeginWriteAttribute("value", " value=\"", 8869, "\"", 8888, 1);
#nullable restore
#line 322 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 8877, drink.name, 8877, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"price\">Price:</label>\r\n                                <input type=\"number\" id=\"price\" name=\"price\"");
                    BeginWriteAttribute("value", " value=\"", 9127, "\"", 9147, 1);
#nullable restore
#line 326 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
WriteAttributeValue("", 9135, drink.price, 9135, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <input type=\"submit\" value=\"Save\" />\r\n                            </div>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 319 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
                                                                WriteLiteral(drink.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 335 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\AdminPanel\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <script>
        // JavaScript kod za modalni prozor
        var modalItems = document.getElementsByClassName(""carousel-item"");
        var modals = document.getElementsByClassName(""modal"");
        var closeButtons = document.getElementsByClassName(""close"");

        // Prikazuje modalni prozor za određenu stavku
        function showModal(itemIndex) {
            modals[itemIndex].style.display = ""block"";
        }

        // Sakriva modalni prozor za određenu stavku
        function hideModal(itemIndex) {
            modals[itemIndex].style.display = ""none"";
        }

        // Postavlja događaje za prikazivanje/skrivanje modalnih prozora
        for (var i = 0; i < modalItems.length; i++) {
            (function (index) {
                modalItems[index].addEventListener(""click"", function () {
                    showModal(index);
                });

                closeButtons[index].addEventListener(""click"", function () {
                    hideModal(inde");
                WriteLiteral("x);\r\n                });\r\n            })(i);\r\n        }\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartCafe.Models.Drink>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591