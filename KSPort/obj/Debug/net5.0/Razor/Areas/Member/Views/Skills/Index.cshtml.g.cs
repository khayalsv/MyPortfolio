#pragma checksum "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224cf15f8d20b1c18150f71e73a6c45d6d966e3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Skills_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Skills/Index.cshtml")]
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
#line 2 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224cf15f8d20b1c18150f71e73a6c45d6d966e3d", @"/Areas/Member/Views/Skills/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bdb6016d59e9006192554863393d2bd52acc67", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Skills_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skills>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Title</th>
        <th>Text</th>
        <th>Name 1</th>
        <th>Ability 1</th>
        <th>Name 2</th>
        <th>Ability 2</th>
        <th>Name 3</th>
        <th>Ability 3</th>
        <th>Image</th>
        <th>Delete</th>
        <th>Edit</th>
    </tr>

");
#nullable restore
#line 26 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 29 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Name1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Ability1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Name2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 35 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Ability2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 36 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Name3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 37 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
   Write(item.Ability3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "224cf15f8d20b1c18150f71e73a6c45d6d966e3d6905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 861, "~/myimg/", 861, 8, true);
#nullable restore
#line 39 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
AddHtmlAttributeValue("", 869, item.ImageUrl, 869, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 908, "\"", 945, 2);
            WriteAttributeValue("", 915, "/Member/Skills/Delete/", 915, 22, true);
#nullable restore
#line 41 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
WriteAttributeValue("", 937, item.Id, 937, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Are you delete?\')\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1041, "\"", 1076, 2);
            WriteAttributeValue("", 1048, "/Member/Skills/Edit/", 1048, 20, true);
#nullable restore
#line 42 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
WriteAttributeValue("", 1068, item.Id, 1068, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a></td>\r\n</tr>\r\n");
#nullable restore
#line 44 "C:\Users\selim\Desktop\MyPortfolio\KSPort\Areas\Member\Views\Skills\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Member/Skills/Create/\" class=\"btn btn-primary\">Create new item</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skills>> Html { get; private set; }
    }
}
#pragma warning restore 1591
