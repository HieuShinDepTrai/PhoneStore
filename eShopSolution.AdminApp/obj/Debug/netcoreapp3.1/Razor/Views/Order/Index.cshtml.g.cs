#pragma checksum "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e54f3cf461f3c91fae7a225574a678493caae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
using eShopSolution.ViewModels.Utilities.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e54f3cf461f3c91fae7a225574a678493caae3", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e4c500cfeba51cc3f15b2138c785a921f881f2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<eShopSolution.ViewModels.Sales.OrderViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/order.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Danh sách đơn hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e54f3cf461f3c91fae7a225574a678493caae35908", async() => {
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
                WriteLiteral("\r\n    <script>\r\n        var orderController = new OrderController();\r\n        orderController.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách đơn hàng</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a style=""color: #0779e4;"" href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách đơn hàng</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-7 col-xs-12"">
                </div>
                <div class=""col-md-5 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e54f3cf461f3c91fae7a225574a678493caae37740", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-9\">\r\n");
                WriteLiteral("                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1438, "\"", 1462, 1);
#nullable restore
#line 39 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
WriteAttributeValue("", 1446, ViewBag.Keyword, 1446, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keyword"" class=""form-control"" />
                            </div>
                            <div class=""col-md-3"">
                                <button type=""submit"" class=""btn btn-info""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                <button type=""button"" onclick=""window.location.href='/Order/Index'"" class=""btn btn-secondary"">Đặt lại</button>
                            </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""text-center"">
                                ID
                            </th>
                            <th>
                                Khách hàng
                            </th>
                            <th class=""text-center"">
                                Ngày đặt
                            </th>
                            <th class=""text-center"">
                                Trạng thái
                            </th>
                            <th class=""text-center"">
                                Giá trị đơn hàng
                            </th>
                            <th class=""text-center"">
                                Xử lý đơn
                            </th>
            WriteLiteral("\n                            <th class=\"text-center\">\r\n                                Thao tác\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 79 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 83 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 86 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 89 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n");
#nullable restore
#line 92 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                      
                                        var status = "";
                                        var statusEnum = (int)item.Status;
                                        switch (statusEnum)
                                        {
                                            case 1:
                                                status = "Đang chờ duyệt";
                                                break;
                                            case 2:
                                                status = "Đã duyệt";
                                                break;
                                            case 3:
                                                status = "Đang giao";
                                                break;
                                            case 4:
                                                status = "Đã giao";
                                                break;
                                            case 5:
                                                status = "Đã huỷ";
                                                break;
                                            default:
                                                status = "...";
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 117 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                               Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
#nullable restore
#line 120 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                               Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span>&#8363;</span>\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n\r\n");
#nullable restore
#line 125 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                     if (item.Status == (OrderStatus)1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-success btn-update-status\" data-id=\"");
#nullable restore
#line 127 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 127 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                                        Write(Html.ActionLink("Duyệt đơn", "UpdateOrderStatus", new { orderId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                        <button class=\"btn btn-danger btn-cancel\" data-id=\"");
#nullable restore
#line 128 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Hủy đơn</button>\r\n");
#nullable restore
#line 129 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                    }
                                    else if (item.Status == (OrderStatus)2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn-success btn-update-status\" data-id=\"");
#nullable restore
#line 132 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 132 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                                        Write(Html.ActionLink("Giao hàng", "UpdateOrderStatus", new { orderId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                        <button class=\"btn btn-danger btn-cancel\" data-id=\"");
#nullable restore
#line 133 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Hủy đơn</button>\r\n");
#nullable restore
#line 134 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                    }
                                    else if (item.Status == (OrderStatus)3)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button class=\"btn btn btn-success btn-update-status\" data-id=\"");
#nullable restore
#line 137 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 137 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                                                                            Write(Html.ActionLink("Xác nhận đã giao hàng", "UpdateOrderStatus", new { orderId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 138 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <button class=\"btn btn-primary\">");
#nullable restore
#line 141 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                                                               Write(Html.ActionLink("Xem chi tiết", "Detail", new { orderId = item.Id, name = item.Name }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 144 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 149 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.AdminApp\Views\Order\Index.cshtml"
       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<eShopSolution.ViewModels.Sales.OrderViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591