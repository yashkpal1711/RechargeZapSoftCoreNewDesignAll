#pragma checksum "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\FASTag\FASTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7195b1c74f6be025791615dc3ecaac72808d8091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FASTag_FASTag), @"mvc.1.0.view", @"/Views/FASTag/FASTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FASTag/FASTag.cshtml", typeof(AspNetCore.Views_FASTag_FASTag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7195b1c74f6be025791615dc3ecaac72808d8091", @"/Views/FASTag/FASTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc49c793ec8447a5b30706b5d497612b205f7f4", @"/Views/_ViewImports.cshtml")]
    public class Views_FASTag_FASTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/preloader.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/PayUMoneyPayment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\FASTag\FASTag.cshtml"
  
    ViewData["Title"] = "FASTag";
    Layout = "~/Views/Shared/ShareLayoutNew.cshtml";

#line default
#line hidden
            BeginContext(98, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("header", async() => {
                BeginContext(124, 1471, true);
                WriteLiteral(@"
<style>


        .newnumbertype {
            border: none;
            width: 100%;
        }

        input:focus, textarea:focus, select:focus {
            outline: none;
        }

        newnumbertype::-webkit-inner-spin-button,
        newnumbertype::-webkit-outer-spin-button {
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
        }

        input[type=number]::-webkit-inner-spin-button,
        input[type=number]::-webkit-outer-spin-button {
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
        }

        input::-webkit-outer-spin-button,
        input::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }

        /* Firefox */
        input[type=number] {
            -moz-appearance: textfield;
        }

        .btnsubmit {
            background: #172c64;
            /*background: linear-gradient(9");
                WriteLiteral(@"0deg, #10182b 0%, #172c65 100%);*/
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
        }

        .agreeterms {
            font-size: 13px;
            color: #757272;
        }

    ");
                EndContext();
                BeginContext(1596, 128, true);
                WriteLiteral("@media (max-width: 414px) {\r\n        .main-banner-landing {\r\n            padding: 150px 0px 150px;\r\n        }\r\n    }\r\n</style>\r\n");
                EndContext();
            }
            );
            BeginContext(1727, 94, true);
            WriteLiteral("\r\n<div class=\"loader\" id=\"AjaxLoader\" style=\"display:none;\">\r\n    <div class=\"strip-holder\">\r\n");
            EndContext();
            BeginContext(1944, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1952, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7195b1c74f6be025791615dc3ecaac72808d80917216", async() => {
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
            EndContext();
            BeginContext(1988, 513, true);
            WriteLiteral(@"
    </div>
</div>

<section class=""main-banner-landing"" id=""recharge"" >
    <div class=""container-fluid"">
        <div class=""landing-page"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-lg-4 col-md-7 col-sm-12"">

                    <div class=""form-area-box landing-page-form"">
                        <div class=""landing-title text-center"">
                            <h1>FASTag Recharge</h1>
                        </div>
                        ");
            EndContext();
            BeginContext(2501, 2603, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7195b1c74f6be025791615dc3ecaac72808d80918916", async() => {
                BeginContext(2507, 110, true);
                WriteLiteral("\r\n                            <div class=\"form-dth\">\r\n                                <p>Select Operator</p>\r\n");
                EndContext();
                BeginContext(2737, 1056, true);
                WriteLiteral(@"                                <select class=""form-control"" id=""ddoperatorfastag""></select>
                            </div>
                            <div class=""form-dth"">
                                <p id=""dthtext"">Vehicle Number</p>
                                <input type=""text"" id=""vehicleNumber"" style=""text-transform:uppercase"" autocomplete=""off"" class=""form-control"">

                            </div>
                            <div id=""divAmount"" style=""display:none"">
                                <p style=""  margin-bottom: 8px;
  font-size: 13px;
  letter-spacing: 0.2px;
  color: #5b5b5b;
  line-height: 1.1;
"">Enter Amount</p>
                                <div class=""form-area"">
                                    <!-- <label class=""label-title"">Mobile Number*</label> -->
                                    <span><i class=""fa-solid fa-indian-rupee-sign""></i></span>
                                    <input type=""number"" name="""" class=""newnumbertype"" id=""fastagAmo");
                WriteLiteral("unt\" placeholder=\"Amount\" />\r\n\r\n");
                EndContext();
                BeginContext(3894, 1203, true);
                WriteLiteral(@"                                </div>
                            </div>
                            <div id=""divminmaxvalue"" style=""display:none"">
                                <i class=""fa fa-indian-rupee-sign"" style=""font-size:11px;color:green""></i>     <label id=""lblminvalue"" style=""font-size:11px;color:green"">  0</label>-<i class=""fa fa-indian-rupee-sign"" style=""font-size:11px;color:green""></i>     <label id=""lblmaxvalue"" style=""font-size:11px;color:green"">  0</label>
                            </div>
                            <div id=""diverrormessage"" style=""display:none"">
                                <label id=""lblerror"" style=""color:darkred""> </label>
                            </div>
                            <div class=""form-area-btn"">
                                <input type=""button""  id=""btnrechargefetch"" class=""btnsubmit""  value=""Proceed to Recharge"" onclick=""return  validateFastagRechargeFetch();"" />

                                <input type=""button"" value=""Proceed t");
                WriteLiteral("o Recharge\" style=\"display:none;\" id=\"btnrecharge\" class=\"btnsubmit\" onclick=\"return  validateFastagRecharge();\" />\r\n\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5104, 1255, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""main-banner-landing"" id=""userdetail"" style=""display:none;"">
    <div class=""container-fluid"">
        <div class=""landing-page"">
            <div class=""row d-flex justify-content-center"">
                <div class=""col-lg-4 col-md-7 col-sm-12"">

                    <div class=""form-area-box landing-page-form"">
                        <!-- <div class=""landing-login"">
                            <h1>0000000000</h1>
                            <span><i class=""fa-solid fa-indian-rupee-sign""></i> 2000</span>
                        </div> -->

                        <div class=""head-change-area landing-login"">
                            <ul>
                                <li>
                                    <a onclick=""backuserdetail();"" style=""color:white"" class=""back-plan""><i class=""fa-solid fa-chevron-left""></i></a>
                                </li>
 ");
            WriteLiteral("                               <li><span class=\"plan-num\" id=\"headeruserdetail\" style=\"text-transform:uppercase\"></span></li>\r\n                                <li>\r\n                                    <span class=\"landing-price\">\r\n");
            EndContext();
            BeginContext(6451, 258, true);
            WriteLiteral(@"                                        <span id=""headeruserdetailamount""></span>
                                    </span>
                                </li>
                            </ul>
                        </div>
                        ");
            EndContext();
            BeginContext(6709, 2644, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7195b1c74f6be025791615dc3ecaac72808d809114838", async() => {
                BeginContext(6761, 380, true);
                WriteLiteral(@"

                            <div class=""form-area"">
                                <input type=""text"" name=""UserName"" placeholder=""Name"" id=""nameuserdetail"" class=""w-100"" />
                            </div>
                            <div class=""form-area"">
                                <input type=""email"" name=""Email"" placeholder=""Email"" id=""emailuserdetail"" />
");
                EndContext();
                BeginContext(7286, 695, true);
                WriteLiteral(@"                                <input type=""hidden"" class=""form-control  border-2 bg-color-none text-grey-700"" id=""operatoridConfirmuserdetail"" value=""Amount"" name=""OperatorCode"">

                                <input type=""hidden"" class=""form-control  inputconfirm"" id=""amountConfirmuserdetail"" name=""RechargeAmount"">
                                <input type=""hidden"" class=""form-control  inputconfirm"" id=""mobileConfirmuserdetail"" name=""RechargeMobile"">
                            </div>
                            <div class=""form-area"">
                                <input type=""number"" placeholder=""Mobile"" class=""newnumbertype"" id=""mobileuserdetail"" name=""UserMobile"" />
");
                EndContext();
                BeginContext(8127, 90, true);
                WriteLiteral("                            </div>\r\n                            <div class=\"form-agree\">\r\n");
                EndContext();
                BeginContext(8594, 115, true);
                WriteLiteral("                                <input type=\"checkbox\" checked id=\"agreecheck\" />\r\n                                ");
                EndContext();
                BeginContext(8710, 147, false);
#line 191 "D:\Personal\RechargeZap\RechargeZapSoftCoreNewDesignAll\RechargeZapSoftCore\Views\FASTag\FASTag.cshtml"
                           Write(Html.ActionLink("I Agree all Terms & Conditions and processing fees applicable on recharge.", "Terms", "Home", null, new { @class = "agreeterms" }));

#line default
#line hidden
                EndContext();
                BeginContext(8857, 113, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-area-btn landing-btn-login\">\r\n");
                EndContext();
                BeginContext(9032, 314, true);
                WriteLiteral(@"                                <input type=""submit"" class=""btnsubmit"" name=""btnPay"" style=""color:white !important; background-color:#081844;border-color:#081844 ;   padding: 8px 20px;"" onclick=""return  validateRechargeconfirm2();"" value=""Pay Now"" />

                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9353, 114, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9490, 7526, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            loadDTHOperator();

        });
            function validateFastagRechargeFetch() {
          if (document.getElementById(""vehicleNumber"").value == """") {
              toastr.warning('Warning', 'Enter Vehicle Registration Number');
              document.getElementById(""vehicleNumber"").focus();
              return false;
          }
          else if ($('#ddoperatorfastag').find("":selected"").val() == ""0"") {
              toastr.warning('Warning', 'Select Operator');
              document.getElementById(""ddoperatorfastag"").focus();
              return false;
          }
          else {
              var vehicleNumber = document.getElementById(""vehicleNumber"").value;
              var operatorId = $('#ddoperatorfastag').find("":selected"").val();
               FetchDetails(vehicleNumber, operatorId);
          }
        }
        function FetchDetails(vehicleNumber, operatorId) {

            //alert(vehicleNumber);");
                WriteLiteral(@"
            //alert(operatorId);
            var jsondata = { 'vehicleNumber': vehicleNumber, 'operatorId': operatorId };
            //alert(jsondata);
            $.ajax({

                url: '/api/Recharge/fetchDetailsFastag',
                data: JSON.stringify(jsondata),

                dataType: ""json"",
                type: 'POST',
                contentType: ""application/json; charset=utf-8"",

                success: function (result) {
                    //alert(result[0]);
                    //console.log(result.username);
                    //console.log(result[0]);
                    //document.getElementById('userbalancetop').innerHTML = result[0];
                    if (result[0] == '2') {
                        //alert(result[0]);
                        document.getElementById('divAmount').style.display = 'block';
                        document.getElementById('divminmaxvalue').style.display = 'block';
                        document.getElementById('btnrech");
                WriteLiteral(@"argefetch').style.display = 'none';
                        document.getElementById('btnrecharge').style.display = 'block';
                        document.getElementById('diverrormessage').style.display = 'none';



                        document.getElementById('lblminvalue').innerHTML = result[2];
                        document.getElementById('lblmaxvalue').innerHTML = result[3];
                    }
                    else {

                        //alert(result[0]);
                        //alert('error');
                        document.getElementById('divAmount').style.display = 'none';
                        document.getElementById('divminmaxvalue').style.display = 'none';
                        document.getElementById('diverrormessage').style.display = 'block';


                        document.getElementById('btnrechargefetch').style.display = 'block';
                        document.getElementById('btnrecharge').style.display = 'none';

                        doc");
                WriteLiteral(@"ument.getElementById('lblerror').innerHTML = '*Invalid Vehicle Number';
                    }

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

        function validateFastagRecharge() {
            if (document.getElementById(""vehicleNumber"").value == """") {
                toastr.warning('Warning', 'Enter Vehicle Registration Number');
                document.getElementById(""vehicleNumber"").focus();
                return false;
            }
            else if ($('#ddoperatorfastag').find("":selected"").val() == ""0"") {
                toastr.warning('Warning', 'Select Operator');
                document.getElementById(""ddoperatorfastag"").");
                WriteLiteral(@"focus();
                return false;
            }
            else if (document.getElementById(""fastagAmount"").value == """") {
                toastr.warning('Warning', 'Enter Amount');
                document.getElementById(""fastagAmount"").focus();
                return false;
            }
            if (parseFloat(document.getElementById(""fastagAmount"").value) <= 0) {
                toastr.warning('Warning', 'Amount Must Be Greater Than 0');
                document.getElementById(""fastagAmount"").focus();
                return false;
            }
            else if (parseFloat(document.getElementById(""fastagAmount"").value) > 30000) {
                toastr.warning('Warning', 'Amount Must Be Less Than Or Equal To 30000');
                document.getElementById(""fastagAmount"").focus();
                return false;
            }
            else {

                //document.getElementById(""amountConfirm"").value = document.getElementById(""amountdth"").value;
                //do");
                WriteLiteral(@"cument.getElementById(""operatorConfirm"").value = $('#ddoperatordth').find("":selected"").text();
                //document.getElementById(""mobileConfirm"").value = document.getElementById(""numberdth"").value;
                //document.getElementById(""customermobileConfirm"").value = document.getElementById(""mobileNumber"").value;


                document.getElementById(""amountConfirmuserdetail"").value = document.getElementById(""fastagAmount"").value;
                document.getElementById(""operatoridConfirmuserdetail"").value = $('#ddoperatorfastag').find("":selected"").val();
                document.getElementById(""mobileConfirmuserdetail"").value = document.getElementById(""vehicleNumber"").value;

                //document.getElementById(""mobileuserdetail"").value = document.getElementById(""mobileNumber"").value;
                document.getElementById(""headeruserdetail"").innerHTML = document.getElementById(""vehicleNumber"").value + ' - <i class=""fa fa-inr""></i>' + document.getElementById(""fastagAmount"").");
                WriteLiteral(@"value

                document.getElementById('recharge').style.display = 'none';
                document.getElementById('userdetail').style.display = 'block';
            }
        }
        function validateRechargeconfirm2() {
            if (document.getElementById(""emailuserdetail"").value == """") {
                toastr.warning('Warning', 'Enter Email');
                document.getElementById(""emailuserdetail"").focus();
                return false;
            }
            else if (document.getElementById(""nameuserdetail"").value == """") {
                toastr.warning('Warning', 'Enter Name');
                document.getElementById(""nameuserdetail"").focus();
                return false;
            }
            else if (document.getElementById(""mobileuserdetail"").value == """") {
                toastr.warning('Warning', 'Enter Mobile');
                document.getElementById(""mobileuserdetail"").focus();
                return false;
            }
            if (document.get");
                WriteLiteral(@"ElementById('agreecheck').checked) {
                //alert(""checked"");
            } else {
                toastr.warning('Warning', 'Please Accept Terms and Conditions');
                return false;
                //document.getElementById(""nameuserdetail"").focus();
            }
            var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+");
                EndContext();
                BeginContext(17017, 2436, true);
                WriteLiteral(@"@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
            if (document.getElementById(""emailuserdetail"").value.match(validRegex)) {
                //alert(""Valid email address!"");
                //document.form1.text1.focus();
                //document.getElementById(""emailuserdetail"").focus();
                //return true;
            } else {
                //alert(""Invalid email address!"");
                //document.form1.text1.focus();
                toastr.warning('Warning', 'Enter Valid Email');
                document.getElementById(""emailuserdetail"").focus();
                return false;
            }
        }
    
        function backuserdetail() {
            document.getElementById('recharge').style.display = 'block';
            document.getElementById('userdetail').style.display = 'none';
            document.getElementById('plan').style.display = 'none';
        }
        function loadDTHOperator() {
            $.ajax({

                url: '/api/Recharge/GetOperatorF");
                WriteLiteral(@"astag',
                //data: ""{ 'Amount': '"" + depositeAmt  + ""','userid': '"" + '<%=Session[""UserId""] %>'  + ""','FromWalletAddress': '"" + wallet_address  + ""','ToWalletAddress': '"" + contract_addr  + ""','ReferenceId': '"" + result  + ""'}"",
                data: """",
                dataType: ""json"",
                type: 'GET',
                contentType: ""application/json; charset=utf-8"",

                success: function (result) {
                    //alert(result);
                    //console.log(result.d);
                    $('#ddoperatorfastag').empty();
                    $('#ddoperatorfastag').append('<option value=""0"">Select Operator</option>');
                    $.each(result, function (result, value) {

                        $(""#ddoperatorfastag"").append($(""<option></option>"").val(value.id).html(value.operator));
                    })
                    //toastr.success('Success', result.d);

                },
                beforeSend: function () {
           ");
                WriteLiteral(@"                                                                                 /*$(""#ddoperatormobile"").html('Loading...')*/;
                    $('#ddoperatorfastag').empty().append('<option>Loading...</option>');
                },
                complete: function () {
                    // Code to hide spinner.
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
