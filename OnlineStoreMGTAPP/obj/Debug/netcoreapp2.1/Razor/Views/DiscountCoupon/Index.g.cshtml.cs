#pragma checksum "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\DiscountCoupon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d199298bdbf02b408c7466646fc3cd9a3153a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiscountCoupon_Index), @"mvc.1.0.view", @"/Views/DiscountCoupon/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DiscountCoupon/Index.cshtml", typeof(AspNetCore.Views_DiscountCoupon_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d199298bdbf02b408c7466646fc3cd9a3153a81", @"/Views/DiscountCoupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbd3f0bc60dd8c61db6ef2a7fa00b3c7f3d2b60", @"/Views/_ViewImports.cshtml")]
    public class Views_DiscountCoupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/Scripts/KnockoutViewModel/DiscountCoupon/IndexViewModel.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\DiscountCoupon\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 14304, true);
            WriteLiteral(@"<div id=""CouponIndexDiv"">
    <div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
        <a class=""btn btn-primary kt-margin-b-25"" href=""#"" data-bind=""click:AddCoupon"" role=""button"">New Discount Coupon</a>
        <!--begin::Portlet-->
        <div class=""kt-portlet kt-portlet--mobile"">
            <div class=""kt-portlet__body kt-portlet__body--fit"">
                <!--begin: Datatable -->
                <div class=""kt-datatable kt-datatable--default kt-datatable--brand kt-datatable--loaded"" id=""kt_apps_user_list_datatable"" style="""">
                    <table class=""kt-datatable__table"" style=""display: block;"">
                        <thead class=""kt-datatable__head"">
                            <tr class=""kt-datatable__row"" style=""left: 0px;"">
                                <th data-field=""TurnOnOff"" class=""kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check"">
                                    <span style=""width: 20px;"">&nbsp;</span>
  ");
            WriteLiteral(@"                              </th>
                                <th data-field=""CouponCode"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 200px;"">Coupon Code</span>
                                </th>
                                <th data-field=""Comment"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 181px;"">Comment</span>
                                </th>
                                <th data-field=""Discount"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 181px;"">Discount</span>
                                </th>
                                <th data-field=""UsersLeft"" data-autohide-disabled=""false"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 252px;"">Users left</span>
                                </th>
                      ");
            WriteLiteral(@"          <th data-field=""UsersCount"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 100px;"">Users Count</span>
                                </th>
                                <th data-field=""Actions"" data-autohide-disabled=""false"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                    <span style=""width: 110px;"">&nbsp;</span>
                                </th>
                            </tr>
                        </thead>
                        <tbody class=""kt-datatable__body"" style="""">
                            <tr data-row=""0"" class=""kt-datatable__row"" style=""left: 0px;"">
                                <td class=""kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check"" data-field=""TurnOnOff"">
                                    <span style=""width: 20px;"">
                                        <a href=""#"">
                                            <i style=""font-");
            WriteLiteral(@"size:22px;"" class=""fa fa-toggle-on""></i>
                                        </a>
                                    </span>
                                </td>
                                <td data-field=""CouponCode"" class=""kt-datatable__cell"">
                                    <span class=""kt-font-bold"" style=""width: 200px;"">Thank You</span>
                                </td>
                                <td data-field=""Comment"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">Thanks for being loyal customer</span>
                                </td>
                                <td data-field=""Discount"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">15%</span>
                                </td>
                                <td data-field=""UsersLeft"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 252px;"">11</spa");
            WriteLiteral(@"n>
                                </td>
                                <td data-field=""UsersCount"" class=""kt-datatable__cell"">
                                    <span style=""width: 100px;"">25</span>
                                </td>
                                <td data-field=""Actions"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 110px;"">
                                        <button type=""button"" class=""btn btn-warning""><i style=""font-size:12px;"" class=""fa fa-trash-alt""></i> Delete</button>
                                    </span>
                                </td>
                            </tr>
                            <tr data-row=""0"" class=""kt-datatable__row"" style=""left: 0px;"">
                                <td class=""kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check"" data-field=""TurnOnOff"">
                                    <span style=""width: 20px;"">
                   ");
            WriteLiteral(@"                     <a href=""#"">
                                            <i style=""font-size:22px;"" class=""fa fa-toggle-off""></i>
                                        </a>
                                    </span>
                                </td>
                                <td data-field=""CouponCode"" class=""kt-datatable__cell"">
                                    <span class=""kt-font-bold"" style=""width: 200px;"">Thank You</span>
                                </td>
                                <td data-field=""Comment"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">Thanks for being loyal customer</span>
                                </td>
                                <td data-field=""Discount"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">15%</span>
                                </td>
                                <td data-field=""UsersLeft"" data-autohide-disabled=""false"" class");
            WriteLiteral(@"=""kt-datatable__cell"">
                                    <span style=""width: 252px;"">11</span>
                                </td>
                                <td data-field=""UsersCount"" class=""kt-datatable__cell"">
                                    <span style=""width: 100px;"">25</span>
                                </td>
                                <td data-field=""Actions"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 110px;"">
                                        <button type=""button"" class=""btn btn-warning""><i style=""font-size:12px;"" class=""fa fa-trash-alt""></i> Delete</button>
                                    </span>
                                </td>
                            </tr>
                            <tr data-row=""0"" class=""kt-datatable__row"" style=""left: 0px;"">
                                <td class=""kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check"" data-field=""Tu");
            WriteLiteral(@"rnOnOff"">
                                    <span style=""width: 20px;"">
                                        <a href=""#"">
                                            <i style=""font-size:22px;"" class=""fa fa-toggle-on""></i>
                                        </a>
                                    </span>
                                </td>
                                <td data-field=""CouponCode"" class=""kt-datatable__cell"">
                                    <span class=""kt-font-bold"" style=""width: 200px;"">Thank You</span>
                                </td>
                                <td data-field=""Comment"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">Thanks for being loyal customer</span>
                                </td>
                                <td data-field=""Discount"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">15%</span>
                                </td>
 ");
            WriteLiteral(@"                               <td data-field=""UsersLeft"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 252px;"">11</span>
                                </td>
                                <td data-field=""UsersCount"" class=""kt-datatable__cell"">
                                    <span style=""width: 100px;"">25</span>
                                </td>
                                <td data-field=""Actions"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 110px;"">
                                        <button type=""button"" class=""btn btn-warning""><i style=""font-size:12px;"" class=""fa fa-trash-alt""></i> Delete</button>
                                    </span>
                                </td>
                            </tr>
                            <tr data-row=""0"" class=""kt-datatable__row"" style=""left: 0px;"">
                                <td ");
            WriteLiteral(@"class=""kt-datatable__cell--center kt-datatable__cell kt-datatable__cell--check"" data-field=""TurnOnOff"">
                                    <span style=""width: 20px;"">
                                        <a href=""#"">
                                            <i style=""font-size:22px;"" class=""fa fa-toggle-on""></i>
                                        </a>
                                    </span>
                                </td>
                                <td data-field=""CouponCode"" class=""kt-datatable__cell"">
                                    <span class=""kt-font-bold"" style=""width: 200px;"">Thank You</span>
                                </td>
                                <td data-field=""Comment"" class=""kt-datatable__cell"">
                                    <span style=""width: 181px;"">Thanks for being loyal customer</span>
                                </td>
                                <td data-field=""Discount"" class=""kt-datatable__cell"">
                      ");
            WriteLiteral(@"              <span style=""width: 181px;"">15%</span>
                                </td>
                                <td data-field=""UsersLeft"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 252px;"">11</span>
                                </td>
                                <td data-field=""UsersCount"" class=""kt-datatable__cell"">
                                    <span style=""width: 100px;"">25</span>
                                </td>
                                <td data-field=""Actions"" data-autohide-disabled=""false"" class=""kt-datatable__cell"">
                                    <span style=""width: 110px;"">
                                        <button type=""button"" class=""btn btn-warning""><i style=""font-size:12px;"" class=""fa fa-trash-alt""></i> Delete</button>
                                    </span>
                                </td>
                            </tr>
                        </tbody>
");
            WriteLiteral(@"                    </table>
                    <div class=""kt-datatable__pager kt-datatable--paging-loaded"">
                        <ul class=""kt-datatable__pager-nav"">
                            <li>
                                <a title=""First"" class=""kt-datatable__pager-link kt-datatable__pager-link--first kt-datatable__pager-link--disabled"" data-page=""1"" disabled=""disabled"">
                                    <i class=""flaticon2-fast-back""></i>
                                </a>
                            </li>
                            <li>
                                <a title=""Previous"" class=""kt-datatable__pager-link kt-datatable__pager-link--prev kt-datatable__pager-link--disabled"" data-page=""1"" disabled=""disabled"">
                                    <i class=""flaticon2-back""></i>
                                </a>
                            </li>
                            <li style=""""></li>
                            <li style=""display: none;"">
                 ");
            WriteLiteral(@"               <input type=""text"" class=""kt-pager-input form-control"" title=""Page number"">
                            </li>
                            <li>
                                <a class=""kt-datatable__pager-link kt-datatable__pager-link-number kt-datatable__pager-link--active"" data-page=""1"" title=""1"">1</a>
                            </li>
                            <li>
                                <a class=""kt-datatable__pager-link kt-datatable__pager-link-number"" data-page=""2"" title=""2"">2</a>
                            </li>
                            <li>
                                <a class=""kt-datatable__pager-link kt-datatable__pager-link-number"" data-page=""3"" title=""3"">3</a>
                            </li>
                            <li>
                                <a class=""kt-datatable__pager-link kt-datatable__pager-link-number"" data-page=""4"" title=""4"">4</a>
                            </li>
                            <li style=""""></li>
                ");
            WriteLiteral(@"            <li>
                                <a title=""Next"" class=""kt-datatable__pager-link kt-datatable__pager-link--next"" data-page=""2"">
                                    <i class=""flaticon2-next""></i>
                                </a>
                            </li>
                            <li>
                                <a title=""Last"" class=""kt-datatable__pager-link kt-datatable__pager-link--last"" data-page=""4"">
                                    <i class=""flaticon2-fast-next""></i>
                                </a>
                            </li>
                        </ul>
                        <div class=""kt-datatable__pager-info"">
                            <div class=""dropdown bootstrap-select kt-datatable__pager-size"" style=""width: 60px;"">
                                <select class=""selectpicker kt-datatable__pager-size"" title=""10"" data-width=""60px"" data-selected=""10"" tabindex=""-98"">
                                    ");
            EndContext();
            BeginContext(14347, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad58db3e1f14426b002a64ab20314e0", async() => {
                BeginContext(14366, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14377, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(14415, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d3271f908794131a6c8cbc2ae0a305a", async() => {
                BeginContext(14434, 2, true);
                WriteLiteral("20");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14445, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(14483, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0904a6c8ad8443869f39c0415ff40841", async() => {
                BeginContext(14502, 2, true);
                WriteLiteral("30");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14513, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(14551, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25048e05900a4f76a26c7b3112f65ac7", async() => {
                BeginContext(14570, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14581, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(14619, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6fb661d38c04770bbadacb2c41447e8", async() => {
                BeginContext(14639, 3, true);
                WriteLiteral("100");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14651, 2310, true);
            WriteLiteral(@"
                                </select>

                                <div class=""dropdown-menu "">
                                    <div class=""inner show"" role=""listbox"" id=""bs-select-5"" tabindex=""-1"">
                                        <ul class=""dropdown-menu inner show"" role=""presentation""></ul>
                                    </div>
                                </div>
                            </div>
                            <span class=""kt-datatable__pager-detail"">Showing 1 - 10 of 40</span>
                        </div>
                    </div>
                </div>
                <!--end: Datatable -->
            </div>
        </div>
        <!--end::Portlet-->
        <!--begin::Modal-->
        <div class=""modal fade"" id=""kt_datatable_records_fetch_modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-");
            WriteLiteral(@"content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Selected Records</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true""></span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""kt-scroll ps"" data-scroll=""true"" data-height=""200"" style=""height: 200px; overflow: hidden;"">
                            <ul id=""kt_apps_user_fetch_records_selected""></ul>
                            <div class=""ps__rail-x"" style=""left: 0px; bottom: 0px;""><div class=""ps__thumb-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps__rail-y"" style=""top: 0px; right: 0px;""><div class=""ps__thumb-y"" tabindex=""0"" style=""top: 0px; height: 0px;""></div></div>
                        </div>
                    </div>
                    <div c");
            WriteLiteral(@"lass=""modal-footer"">
                        <button type=""button"" class=""btn btn-brand"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <!--end::Modal-->
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(16978, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(16984, 242, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138da4835a7d419aa02479594828703c", async() => {
                    BeginContext(17085, 132, true);
                    WriteLiteral("\r\n        var _indexViewModel = new IndexViewModel();\r\n        ko.applyBindings(_indexViewModel, $(\"#CouponIndexDiv\").get(0));\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 248 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\DiscountCoupon\Index.cshtml"
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
                BeginContext(17226, 8, true);
                WriteLiteral("\r\n  \r\n\r\n");
                EndContext();
            }
            );
            BeginContext(17237, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591