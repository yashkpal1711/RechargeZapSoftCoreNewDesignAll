#pragma checksum "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c32781a626a538e6c204e17caf4cad4e9474f69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_paytmResponse), @"mvc.1.0.view", @"/Views/Home/paytmResponse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/paytmResponse.cshtml", typeof(AspNetCore.Views_Home_paytmResponse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c32781a626a538e6c204e17caf4cad4e9474f69", @"/Views/Home/paytmResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc49c793ec8447a5b30706b5d497612b205f7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_paytmResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RechargeZapSoftCore.Models.PaytmResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
  
    ViewData["Title"] = "Online Mobile Recharge - Bill Payments & Prepaid Recharge on RechargeZap";
    Layout = "~/Views/Shared/Sharedlayuout2.cshtml";

#line default
#line hidden
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(241, 481, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center""><h1 class=""text-grey-800 fw-700 display3-size"">Payment Status <span class=""font-xsss text-grey-600 fw-600 d-block mt-2"">Home / Payment Status </span></h1></div>
            </div>
            <div align=""center"">
                <table border=""1"" width=""50%"">
                    <tr>
                        <td>");
            EndContext();
            BeginContext(723, 31, false);
#line 17 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.MID));

#line default
#line hidden
            EndContext();
            BeginContext(754, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(790, 27, false);
#line 18 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.MID));

#line default
#line hidden
            EndContext();
            BeginContext(817, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(906, 35, false);
#line 21 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.ORDERID));

#line default
#line hidden
            EndContext();
            BeginContext(941, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(977, 31, false);
#line 22 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.ORDERID));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1097, 37, false);
#line 25 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.TXNAMOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1170, 33, false);
#line 26 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.TXNAMOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1292, 36, false);
#line 29 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.CURRENCY));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1364, 32, false);
#line 30 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.CURRENCY));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1485, 33, false);
#line 33 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.TXNID));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1554, 29, false);
#line 34 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.TXNID));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1672, 37, false);
#line 37 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.BANKTXNID));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1745, 33, false);
#line 38 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.BANKTXNID));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1867, 34, false);
#line 41 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.STATUS));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1937, 30, false);
#line 42 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.STATUS));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2056, 36, false);
#line 45 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.RESPCODE));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2128, 32, false);
#line 46 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.RESPCODE));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2249, 35, false);
#line 49 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.RESPMSG));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2320, 31, false);
#line 50 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.RESPMSG));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2440, 35, false);
#line 53 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.TXNDATE));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2511, 31, false);
#line 54 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.TXNDATE));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2631, 39, false);
#line 57 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.GATEWAYNAME));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2706, 35, false);
#line 58 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.GATEWAYNAME));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2830, 36, false);
#line 61 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.BANKNAME));

#line default
#line hidden
            EndContext();
            BeginContext(2866, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2902, 32, false);
#line 62 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.BANKNAME));

#line default
#line hidden
            EndContext();
            BeginContext(2934, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3023, 39, false);
#line 65 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.PAYMENTMODE));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3098, 35, false);
#line 66 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.PAYMENTMODE));

#line default
#line hidden
            EndContext();
            BeginContext(3133, 88, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3222, 40, false);
#line 69 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayNameFor(m => m.CHECKSUMHASH));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3298, 36, false);
#line 70 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                       Write(Html.DisplayFor(m => m.CHECKSUMHASH));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 86, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </table>\r\n                error : ");
            EndContext();
            BeginContext(3421, 17, false);
#line 74 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\paytmResponse.cshtml"
                   Write(ViewBag.errortext);

#line default
#line hidden
            EndContext();
            BeginContext(3438, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RechargeZapSoftCore.Models.PaytmResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591