#pragma checksum "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f88a7e5afea203f974af6cdc225557b55ea969"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f88a7e5afea203f974af6cdc225557b55ea969", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc49c793ec8447a5b30706b5d497612b205f7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact Us | RechargeZap";
    Layout = "~/Views/Shared/SharedLayoutNewDesign.cshtml";

#line default
#line hidden
            BeginContext(123, 527, true);
            WriteLiteral(@"

<section class=""sec-breadcrumb"">
    <div class=""page-title text-center"">
        <h1>Contact Us</h1>
    </div>
</section>
<section style=""background-color: #f8f9fa;"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">

            </div>
            <div class=""col-lg-6 col-md-12 mb-4 "">
                <div class=""contact-form"">
                    <h4>Drop Your Query</h4>
                    <div class=""form-area-box"">
                        ");
            EndContext();
            BeginContext(650, 1619, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f88a7e5afea203f974af6cdc225557b55ea9694974", async() => {
                BeginContext(693, 967, true);
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" id=""txtname"" name=""UserName"" placeholder=""Name"" required class=""form-control"" />
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" id=""txtemail"" name=""Email"" placeholder=""Email Id"" required
                                       class=""form-control"" />
                            </div>
                            <div class=""form-group"">
                                <input type=""tel"" id=""txtmobile"" name=""Mobile"" placeholder=""Phone No."" required
                                       class=""form-control"" />
                            </div>
                            <textarea class=""form-control"" name=""Message"" placeholder=""Message"" id=""txtmessage"" style=""min-height: 150px;""></textarea>
                            <div class=""form-area-btn"">
");
                EndContext();
                BeginContext(1736, 526, true);
                WriteLiteral(@"                                <input type=""submit"" class=""submitbtm"" name=""btnPay"" style=""background: #172c64;
    /* background: linear-gradient(90deg, #10182b 0%, #172c65 100%); */
    border-radius: 5px;
    border: none;
    color: #fff;
    font-size: 15px;
    font-weight: 400;
    padding: 10px 30px;
    letter-spacing: 0.7px;
    cursor: pointer;
    height: 45px;
    width: 100%;
"" onclick=""return  validateContact();"" value=""Submit"" />

                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2269, 1757, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12 mb-4 "">
                <div class=""contact-form"">
                    <h4>Reach Us</h4>
                    <ul>
                        <li>
                            <a href=""#!"">
                                <i class=""fa-solid fa-location-dot""></i>
                                <p>
                                    <span>
                                        Orion Techno Age
                                        Private Limited
                                    </span> <br>H213, Ground Floor, Sector 63,
                                    Noida, Uttar Pradesh, India.
                                </p>
                            </a>
                        </li>
                        <li>
                            <a href=""tel:9354827769"">
                                <i class=""fa-solid fa-phone""></i>
                                <p>
        ");
            WriteLiteral(@"                            +91-9354827769 <span>
                                        (Mon
                                        - Fri , 10AM - 6PM)
                                    </span>
                                </p>
                            </a>
                        </li>
                        <li>
                            <a href=""mailto:care@rechargezap.in"">
                                <i class=""fa-solid fa-envelope""></i>
                                <p>care@rechargezap.in <span>(24X7)</span></p>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>

        </div>
    </div>
</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4049, 773, true);
                WriteLiteral(@"
    <script>
    function validateContact() {

        if (document.getElementById(""txtemail"").value == """") {
            toastr.warning('Warning', 'Enter Email');
            document.getElementById(""txtemail"").focus();
            return false;
        }

        else if (document.getElementById(""txtname"").value == """") {
            toastr.warning('Warning', 'Enter Name');
            document.getElementById(""txtname"").focus();
            return false;
        }

        else if (document.getElementById(""txtmessage"").value == """") {
            toastr.warning('Warning', 'Enter Message');
            document.getElementById(""txtmessage"").focus();
            return false;
        }
        var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+");
                EndContext();
                BeginContext(4823, 655, true);
                WriteLiteral(@"@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
        if (document.getElementById(""txtemail"").value.match(validRegex)) {
            //alert(""Valid email address!"");
            //document.form1.text1.focus();
            document.getElementById(""txtemail"").focus();
            //return true;
        } else {
            //alert(""Invalid email address!"");
            //document.form1.text1.focus();
            toastr.warning('Warning', 'Enter Valid Email');
            document.getElementById(""txtemail"").focus();
            return false;
        }

    }
         $(document).ready(function () {

               var VarContactFormError = '");
                EndContext();
                BeginContext(5479, 24, false);
#line 137 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\Contact.cshtml"
                                     Write(ViewBag.ContactFormError);

#line default
#line hidden
                EndContext();
                BeginContext(5503, 49, true);
                WriteLiteral("\'\r\n               var VarContactFormErrorText = \'");
                EndContext();
                BeginContext(5553, 23, false);
#line 138 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\Home\Contact.cshtml"
                                         Write(ViewBag.ContactFormText);

#line default
#line hidden
                EndContext();
                BeginContext(5576, 1738, true);
                WriteLiteral(@"'
             if (VarContactFormError == '1') {

                 toastr.success('Success', VarContactFormErrorText);
             }
             else if (VarContactFormError == '0') {
                 toastr.error('Error', VarContactFormErrorText);
             }
        });

    function ContactFormSubmit2() {

        var jsondata = { 'userName': document.getElementById(""txtname"").value, 'email': document.getElementById(""txtemail"").value, 'message': document.getElementById(""txtmessage"").value };

        //alert(jsondata);
        $.ajax({

            url: '/api/Recharge/ContactForm',
            data: JSON.stringify(jsondata),

            dataType: ""json"",
            type: 'POST',
            contentType: ""application/json; charset=utf-8"",

            success: function (result) {
                //alert(result[2]);
                //console.log(result[0]);
                //console.log(result[1]);
                //console.log(result[2]);
                //console.log(res");
                WriteLiteral(@"ult.str_tabheader);
                //alert(result[0]);
                //document.getElementById(""tabheaderdth"").innerHTML = result[0];
                //document.getElementById(""tabcontentdth"").innerHTML = result[1];
                //showModalDTHplan();
                toastr.success('Success', result[0]);
            },
            beforeSend: function () {
                                                                                                            /*$(""#ddoperatormobile"").html('Loading...')*/;
                $('#AjaxLoader').show();
            },
            complete: function () {
                $('#AjaxLoader').hide();
            }
        })
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
