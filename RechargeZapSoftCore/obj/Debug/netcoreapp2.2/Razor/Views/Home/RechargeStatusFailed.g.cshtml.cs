#pragma checksum "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f695b82e91d3cc78c6b4953aa8479fbe8c5b41ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RechargeStatusFailed), @"mvc.1.0.view", @"/Views/Home/RechargeStatusFailed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RechargeStatusFailed.cshtml", typeof(AspNetCore.Views_Home_RechargeStatusFailed))]
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
#line 1 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\_ViewImports.cshtml"
using RechargeZapSoftCore;

#line default
#line hidden
#line 2 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\_ViewImports.cshtml"
using RechargeZapSoftCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f695b82e91d3cc78c6b4953aa8479fbe8c5b41ae", @"/Views/Home/RechargeStatusFailed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc49c793ec8447a5b30706b5d497612b205f7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RechargeStatusFailed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RechargeZapSoftCore.Models.clsRecharge>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/new2/img/failed.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
  
    ViewData["Title"] = "Online Mobile Recharge - Bill Payments & Prepaid Recharge on RechargeZap";
    Layout = "~/Views/Shared/SharedLayoutNewDesign.cshtml";

#line default
#line hidden
            BeginContext(216, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(696, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(720, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(727, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3969, 276, true);
            WriteLiteral(@"<section class=""recharge_main"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-10"">
                <div class=""recharge_main_box"">
                    <div class=""recharge_top"">
                        ");
            EndContext();
            BeginContext(4245, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f695b82e91d3cc78c6b4953aa8479fbe8c5b41ae5237", async() => {
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
            BeginContext(4290, 739, true);
            WriteLiteral(@"
                        <h2>Recharge Unsuccessful</h2>
                        <p>Oops! Your payment is failed. Please try again using a different payment method.</p>
                        <a href=""/"" class=""btn_all"">Make Another Recharge</a>
                    </div>

                    <div class=""recharge_details"">
                        <div class=""recharge_details_col"">
                            <h3>Recharge/Bill Payment Details</h3>
                            <div class=""recharge_details_left_text_details"">
                                <h4>Payment Status:</h4>
                                <p class=""text-danger mb-3"">Your payment is unsuccessful</p>
                                <p>Payment of Rs ");
            EndContext();
            BeginContext(5030, 44, false);
#line 92 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                            Write(Html.DisplayFor(m => m.PaymentGatewayAmount));

#line default
#line hidden
            EndContext();
            BeginContext(5074, 95, true);
            WriteLiteral(" not received by RechargeZap</p>\r\n                                <p><span>Payment ID</span> : ");
            EndContext();
            BeginContext(5170, 45, false);
#line 93 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                                        Write(Html.DisplayFor(m => m.PaymentGatewayOrderid));

#line default
#line hidden
            EndContext();
            BeginContext(5215, 182, true);
            WriteLiteral("</p>\r\n                                <!-- <p><span>Order ID</span> : 202205101217365120281430739</p> -->\r\n                                <p><span>Recharge/Bill Amount</span> : Rs. ");
            EndContext();
            BeginContext(5398, 38, false);
#line 95 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                                                      Write(Html.DisplayFor(m => m.RechargeAmount));

#line default
#line hidden
            EndContext();
            BeginContext(5436, 78, true);
            WriteLiteral("</p>\r\n                                <p><i class=\"fa-solid fa-calendar\"></i> ");
            EndContext();
            BeginContext(5515, 36, false);
#line 96 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                                                   Write(Html.DisplayFor(m => m.RechargeDate));

#line default
#line hidden
            EndContext();
            BeginContext(5551, 411, true);
            WriteLiteral(@" </p>
                            </div>

                        </div>
                        <div class=""recharge_details_col recharge_details_right"">
                            <h3>Payment Summary</h3>
                            <div class=""recharge_details_left_text_details"">
                                <h4>Recharge Status:</h4>
                                <p>Recharge/Bill Payment of ");
            EndContext();
            BeginContext(5963, 36, false);
#line 104 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                                       Write(Html.DisplayFor(m => m.OperatorName));

#line default
#line hidden
            EndContext();
            BeginContext(5999, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(6002, 38, false);
#line 104 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                                                                              Write(Html.DisplayFor(m => m.RechargeMobile));

#line default
#line hidden
            EndContext();
            BeginContext(6040, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(6160, 173, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"recharge_details_left_text_details p-order-id\">\r\n                                <h4>Order ID :  ");
            EndContext();
            BeginContext(6334, 35, false);
#line 108 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                                           Write(Html.DisplayFor(m => m.ReferenceId));

#line default
#line hidden
            EndContext();
            BeginContext(6369, 270, true);
            WriteLiteral(@"</h4>
                                <!-- <p><span> </span></p> -->
                            </div>
                            <div class=""recharge_details_amount"">
                                <p><span>Amount</span></p>
                                <p>₹");
            EndContext();
            BeginContext(6640, 38, false);
#line 113 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                               Write(Html.DisplayFor(m => m.RechargeAmount));

#line default
#line hidden
            EndContext();
            BeginContext(6678, 214, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"recharge_details_amount\">\r\n                                <p><span>Processing Fees</span></p>\r\n                                <p>₹");
            EndContext();
            BeginContext(6893, 40, false);
#line 117 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                               Write(Html.DisplayFor(m => m.ProcessingCharge));

#line default
#line hidden
            EndContext();
            BeginContext(6933, 229, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"recharge_details_amount recharge_details_amount2\">\r\n                                <p><span>Total</span></p>\r\n                                <p>₹");
            EndContext();
            BeginContext(7163, 44, false);
#line 121 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                               Write(Html.DisplayFor(m => m.PaymentGatewayAmount));

#line default
#line hidden
            EndContext();
            BeginContext(7207, 252, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<script>\r\n\r\n    function showError() {\r\n        var VarError = \'");
            EndContext();
            BeginContext(7460, 17, false);
#line 134 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\RechargeStatusFailed.cshtml"
                   Write(ViewBag.errortext);

#line default
#line hidden
            EndContext();
            BeginContext(7477, 121, true);
            WriteLiteral("\'\r\n        if (VarError != \'\') {\r\n\r\n            toastr.error(\'Error\', VarError);\r\n\r\n            }\r\n    }\r\n\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RechargeZapSoftCore.Models.clsRecharge> Html { get; private set; }
    }
}
#pragma warning restore 1591
