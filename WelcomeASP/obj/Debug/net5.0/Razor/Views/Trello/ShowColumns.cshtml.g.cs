#pragma checksum "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130f7ce8bf8a8867f33b40e05359c7ab703377f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trello_ShowColumns), @"mvc.1.0.view", @"/Views/Trello/ShowColumns.cshtml")]
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
#line 1 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\_ViewImports.cshtml"
using WelcomeASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\_ViewImports.cshtml"
using WelcomeASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130f7ce8bf8a8867f33b40e05359c7ab703377f8", @"/Views/Trello/ShowColumns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd40d826b2ff760c7ca86df5796e570baca58497", @"/Views/_ViewImports.cshtml")]
    public class Views_Trello_ShowColumns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WelcomeASP.Data.Entities.trello.Column>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Asentus/Parallax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateColumn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
  
    //ViewData["Title"] = "Trello" + Model.Title;
    //ViewData["ParallaxTitle"] = "Trello" + Model.Title;
    //ViewData["ParallaxText"] = "Trello e.t.c";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "130f7ce8bf8a8867f33b40e05359c7ab703377f84732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"Bodydiv\">\r\n    <div class=\"Onediv\">\r\n");
#nullable restore
#line 12 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
         foreach (var column in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <a style=\"color:white;\">\r\n                    <!-- asp-controller=\"Trello\" asp-route-id=\"");
#nullable restore
#line 16 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                                                          Write(column.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"-->\r\n                    <header style=\"margin-bottom: 1rem; font-size: 22px; color:white\">");
#nullable restore
#line 17 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                                                                                 Write(Html.DisplayFor(Model => column.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</header>\r\n                </a>\r\n                <ul style=\"list-style-type: none;\">\r\n");
#nullable restore
#line 20 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                     foreach (var card in column.Card)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n\r\n                            ");
#nullable restore
#line 24 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                       Write(Html.DisplayFor(Model => card.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 26 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
                <div>

                    <button id=""myBtn"" class=""btn btn-primary"">Add card</button>

                    <!-- Модальный -->
                    <div id=""myModal"" class=""modal"">

                        <!-- Модальное содержание -->
                        <div class=""modal-content"">
                            <span class=""close"">&times;</span>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "130f7ce8bf8a8867f33b40e05359c7ab703377f88475", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"BoardId\"");
                BeginWriteAttribute("value", " value=\"", 1478, "\"", 1502, 1);
#nullable restore
#line 39 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
WriteAttributeValue("", 1486, ViewBag.BoardId, 1486, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"ColumnId\"");
                BeginWriteAttribute("value", " value=\"", 1576, "\"", 1594, 1);
#nullable restore
#line 40 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
WriteAttributeValue("", 1584, column.Id, 1584, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <div class=""form-group"">
                                    <label class=""control-label"">Заголовок карточки</label>
                                    <input name=""Title"" class=""form-control"" />
                                </div>
                                <div class=""form-group"">
                                    <label class=""control-label"">Тело карточки</label>
                                    <input name=""Body"" class=""form-control"" />
                                </div>
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                    </div>

                    <style>
                        .modal {
                            display: none; 
                            position: fixed; 
                            z-index: 1; 
                            left: 0;
                            top: 0;
                            width: 100%; 
                            height: 100%; 
                            overflow: auto; 
                            background-color: rgb(0,0,0); 
                            background-color: rgba(0,0,0,0.4); 
                        }

                        .form-control{
                            border: 1px solid black;
                        }

                        .modal-content {
                            color: black;
                            background-color: #fefefe;
                            margin: 15% auto; 
                            padding: 20px;
                            border: 1px sol");
            WriteLiteral(@"id #888;
                            width: 80%; 
                        }

                        .close {
                            color: #808080;
                            float: right;
                            font-size: 28px;
                            font-weight: bold;
                        }

                            .close:hover,
                            .close:focus {
                                color: black;
                                text-decoration: none;
                                cursor: pointer;
                            }
                    </style>

                    <script>
                        var modal = document.getElementById(""myModal"");

                        var btn = document.getElementById(""myBtn"");

                        var span = document.getElementsByClassName(""close"")[0];

                        btn.onclick = function () {
                            modal.style.display = ""block"";
                       ");
            WriteLiteral(@" }

                        span.onclick = function () {
                            modal.style.display = ""none"";
                        }

                        window.onclick = function (event) {
                            if (event.target == modal) {
                                modal.style.display = ""none"";
                            }
                        }
                    </script>
                </div>
            </div>
");
#nullable restore
#line 122 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"Twodiv\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "130f7ce8bf8a8867f33b40e05359c7ab703377f814510", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"BoardId\"");
                BeginWriteAttribute("value", " value=\"", 5064, "\"", 5088, 1);
#nullable restore
#line 128 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
WriteAttributeValue("", 5072, ViewBag.BoardId, 5072, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <label class=""control-label"" style=""text-align:center; font-size: 32px;""> Заголовок колонка </label>
                <input name=""Title"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <!--\r\n    <div >\r\n        <form asp-action=\"CreateCadr\">\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"ColumnId\" value=\"");
#nullable restore
#line 142 "D:\ПРОГРАММИРОВАНИЕ\Программирование\ASP .NET\WelcomeASP\WelcomeASP\Views\Trello\ShowColumns.cshtml"
                                                       Write(ViewBag.ColumnId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" />
                <label class=""control-label""> Заголовок колонка </label>
                <input name=""Title"" class=""form-control"" />
                <input name=""Body"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
    -->
</div>



<style>
    .Bodydiv {
        background: linear-gradient(to top left, azure, silver);
        padding-top: 4rem;
        padding-bottom: 4rem;
    }

    .Onediv {
        padding-top: 2rem;
        padding-bottom: 2rem;
        padding-left: 3rem;
        padding-right: 3rem;
        font-size: 19px;
        font-family: Arial, Helvetica, sans-serif;
        margin-left: 4rem;
        margin-right: 4rem;
        background: linear-gradient(to top left, PowderBlue, silver);
        border-radius: 5px;
        color: white;
        border: 4px solid rgba(0,0,0,0.5);
        list-style-");
            WriteLiteral(@"type: armenian;
    }

    .Twodiv {
        background: linear-gradient(to top left, silver, PowderBlue);
        margin-top: 2rem;
        padding-top: 3rem;
        padding-bottom: 3rem;
        padding-left: 3rem;
        padding-right: 3rem;
        margin-left: 4rem;
        margin-right: 4rem;
        border-radius: 6px;
        color: white;
        border: 2px solid rgba(0,0,0,0.3);
        list-style-type: none;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WelcomeASP.Data.Entities.trello.Column>> Html { get; private set; }
    }
}
#pragma warning restore 1591