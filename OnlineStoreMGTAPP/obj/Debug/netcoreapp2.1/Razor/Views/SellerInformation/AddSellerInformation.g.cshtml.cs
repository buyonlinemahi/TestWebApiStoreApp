#pragma checksum "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\SellerInformation\AddSellerInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12cfecea77eb6f811b04f273ee9f20a62066221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SellerInformation_AddSellerInformation), @"mvc.1.0.view", @"/Views/SellerInformation/AddSellerInformation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SellerInformation/AddSellerInformation.cshtml", typeof(AspNetCore.Views_SellerInformation_AddSellerInformation))]
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
#line 1 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\_ViewImports.cshtml"
using OnlineStoreMGTAPP;

#line default
#line hidden
#line 2 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\_ViewImports.cshtml"
using OnlineStoreMGTAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12cfecea77eb6f811b04f273ee9f20a62066221", @"/Views/SellerInformation/AddSellerInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbd3f0bc60dd8c61db6ef2a7fa00b3c7f3d2b60", @"/Views/_ViewImports.cshtml")]
    public class Views_SellerInformation_AddSellerInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loader"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/Scripts/KnockoutViewModel/Seller/SellerViewModel.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\SellerInformation\AddSellerInformation.cshtml"
  
    ViewData["Title"] = "AddSellerInformation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(105, 653, true);
            WriteLiteral(@"
<div id=""sellerProfileDiv"">
    <div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <!--begin::Portlet-->
                <div class=""kt-portlet"">
                    <div class=""kt-portlet__head"">
                        <div class=""kt-portlet__head-label"">
                            <h3 class=""kt-portlet__head-title"">
                                Personal Information
                            </h3>
                        </div>
                    </div>
                    <!--begin::Form-->
                    ");
            EndContext();
            BeginContext(758, 5984, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db819c3d72014fb7b1c38e2ed33d43fe", async() => {
                BeginContext(780, 83, true);
                WriteLiteral("\r\n                        <div id=\"loaderDiv\" hidden>\r\n                            ");
                EndContext();
                BeginContext(863, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0914d167cc5455bab8df5a6309feb0f", async() => {
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
                BeginContext(908, 421, true);
                WriteLiteral(@"
                        </div>
                        <div class=""kt-portlet__body"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Business Title</label>
                                        <input type=""hidden"" class=""form-control"" id=""hdUserID""");
                EndContext();
                BeginWriteAttribute("value", " value=", 1329, "", 1351, 1);
#line 30 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\SellerInformation\AddSellerInformation.cshtml"
WriteAttributeValue("", 1336, ViewBag.UserID, 1336, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1351, 101, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" class=\"form-control\" id=\"hdEmailID\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1452, "", 1475, 1);
#line 31 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\SellerInformation\AddSellerInformation.cshtml"
WriteAttributeValue("", 1459, ViewBag.EmailID, 1459, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1475, 3167, true);
                WriteLiteral(@" />
                                        <input type=""text"" class=""form-control""  name=""BusinessTitle"" data-bind=""value:BusinessTitle"" placeholder=""Enter Business Title"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Company Name</label>
                                        <input type=""text"" class=""form-control""  data-bind=""value:CompanyName"" placeholder=""Enter Company Name"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Street Address</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:StreetAddress"" placeholder=""Enter Street Address"">
         ");
                WriteLiteral(@"                           </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>City/Town</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:City"" placeholder=""Enter City/Town"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>State/Region/Province</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:State"" placeholder=""Enter State/Region/Province"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
");
                WriteLiteral(@"                                        <label>Country</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:Country"" placeholder=""Enter Country"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>ZIP/Postal Code</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:ZipCode""  placeholder=""Enter ZIP/Postal Code"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Phone Number</label>
                                        <input type=""text"" class=""form-control"" data-bind=""value:PhoneNumber"" placeholder=""Enter Phone");
                WriteLiteral(" Number\">\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
                BeginContext(5297, 1438, true);
                WriteLiteral(@"                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Number of Products you plan Est.</label>
                                        <input type=""text"" class=""form-control"" id=""txtNumberofProducts"" data-bind=""value:NumberOfProducts"" placeholder=""Enter Est. Number of Products"" onkeypress=""return isNumberKey(event)"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>Brand</label>
                                        <input type=""text"" class=""form-control"" id=""txtBrandName"" data-bind=""value:BrandName"" placeholder=""Enter Brand Name"">
                                    </div>
                                </div>
                            </div>
                        </div>
                 ");
                WriteLiteral(@"       <div class=""kt-portlet__foot"">
                            <div class=""kt-form__actions"">
                                <button type=""submit"" class=""btn btn-primary"" data-bind=""click:SaveSellerProfile"">Submit</button>
                                <button type=""reset"" class=""btn btn-secondary"">Cancel</button>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6742, 159, true);
            WriteLiteral("\r\n                    <!--end::Form-->\r\n                </div>\r\n                <!--end::Portlet-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6918, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6924, 240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c3ac6363e0b42a59bf60f79c418390f", async() => {
                    BeginContext(7018, 137, true);
                    WriteLiteral("\r\n        var _sellerViewModel = new SellerViewModel();\r\n        ko.applyBindings(_sellerViewModel, $(\"#sellerProfileDiv\").get(0));\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 117 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\SellerInformation\AddSellerInformation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7164, 272, true);
                WriteLiteral(@"

    <script>
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
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
