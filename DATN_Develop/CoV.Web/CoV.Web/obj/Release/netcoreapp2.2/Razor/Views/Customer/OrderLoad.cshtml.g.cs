#pragma checksum "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Customer\OrderLoad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "191dc6ff558c783248b4f5ae86d5700298d90b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_OrderLoad), @"mvc.1.0.view", @"/Views/Customer/OrderLoad.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/OrderLoad.cshtml", typeof(AspNetCore.Views_Customer_OrderLoad))]
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
#line 1 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Customer\OrderLoad.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"191dc6ff558c783248b4f5ae86d5700298d90b3f", @"/Views/Customer/OrderLoad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_OrderLoad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/0d293621-7c15-4c0e-a820-6198009f6015_5d828e8d6f24eb1eb5148f5c.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Customer\OrderLoad.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_LayoutOrderLoading";
    var list = (List<OrderViewModel>)ViewBag.list;

#line default
#line hidden
            BeginContext(216, 1084, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <!-- The time line -->
        <div class=""timeline"">
            <!-- timeline time label -->
            <!-- /.timeline-label -->
            <!-- timeline item -->
            <div>
                <i class=""fas fa-cart-plus""></i>
                <div class=""timeline-item"">
                    <h3 class=""timeline-header"">
                        <a href=""#"">Chờ thanh toán</a>
                    </h3>
                    <div class=""timeline-body"">
                        <section class=""product-ss"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""owl-carousel owl-theme product_slide"" id=""product_slide_men"">
                                        <div class=""item"">
                                            <div class=""item-product"">
                                              
                                                    <div class=""img-ite");
            WriteLiteral("m\">\n                                                        ");
            EndContext();
            BeginContext(1300, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191dc6ff558c783248b4f5ae86d5700298d90b3f7008", async() => {
                BeginContext(1352, 61, true);
                WriteLiteral("\n                                                            ");
                EndContext();
                BeginContext(1413, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "191dc6ff558c783248b4f5ae86d5700298d90b3f7447", async() => {
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
                EndContext();
                BeginContext(1506, 57, true);
                WriteLiteral("\n                                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1567, 2396, true);
            WriteLiteral(@"
                                                    </div>
                                                    <h3 class=""name-product"">
                                                        <a >
                                                           
                                                        </a>
                                                    </h3>
                                                    <div class=""price-product"">
                                                        <span ></span>
                                                    </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                            
                        </section>
                    </div>
                </div>
            </div>
            <!-- END timeline item -->
            <!-- timeline item -->
            <");
            WriteLiteral(@"div>
                <i class=""fas fa-truck bg-blue""></i>
                <div class=""timeline-item"">
                    <h3 class=""timeline-header"">
                        <a href=""#"">Chờ lấy hàng</a>
                    </h3>
                    <div class=""timeline-body"">
                        a
                    </div>
                </div>
            </div>
            <!-- END timeline item -->

            <!-- timeline item -->
            <div>
                <i class=""fas fa-shipping-fast bg-blue""></i>

                <div class=""timeline-item"">
                    <h3 class=""timeline-header"">
                        <a href=""#"">Đang giao</a>
                    </h3>
                    <div class=""timeline-body"">
                        a
                    </div>
                </div>
            </div>
            <!-- END timeline item -->

            <!-- timeline item -->
            <div>
                <i class=""fab fa-usps bg-purple""></i>
                <div class=""timeline-");
            WriteLiteral(@"item"">
                    <h3 class=""timeline-header"">
                        <a href=""#"">Đã giao</a>
                    </h3>
                    <div class=""timeline-body"">
                        a
                    </div>
                </div>
            </div>
            <!-- END timeline item -->
            <!-- timeline item -->

");
            EndContext();
            BeginContext(4785, 255, true);
            WriteLiteral("            <!-- END timeline item -->\n            <!-- timeline item -->\n\n            <!-- END timeline item -->\n            <div>\n                <i class=\"fas fa-clock bg-gray\"></i>\n            </div>\n        </div>\n    </div>\n    <!-- /.col -->\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
