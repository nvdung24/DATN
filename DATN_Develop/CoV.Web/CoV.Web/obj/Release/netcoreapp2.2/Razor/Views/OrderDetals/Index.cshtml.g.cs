#pragma checksum "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8396f294d2b1879a1e83ee04d045269785e1d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetals_Index), @"mvc.1.0.view", @"/Views/OrderDetals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetals/Index.cshtml", typeof(AspNetCore.Views_OrderDetals_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8396f294d2b1879a1e83ee04d045269785e1d18", @"/Views/OrderDetals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderDetals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TemplateInvoid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(128, 96, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-12\">\n        <h1 style=\"text-align: center\">\n            ");
            EndContext();
            BeginContext(224, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8396f294d2b1879a1e83ee04d045269785e1d187088", async() => {
                BeginContext(275, 19, true);
                WriteLiteral("Danh sách đơn hàng ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(298, 763, true);
            WriteLiteral(@"
        </h1>
    </div>
</div>
<div class=""row"">
    <div class=""col-sm-12 table-responsive"">
        <table id=""ShowClass"" class=""table table-bordered table-hover"">
            <thead class=""thead-light"">
            <tr style=""background-color: darkgrey"">
                <td >Tên khách hàng </td>
                <td >Số điện thoại </td>
                <td >Danh sách sản phẩm </td>
                <td >Số lượng</td>
                <td > Tổng tiền </td>
                <td >Địa chỉ</td>
                <td >Ngày đặt</td>
                <td >Trạng thái</td>
                <td style=""text-align: center"">Chi tiết</td>
                <td >Xuất hóa đơn</td>
                <td style=""text-align: center"">Xóa</td>
            </tr>

            <tbody>
");
            EndContext();
#line 34 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1116, 73, true);
            WriteLiteral("                <tr style=\"text-align: center\">\n                    <td >");
            EndContext();
            BeginContext(1190, 17, false);
#line 37 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.NameCustomer);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 31, true);
            WriteLiteral("</td>\n                    <td >");
            EndContext();
            BeginContext(1239, 16, false);
#line 38 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 31, true);
            WriteLiteral("</td>\n                    <td >");
            EndContext();
            BeginContext(1287, 16, false);
#line 39 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.NameProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 31, true);
            WriteLiteral("</td>\n                    <td >");
            EndContext();
            BeginContext(1335, 18, false);
#line 40 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.NumberProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 34, true);
            WriteLiteral(" SP</td>\n                    <td >");
            EndContext();
            BeginContext(1388, 15, false);
#line 41 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.TotalMoney);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 31, true);
            WriteLiteral("</td>\n                    <td >");
            EndContext();
            BeginContext(1435, 12, false);
#line 42 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1447, 31, true);
            WriteLiteral("</td>\n                    <td >");
            EndContext();
            BeginContext(1479, 15, false);
#line 43 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                    Write(item.CreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 103, true);
            WriteLiteral("</td>\n                    \n                    <td style=\"color: blue\">\n                        <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1597, "\"", 1610, 1);
#line 46 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
WriteAttributeValue("", 1602, item.Id, 1602, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1611, 33, true);
            WriteLiteral(" class=\" btn btn-primary status\">");
            EndContext();
            BeginContext(1645, 23, false);
#line 46 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                                                                         Write(item.StatusOrder.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1668, 113, true);
            WriteLiteral(" </button>\n                    </td>\n                    <td style=\"text-align: center\">\n                        ");
            EndContext();
            BeginContext(1781, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8396f294d2b1879a1e83ee04d045269785e1d1813801", async() => {
                BeginContext(1887, 36, true);
                WriteLiteral("<i class=\"far fa-address-card\"></i> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
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
            BeginContext(1927, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2149, 76, true);
            WriteLiteral("                    </td>\n                    <td >\n                        ");
            EndContext();
            BeginContext(2225, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8396f294d2b1879a1e83ee04d045269785e1d1816735", async() => {
                BeginContext(2326, 82, true);
                WriteLiteral("\n                            <i class=\"fas fa-print\"></i>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
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
            BeginContext(2412, 103, true);
            WriteLiteral("\n                    </td>\n                    <td style=\"text-align: center\">\n                        ");
            EndContext();
            BeginContext(2515, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8396f294d2b1879a1e83ee04d045269785e1d1819641", async() => {
                BeginContext(2621, 105, true);
                WriteLiteral("\n                            <i style=\"color: red\" class=\"fas fa-trash-alt\"></i>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
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
            BeginContext(2730, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 65 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2793, 79, true);
            WriteLiteral("            </tbody>\n            </thead>\n        </table>\n    </div>\n</div>\n\n\n");
            EndContext();
            BeginContext(4973, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4991, 191, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n        /*$(\'.details\').click(function(e) {\n            e.preventDefault();\n            var id = e.target.id;\n\n            $.ajax({\n                url: \'");
                EndContext();
                BeginContext(5183, 40, false);
#line 140 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                 Write(Url.Action("ShowDetails", "OrderDetals"));

#line default
#line hidden
                EndContext();
                BeginContext(5223, 653, true);
                WriteLiteral(@"',
                type: ""GET"",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                data: { 'id': id },
                async: true,
                cache: false,
                success: function(result) {
                    alert(result
                    );
                }
            });
        });*/

        $(document).ready(function() {
            $("".status"").on('click',
                function(e) {
                    e.preventDefault();
                    //id order
                    var id = e.target.id;

                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(5877, 41, false);
#line 162 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\OrderDetals\Index.cshtml"
                         Write(Url.Action("UpdateStatus", "OrderDetals"));

#line default
#line hidden
                EndContext();
                BeginContext(5918, 746, true);
                WriteLiteral(@"',
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        data: { 'id': id },
                        async: true,
                        cache: false,
                        success: function() {
                            $('#' + id).text(""Đang chờ Shipper"");
                            $('#' + id).css(""background-color"", ""red"");
                        }
                    });
                });
            $('#ShowClass').DataTable();
            $('.dataTables_empty').text(""Danh sách rỗng"");
            $('.next').text(""Trang tiếp"");
            $('.previous').text(""Trang trước"");

        });
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
