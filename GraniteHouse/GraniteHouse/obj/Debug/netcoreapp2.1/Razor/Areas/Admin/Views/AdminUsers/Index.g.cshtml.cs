#pragma checksum "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb3597a075c99a9a43f51d2eaa199f3c371b4e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminUsers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminUsers_Index))]
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
#line 1 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb3597a075c99a9a43f51d2eaa199f3c371b4e1", @"/Areas/Admin/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraniteHouse.Models.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 173, true);
            WriteLiteral("\r\n\r\n<br /><br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Admin Users list</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(230, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e6ed1c03c342f1bd1a319c6794753b", async() => {
                BeginContext(303, 48, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Admin User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 138, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>");
            EndContext();
            BeginContext(494, 32, false);
#line 20 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(526, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(550, 33, false);
#line 21 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(583, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(607, 39, false);
#line 22 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(646, 78, true);
            WriteLiteral("</th>\r\n            <th>Disabled</th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 27 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(773, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(812, 31, false);
#line 30 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(843, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(871, 32, false);
#line 31 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(903, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(931, 38, false);
#line 32 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
               Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(969, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 34 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                     if(item.LockoutEnd != null && item.LockoutEnd > DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1105, 49, true);
            WriteLiteral("                        <label>Disabled</label>\r\n");
            EndContext();
#line 37 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1177, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 40 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                     if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1330, 64, true);
            WriteLiteral("                        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1394, "\"", 1429, 1);
#line 42 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1401, Url.Action("Edit/"+item.Id), 1401, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1430, 153, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </a>\r\n                        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1620, 1);
#line 45 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1590, Url.Action("Delete/"+item.Id), 1590, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1621, 95, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n                        </a>\r\n");
            EndContext();
#line 48 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1739, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "F:\Visual Studio Repositories\GraniteHouse\GraniteHouse\Areas\Admin\Views\AdminUsers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1794, 32, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraniteHouse.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
