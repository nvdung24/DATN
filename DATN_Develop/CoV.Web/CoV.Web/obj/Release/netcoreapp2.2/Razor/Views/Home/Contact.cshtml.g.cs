#pragma checksum "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0cb5cd385705326894032fa87fa48522863221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0cb5cd385705326894032fa87fa48522863221", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoV.Service.DataModel.ContactViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Lời nhắn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_FrontEndLayout";
    var customer = (CustomerViewModel) ViewBag.customer;

#line default
#line hidden
            BeginContext(247, 666, true);
            WriteLiteral(@"
<style>
    .select-style {
        border: 1px solid #ccc;
        width: 120px;
        border-radius: 3px;
        overflow: hidden;
        /*background: #fafafa url(""/Images/Bitis_Hunter.jpg"") no-repeat 90% 50%;*/
    }

    .select-style select {
        padding: 5px 8px;
        width: 130%;
        border: none;
        box-shadow: none;
        background: transparent;
        background-image: none;
        -webkit-appearance: none;
    }

    .select-style select:focus { outline: none; }
</style>

<section class=""breadcrumb"">
    <div class=""container p-0"">
        <div class=""col-md-12"">
            <ul>
                <li>
                    ");
            EndContext();
            BeginContext(913, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c0cb5cd385705326894032fa87fa485228632217843", async() => {
                BeginContext(956, 55, true);
                WriteLiteral("\n                        Trang chủ\n                    ");
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
            BeginContext(1015, 64, true);
            WriteLiteral("\n                </li>\n                <li>\n                    ");
            EndContext();
            BeginContext(1079, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c0cb5cd385705326894032fa87fa485228632219537", async() => {
                BeginContext(1122, 63, true);
                WriteLiteral("\n                        Liên hệ chúng tôi\n                    ");
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
            BeginContext(1189, 482, true);
            WriteLiteral(@"
                </li>
                <li>
                    SHOESPOTLIGHT
                </li>
            </ul>
        </div>
    </div>
</section>

<section class=""content-contact mt-2"" id=""form_book"">
    <div class=""container p-0"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""form-contact"">
                    <h2 class=""title"">
                        Gửi tin nhắn cho chúng tôi
                    </h2>
                    ");
            EndContext();
            BeginContext(1671, 1380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c0cb5cd385705326894032fa87fa4852286322111672", async() => {
                BeginContext(1748, 141, true);
                WriteLiteral("\n                        <div class=\"form-group\">\n                            <input class=\"form-control\" type=\"text\" placeholder=\"Họ và tên\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1889, "\"", 1937, 2);
#line 64 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
WriteAttributeValue("", 1898, customer.FirstName, 1898, 19, false);

#line default
#line hidden
#line 64 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
WriteAttributeValue("  ", 1917, customer.LastName, 1919, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1938, 169, true);
                WriteLiteral(">\n                        </div>\n                        <div class=\"form-group\">\n                            <input class=\"form-control\" type=\"text\" placeholder=\"Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2107, "\"", 2130, 1);
#line 67 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
WriteAttributeValue("", 2115, customer.Email, 2115, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2131, 180, true);
                WriteLiteral(" />\n                        </div>\n\n                        <div class=\"form-group\">\n                            <input class=\"form-control\" type=\"text\" placeholder=\"Số điện thoại\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2311, "\"", 2340, 1);
#line 71 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
WriteAttributeValue("", 2319, customer.PhoneNumber, 2319, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2341, 35, true);
                WriteLiteral(" />\n                        </div>\n");
                EndContext();
                BeginContext(2570, 77, true);
                WriteLiteral("                        <div class=\"form-group\">\n                            ");
                EndContext();
                BeginContext(2647, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c0cb5cd385705326894032fa87fa4852286322114397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 77 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Information);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2736, 308, true);
                WriteLiteral(@"
                        </div>
                        <div class=""form-group text-center"">
                            <button type=""submit"" id=""btn-open"" class=""btn-blue"">
                                Gửi liên hệ
                            </button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3051, 5140, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""area-contact "">
                    <h2 class=""title"">
                        HỆ THỐNG SHOESPOTLIGHT
                    </h2>
                    <div class=""sub-title"">
                        Nếu bạn có câu hỏi gì hãy lên hệ với chúng tôi, mỗi câu hỏi của các bạn giúp chúng tôi hoàn thiện hơn
                    </div>
                    <div class=""list-area"">
                        <div class=""item"">
                            <div class=""icon"">
                                <i class=""fas fa-map-marker-alt""></i>
                            </div>
                            <div class=""txt-item"">
                                <h3 class=""title-item"">
                                    ADDRESS:
                                </h3>
                                <div class=""sub-title"">
                                    Đại học Công nghiệp - Bắc Từ Liêm - Hà Nội
                             ");
            WriteLiteral(@"   </div>
                            </div>
                        </div>

                        <div class=""item"">
                            <div class=""icon"">
                                <i class=""fas fa-envelope""></i>
                            </div>
                            <div class=""txt-item"">
                                <h3 class=""title-item"">
                                    EMAIL:
                                </h3>
                                <div class=""sub-title"">
                                    Haui@gmail.com
                                </div>
                            </div>
                        </div>

                        <div class=""item"">
                            <div class=""icon"">
                                <i class=""fas fa-mobile""></i>
                            </div>
                            <div class=""txt-item"">
                                <h3 class=""title-item"">
                                    PHONE
                     ");
            WriteLiteral(@"           </h3>
                                <div class=""sub-title"">
                                    +0123 456 789
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""social"">
                        <ul>
                            <li>
                                <a href=""https://www.facebook.com/chuonghvc2901"">
                                    <i class=""fab fa-facebook-f""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.facebook.com/chuonghvc2901"">
                                    <i class=""fab fa-instagram""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""https://www.facebook.com/chuonghvc2901"">
                                    <i class=""fab fa-twitter""></i>
      ");
            WriteLiteral(@"                          </a>
                            </li>
                            <li>
                                <a href=""https://www.facebook.com/chuonghvc2901"">
                                    <i class=""fab fa-linkedin-in""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div class=""map"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h2 class=""title"">
                        Bản đồ
                    </h2>
                    <div class=""local-map"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d59587.977854466706!2d105.8019443916433!3d21.022736016347025!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135ab9bd9861ca1%3A0xe7887f7b72ca17a9!2zSMOgIE7hu5lpLCBIb8OgbiBLaeG6v20sIEjDoCBO4buZaSwgVmnhu4d0IE5hbQ!5e0!3m2!1svi!2s!4v1557736661679!5m2!1svi!2s"" ");
            WriteLiteral(@"width=""100%"" height=""400"" frameborder=""0"" style=""border: 0"" allowfullscreen></iframe>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<div class=""nen-mo""></div>
<div class=""hop-thoai"">
    <i style=""font-size: 120px; color: #00bfa5; padding-left: 35%; margin-top: 5%; margin-bottom: 5%;"" class=""far fa-check-circle ""></i>
    <h3 style=""color: white;"">Sản phẩm được thêm vào giỏ hàng</h3>
</div>

<div class=""nen-mo-login""></div>
<div class=""hop-thoai-login"">
    <i style=""font-size: 120px; color: #00bfa5; padding-left: 32%; margin-top: 7%; margin-bottom: 5%; color: red"" class=""fab fa-amazon-pay""></i>
    <h3 style=""color: white;"">Vui lòng đăng nhập để mua hàng </h3>
</div>

<div class=""nen-mo-max""></div>
<div class=""hop-thoai-max"">
    <i style=""font-size: 80px; color: #00bfa5; padding-left: 40%; margin-top: 7%; margin-bottom: 5%; color: red"" class=""fas fa-exclamation-triangle""></i>
    <h3 style=""color: white;"">Hiệp tai số lượng không đủ , vui lòng chọn");
            WriteLiteral(" lại </h3>\n</div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8209, 42, true);
                WriteLiteral("\n    <script>\n        var SessionEmail = \'");
                EndContext();
                BeginContext(8252, 64, false);
#line 203 "C:\Users\fpt\Downloads\SHoesStoreTuli-Develop\SHoesStoreTuli-Develop\CoV.Web\CoV.Web\Views\Home\Contact.cshtml"
                       Write(HttpContextAccessor.HttpContext.Session.GetString("SessionName"));

#line default
#line hidden
                EndContext();
                BeginContext(8316, 641, true);
                WriteLiteral(@"';
        $(document).ready(function() {
            $('.btn-open').on('click',
                (function(event) {
                    event.preventDefault();
                            $('.hop-thoai-max').addClass('hien-ra-max');
                            $('.nen-mo-max').addClass('hien-ra-max');
                            setTimeout(function() {
                                    $('.hop-thoai-max').removeClass('hien-ra-max');
                                    $('.nen-mo-max').removeClass('hien-ra-max');
                                },
                                1500);
                }));
        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoV.Service.DataModel.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591