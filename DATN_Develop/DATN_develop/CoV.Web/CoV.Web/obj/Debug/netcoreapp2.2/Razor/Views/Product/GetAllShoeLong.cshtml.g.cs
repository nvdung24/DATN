#pragma checksum "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f768253db1bd0e52ccecc409fb942cd57d2a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetAllShoeLong), @"mvc.1.0.view", @"/Views/Product/GetAllShoeLong.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetAllShoeLong.cshtml", typeof(AspNetCore.Views_Product_GetAllShoeLong))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\_ViewImports.cshtml"
using CoV.Web;

#line default
#line hidden
#line 2 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\_ViewImports.cshtml"
using CoV.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#line 1 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f768253db1bd0e52ccecc409fb942cd57d2a8c", @"/Views/Product/GetAllShoeLong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetAllShoeLong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_FrontEndLayout";
    var product = (List<ProductViewModel>) ViewBag.product;

#line default
#line hidden
            BeginContext(163, 158, true);
            WriteLiteral("\r\n<section class=\"breadcrumb\">\r\n    <div class=\"container p-0\">\r\n        <div class=\"col-md-12\">\r\n            <ul>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(321, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c6964", async() => {
                BeginContext(364, 57, true);
                WriteLiteral("\r\n                        Trang chủ\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(425, 466, true);
            WriteLiteral(@"
                </li>
                <li>
                    Giầy cao cổ
                </li>
            </ul>
        </div>
    </div>
</section>

<section class=""product-ss product-page"">
<div class=""container p-0"">
<div class=""row align-items-center"">
    <div class=""col-md-9"">
        <h2 class=""name-cate mb-0"">
            Giành cho nam

        </h2>
    </div>
    <div class=""col-md-3"">
        <div class='sort-by'>
            ");
            EndContext();
            BeginContext(891, 791, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c9073", async() => {
                BeginContext(908, 115, true);
                WriteLiteral("\r\n                <div class=\'select\'>\r\n                    <select class=\'form-control\'>\r\n                        ");
                EndContext();
                BeginContext(1023, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c9578", async() => {
                    BeginContext(1040, 70, true);
                    WriteLiteral("\r\n                            Giá thấp trước\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1119, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1145, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c11136", async() => {
                    BeginContext(1162, 69, true);
                    WriteLiteral("\r\n                            Giá Cao trước\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1240, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1266, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c12694", async() => {
                    BeginContext(1283, 62, true);
                    WriteLiteral("\r\n                            Từ A-Z\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1354, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1380, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c14245", async() => {
                    BeginContext(1397, 62, true);
                    WriteLiteral("\r\n                            Từ Z-A\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1468, 207, true);
                WriteLiteral("\r\n                    </select>\r\n                    <span class=\'icon-select\'>\r\n                        <i class=\'fas fa-chevron-down\'></i>\r\n                    </span>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1682, 3337, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""row product_slide"">
<div class=""col-md-3"">
    <div class='side-bar-product'>
        <div class='item-bar'>
            <h3 class='title-side-ba'>
                Giành cho nam
            </h3>
            <ul class=""list-inline"">
                <li>
                    <a href='#'>
                        Thời trang
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='#'>
                        Thời trang nam
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='#'>
                        Thời trang nữ
                        <span class='count-cate'>
                            (9)
                        </span>
 ");
            WriteLiteral(@"                   </a>
                </li>
                <li>
                    <a href='#'>
                        Phụ kiện nam
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='product-list.html'>
                        Phụ kiện nữ
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
            </ul>
        </div>

        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Size
            </h3>
            <ul class=""list-tb"">
                <li>
                    <a href='#'>
                        34
                    </a>
                </li>
                <li>
                    <a href='#'>
                        35
                    </a>
         ");
            WriteLiteral(@"       </li>
                <li>
                    <a href='#'>
                        36
                    </a>
                </li>
                <li>
                    <a href='#'>
                        37
                    </a>
                </li>
                <li>
                    <a href='#'>
                        38
                    </a>
                </li>
                <li>
                    <a href='#'>
                        39
                    </a>
                </li>
                <li>
                    <a href='#'>
                        40
                    </a>
                </li>
                <li>
                    <a href='#'>
                        41
                    </a>
                </li>
                <li>
                    <a href='#'>
                        42
                    </a>
                </li>
                <li>
                    <a href='#'>
                       ");
            WriteLiteral(@" 42
                    </a>
                </li>
            </ul>
        </div>

        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Màu sắc
            </h3>
            <ul class=""list-cl"">
                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5019, "\"", 5027, 0);
            EndWriteAttribute();
            BeginContext(5028, 174, true);
            WriteLiteral(" style=\"background-color: #ff6600;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5202, "\"", 5210, 0);
            EndWriteAttribute();
            BeginContext(5211, 171, true);
            WriteLiteral(" style=\"background-color: #000;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5382, "\"", 5390, 0);
            EndWriteAttribute();
            BeginContext(5391, 174, true);
            WriteLiteral(" style=\"background-color: #cc0000;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5565, "\"", 5573, 0);
            EndWriteAttribute();
            BeginContext(5574, 172, true);
            WriteLiteral(" style=\"background-color: #ff0000;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5746, "\"", 5754, 0);
            EndWriteAttribute();
            BeginContext(5755, 174, true);
            WriteLiteral(" style=\"background-color: #ffff00;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5929, "\"", 5937, 0);
            EndWriteAttribute();
            BeginContext(5938, 171, true);
            WriteLiteral(" style=\"background-color: #fff;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6109, "\"", 6117, 0);
            EndWriteAttribute();
            BeginContext(6118, 170, true);
            WriteLiteral(" style=\"background-color: red;\">\r\n                    <a href=\'#\'>\r\n                        &nbsp;\r\n                    </a>\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6288, "\"", 6296, 0);
            EndWriteAttribute();
            BeginContext(6297, 1369, true);
            WriteLiteral(@" style=""background-color: blue;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>
            </ul>
        </div>
        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Khoảng giá
            </h3>
            <ul class=""list-inline"">
                <li>
                    <a href='#'>
                        100.000 đ - 500.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        500.000 đ - 1.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        1.000.000 đ - 3.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        3.000.000 đ - 5.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
   ");
            WriteLiteral(@"                     5.000.000 đ - 7.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        > 7.000.000 đ
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""col-md-9 p-0"">
<div class=""row"">
");
            EndContext();
#line 265 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
 foreach (var item in product)
{

#line default
#line hidden
            BeginContext(7701, 120, true);
            WriteLiteral("    <div class=\"col-md-4 p-0\">\r\n        <div class=\"item-product\">\r\n            <div class=\"img-item\">\r\n                ");
            EndContext();
            BeginContext(7821, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c25449", async() => {
                BeginContext(7898, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(7920, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c25851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7930, "~/Images/", 7930, 9, true);
#line 271 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
AddHtmlAttributeValue("", 7939, item.AvatarDetails, 7939, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7967, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 270 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7989, 702, true);
            WriteLiteral(@"
            </div>
            <div class=""box-size"">
                <div class=""count-size"">
                    +7 size
                </div>
                <div class=""list-size"">
                    <span>35</span>
                    <span>36</span>
                    <span>47</span>
                    <span>38</span>
                    <span>39</span>
                    <span>40</span>
                    <span>41</span>
                    <span>42</span>
                    <span>43</span>
                    <span>44</span>
                    <span>45</span>
                </div>
            </div>

            <h3 class=""name-product"">
                ");
            EndContext();
            BeginContext(8691, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c30604", async() => {
                BeginContext(8768, 25, true);
                WriteLiteral("\r\n                    <b>");
                EndContext();
                BeginContext(8794, 9, false);
#line 295 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
                  Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(8803, 22, true);
                WriteLiteral("</b>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 294 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8829, 84, true);
            WriteLiteral("\r\n            </h3>\r\n            <div class=\"price-product\">\r\n                <span>");
            EndContext();
            BeginContext(8914, 10, false);
#line 299 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
                 Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(8924, 54, true);
            WriteLiteral(" đ</span>\r\n                <del>\r\n                    ");
            EndContext();
            BeginContext(8979, 13, false);
#line 301 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
               Write(item.PriceNew);

#line default
#line hidden
            EndContext();
            BeginContext(8992, 103, true);
            WriteLiteral(" đ\r\n                </del>\r\n            </div>\r\n            <div class=\"add-to-cart\">\r\n                ");
            EndContext();
            BeginContext(9095, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f768253db1bd0e52ccecc409fb942cd57d2a8c34663", async() => {
                BeginContext(9173, 48, true);
                WriteLiteral("\r\n                    Mua hàng\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 305 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9225, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 311 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Product\GetAllShoeLong.cshtml"
}

#line default
#line hidden
            BeginContext(9278, 899, true);
            WriteLiteral(@"


<div class=""col-md-12"">
    <div class='pagination pt-1'>
        <ul>
            <li>
                <a href='#'>
                    <i class='fas fa-arrow-left'></i>
                </a>
            </li>
            <li class='active'>
                <a href='#'>1</a>
            </li>
            <li>
                <a href='#'>2</a>
            </li>
            <li>
                <a href='#'>3</a>
            </li>
            <li>
                <a href='#'>...</a>
            </li>
            <li>
                <a href='#'>4</a>
            </li>
            <li>
                <a href='#'>5</a>
            </li>
            <li>
                <a href='#'>
                    <i class='fas fa-arrow-right'></i>
                </a>
            </li>
        </ul>
    </div>
</div>
</div>
</div>


</div>
</div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
