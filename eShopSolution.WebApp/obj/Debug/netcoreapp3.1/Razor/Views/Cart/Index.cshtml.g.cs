#pragma checksum "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fc0a2044ba4f99917f7f777ad129acd81c01c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Controllers.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fc0a2044ba4f99917f7f777ad129acd81c01c9", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fc0a2044ba4f99917f7f777ad129acd81c01c96588", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        var cartController = new CartController();\r\n        cartController.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
                    <li>Giỏ hàng</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->

<section class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""cart"">

            <div class=""page-content page-order"">
                <div class=""page-title"">
                    <h2>Giỏ hàng</h2>
                </div>

                <div class=""order-detail-content"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered cart_summary"" id=""tbl_cart"">
                            <thead>
                                <");
            WriteLiteral(@"tr>
                                    <th class=""cart_product"">Hình ảnh</th>
                                    <th>Tên</th>
                                    <th class=""text-center"">Số lượng trong kho</th>
                                    <th>Đơn giá</th>
                                    <th>Số lượng mua</th>
                                    <th>Tổng cộng</th>
                                    <th class=""action""><i class=""fa fa-trash""></i></th>
                                </tr>
                            </thead>
                            <tbody id=""cart_body"">
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td colspan=""2""></td>
                                    <td colspan=""4""><strong>Tổng giá đơn hàng</strong></td>
                                    <td colspan=""2""><strong><span id=""lbl_total""></span> <span>&#8363;</span> </strong></td>
                              ");
            WriteLiteral(@"  </tr>
                                <tr id=""discount_amount_row"">
                                    <td colspan=""2"" ></td>
                                    <td colspan=""4""><strong>Số tiền giảm</strong></td>
                                    <td colspan=""2""><strong><span id=""lbl_discount_amount""></span> <span>&#8363;</span> </strong></td>
                                </tr>
                                <tr id=""total_discounted_row"">
                                    <td colspan=""2"" ></td>
                                    <td colspan=""4""><strong>Tổng giá đơn hàng đã giảm</strong></td>
                                    <td colspan=""2""><strong><span id=""lbl_total_discounted""></span> <span>&#8363;</span> </strong></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
");
#nullable restore
#line 83 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-group"" id=""coupon-input"" style=""width:300px"">
                                <label>Bạn có coupon giảm giá?</label>
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control"" id=""coupon-input-control"" placeholder=""Nhập mã Coupon"">
                                    <span class=""input-group-btn"">
                                        <button class=""btn btn-primary"" id=""btn-apply-coupon"">Áp dụng</button>
                                    </span>
                                </div>
                            </div>
                        <div class=""cart_navigation"">
                            <a class=""continue-btn"" href=""/""><i class=""fa fa-arrow-left""> </i>&nbsp; Tiếp tục mua hàng</a>
                            <a class=""checkout-btn""");
            BeginWriteAttribute("href", " href=\"", 4217, "\"", 4247, 3);
            WriteAttributeValue("", 4224, "/", 4224, 1, true);
#nullable restore
#line 96 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4225, culture, 4225, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4233, "/Cart/Checkout", 4233, 14, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-check\"></i> Tiến hành thanh toán</a>\r\n                        </div>\r\n");
#nullable restore
#line 98 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-group"" id=""coupon-input"" style=""width:300px"">
                                <label>Bạn có coupon giảm giá?</label>
                                <div class=""input-group"">
                                    <input type=""text"" class=""form-control"" id=""coupon-input-control"" placeholder=""Nhập mã Coupon"">
                                    <span class=""input-group-btn"">
                                        <button class=""btn btn-primary"" id=""btn-apply-coupon"" >Áp dụng</button>
                                    </span>
                                </div>
                            </div>
                        <div class=""cart_navigation"">
                            <a class=""continue-btn"" href=""/""><i class=""fa fa-arrow-left""> </i>&nbsp; Tiếp tục mua hàng</a>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fc0a2044ba4f99917f7f777ad129acd81c01c914170", async() => {
                WriteLiteral("<i class=\"fa fa-check\"></i> Tiến hành thanh toán");
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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 114 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>

<style>
    /******************************************
    29. shopping cart
    ******************************************/

    .page-order ul.step {
        width: 100%;
        clear: both;
        overflow: hidden
    }

        .page-order ul.step li {
            display: inline;
            line-height: 30px;
            width: 19%;
            float: left;
            text-align: center;
            border: 1px solid #ccc;
            margin-right: 12px;
            background: #fff;
            text-transform: uppercase
        }

            .page-order ul.step li:last-child {
                margin-right: 0px
            }

            .page-order ul.step li.current-step {
                border: 1px solid #e99544
            }

    .page-order .heading-counter {
        margin: 30px 0;
        padding: 15px;
        border: 1px solid #e8e6e2;
        background: #fff
    }
");
            WriteLiteral(@"
    .table-bordered > thead > tr > td, .table-bordered > thead > tr > th {
        border-bottom-width: 0px
    }

    .page-order .cart_navigation a.continue-btn {
        padding: 10px 20px;
        border: 0px solid #e8e6e2;
        background: #f9f9f9;
        font-weight: 500;
        display: inline-block;
        margin-bottom: 10px;
        border-radius: 3px;
        text-transform: uppercase;
    }

    .page-order .availability {
        text-align: center
    }

    .page-order .product-name {
        font-size: 13px;
        margin-bottom: 0px;
        font-weight: 600;
    }

    .page-order .cart_description {
        font-size: 14px
    }

    .page-order .cart_navigation a.checkout-btn {
        float: right;
        background: #e83f33;
        color: #fff;
        border: 1px solid #e83f33;
        font-size: 16px;
        font-weight: 600;
        padding: 8px 30px;
        border-radius: 3px;
        text-transform: uppercase;
    }

        .page");
            WriteLiteral(@"-order .cart_navigation a.checkout-btn:hover {
            border: 1px solid #222;
            background: #222;
        }

    .cart_summary > thead, .cart_summary > tfoot {
        background: #f8f8f8;
        font-size: 16px
    }

        .cart_summary > tfoot strong {
            color: #e74c3c
        }

        .cart_summary > thead > th {
            border-bottom-width: 1px;
            padding: 20px
        }

    .cart_summary td {
        vertical-align: middle !important;
        padding: 20px
    }

    .cart_summary .table > tbody > tr > td, .table > tbody > tr > th, .cart_summary .table > tfoot > tr > td, .table > tfoot > tr > th, .cart_summary .table > thead > tr > td, .table > thead > tr > th {
        padding: 10px
    }

    .cart_summary img {
        max-width: 100px
    }

    .cart_summary td.cart_product {
        width: 120px;
        padding: 15px
    }

    .cart_summary .price {
        text-align: center;
        font-weight: 600;
    }

");
            WriteLiteral(@"    .cart_summary .qty {
        text-align: center;
        width: 100px
    }

        .cart_summary .qty input {
            text-align: center;
            max-width: 64px;
            margin: 0 auto;
            border-radius: 3px;
            border: 1px solid #e5e5e5;
            box-shadow: none;
            width: 50px;
        }

        .cart_summary .qty a {
            padding: 8px 10px 5px 10px;
            border: 1px solid #e8e6e2;
            display: inline-block;
            width: auto;
            margin-top: 5px
        }

            .cart_summary .qty a:hover {
                background: #e83f33;
                color: #fff
            }

    .cart_summary .action {
        text-align: center
    }

        .cart_summary .action a {
            font-size: 12px;
            display: inline-block;
            line-height: 24px
        }

    .cart_summary tfoot {
        text-align: right
    }

    .cart_navigation {
        margin-top: 10px;");
            WriteLiteral(@"
        float: left;
        width: 100%;
    }

    .table-bordered {
        border: 0px solid #ddd;
    }

        .table-bordered > tbody > tr > td, .table-bordered > tbody > tr > th, .table-bordered > tfoot > tr > td, .table-bordered > tfoot > tr > th, .table-bordered > thead > tr > td, .table-bordered > thead > tr > th {
            border: none;
            border-bottom: 1px solid #e5e5e5;
        }

    .availability.in-stock span {
        color: #fff;
        background-color: #5cb85c;
        padding: 5px 12px;
        font-size: 12px;
        font-weight: 600;
        border-radius: 3px;
    }

    .availability.out-of-stock span {
        color: #fff;
        background-color: #d9534f;
        padding: 5px 12px;
        font-size: 12px;
        font-weight: 600
    }
</style>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
