#pragma checksum "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65324bd45a6883fa3e42c90f5c70b4c59d28f381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65324bd45a6883fa3e42c90f5c70b4c59d28f381", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbd3f0bc60dd8c61db6ef2a7fa00b3c7f3d2b60", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-margin-l-20 hide-submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("kt_subheader_search_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/AddUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-label-brand btn-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return check()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/Scripts/KnockoutViewModel/User/IndexViewModel.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 786, true);
            WriteLiteral(@"
<div class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" id=""kt_content"">
    <div id=""UserDataDiv"">
        <!-- begin:: Content Head -->
        <div class=""kt-subheader   kt-grid__item"" id=""kt_subheader"">
            <div class=""kt-container  kt-container--fluid "">
                <div class=""kt-subheader__main"">

                    <h3 class=""kt-subheader__title"">
                        Users
                    </h3>

                    <span class=""kt-subheader__separator kt-subheader__separator--v""></span>

                    <div class=""kt-subheader__group"" id=""kt_subheader_search"">
                        <span class=""kt-subheader__desc"" id=""kt_subheader_total"">

                        </span>

                        ");
            EndContext();
            BeginContext(936, 2249, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32a03750dd2a4420a678dc0865478cd3", async() => {
                BeginContext(1007, 2171, true);
                WriteLiteral(@"
                            <div class=""kt-input-icon kt-input-icon--right kt-subheader__search"">
                                <input type=""text"" name=""searchtext"" id=""searchtext"" data-bind=""value:searchText"" class=""form-control"" placeholder=""Search..."">
                                <label style=""position: absolute; top: 5px; right: 10px;"">
                                    <span class=""kt-input-icon__icon kt-input-icon__icon--right"">
                                        <span>
                                            <input data-bind=""click:$root.SearchUser"" type=""submit"" />
                                            <svg  width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"" class=""kt-svg-icon"">
                                                <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                                    <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                                                    <path d=""M14.2928932,");
                WriteLiteral(@"16.7071068 C13.9023689,16.3165825 13.9023689,15.6834175 14.2928932,15.2928932 C14.6834175,14.9023689 15.3165825,14.9023689 15.7071068,15.2928932 L19.7071068,19.2928932 C20.0976311,19.6834175 20.0976311,20.3165825 19.7071068,20.7071068 C19.3165825,21.0976311 18.6834175,21.0976311 18.2928932,20.7071068 L14.2928932,16.7071068 Z"" fill=""#000000"" fill-rule=""nonzero"" opacity=""0.3"" />
                                                    <path d=""M11,16 C13.7614237,16 16,13.7614237 16,11 C16,8.23857625 13.7614237,6 11,6 C8.23857625,6 6,8.23857625 6,11 C6,13.7614237 8.23857625,16 11,16 Z M11,18 C7.13400675,18 4,14.8659932 4,11 C4,7.13400675 7.13400675,4 11,4 C14.8659932,4 18,7.13400675 18,11 C18,14.8659932 14.8659932,18 11,18 Z"" fill=""#000000"" fill-rule=""nonzero"" />
                                                </g>
                                            </svg>                                    <!--<i class=""flaticon2-search-1""></i>-->
                                        </span>
                        ");
                WriteLiteral("            </span>\r\n                                </label>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(3185, 3787, true);
            WriteLiteral(@"
                    </div>

                    <div class=""kt-subheader__group kt-hidden"" id=""kt_subheader_group_actions"">

                        <div class=""kt-subheader__desc""><span id=""kt_subheader_group_selected_rows""></span> Selected:</div>

                        <div class=""btn-toolbar kt-margin-l-20"">
                            <div class=""dropdown"" id=""kt_subheader_group_actions_status_change"">
                                <button type=""button"" class=""btn btn-label-brand btn-bold btn-sm dropdown-toggle"" data-toggle=""dropdown"">
                                    Update Status
                                </button>
                                <div class=""dropdown-menu"">
                                    <ul class=""kt-nav"">
                                        <li class=""kt-nav__section kt-nav__section--first"">
                                            <span class=""kt-nav__section-text"">Change status to:</span>
                                        </li>
      ");
            WriteLiteral(@"                                  <li class=""kt-nav__item"">
                                            <a href=""#"" class=""kt-nav__link"" data-toggle=""status-change"" data-status=""1"">
                                                <span class=""kt-nav__link-text""><span class=""kt-badge kt-badge--unified-success kt-badge--inline kt-badge--bold"">Approved</span></span>
                                            </a>
                                        </li>
                                        <li class=""kt-nav__item"">
                                            <a href=""#"" class=""kt-nav__link"" data-toggle=""status-change"" data-status=""2"">
                                                <span class=""kt-nav__link-text""><span class=""kt-badge kt-badge--unified-danger kt-badge--inline kt-badge--bold"">Rejected</span></span>
                                            </a>
                                        </li>
                                        <li class=""kt-nav__item"">
                    ");
            WriteLiteral(@"                        <a href=""#"" class=""kt-nav__link"" data-toggle=""status-change"" data-status=""3"">
                                                <span class=""kt-nav__link-text""><span class=""kt-badge kt-badge--unified-warning kt-badge--inline kt-badge--bold"">Pending</span></span>
                                            </a>
                                        </li>
                                        <li class=""kt-nav__item"">
                                            <a href=""#"" class=""kt-nav__link"" data-toggle=""status-change"" data-status=""4"">
                                                <span class=""kt-nav__link-text""><span class=""kt-badge kt-badge--unified-info kt-badge--inline kt-badge--bold"">On Hold</span></span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <button class=""btn btn-la");
            WriteLiteral(@"bel-success btn-bold btn-sm btn-icon-h"" id=""kt_subheader_group_actions_fetch"" data-toggle=""modal"" data-target=""#kt_datatable_records_fetch_modal"">
                                Fetch Selected
                            </button>
                            <button class=""btn btn-label-danger btn-bold btn-sm btn-icon-h"" id=""kt_subheader_group_actions_delete_all"">
                                Delete All
                            </button>
                        </div>
                    </div>
                </div>
                <div class=""kt-subheader__toolbar"">

                    <a href=""/metronic/preview/demo1/.html"" class="""">

                    </a>

                    ");
            EndContext();
            BeginContext(6972, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b8f9def66f243d5b53e17075dbdca6d", async() => {
                BeginContext(7059, 8, true);
                WriteLiteral("Add User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7071, 9267, true);
            WriteLiteral(@"

                    <div class=""kt-subheader__wrapper"">
                        <div class=""dropdown dropdown-inline"" data-toggle=""kt-tooltip-"" title=""Quick actions"" data-placement=""left"">
                            <a href=""#"" class=""btn btn-icon"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"" class=""kt-svg-icon kt-svg-icon--success kt-svg-icon--md"">
                                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                        <polygon points=""0 0 24 0 24 24 0 24"" />
                                        <path d=""M5.85714286,2 L13.7364114,2 C14.0910962,2 14.4343066,2.12568431 14.7051108,2.35473959 L19.4686994,6.3839416 C19.8056532,6.66894833 20,7.08787823 20,7.52920201 L20,20.0833333 C20,21.8738751 19.9795521,22 18.1428571,22 L5.85714286,2");
            WriteLiteral(@"2 C4.02044787,22 4,21.8738751 4,20.0833333 L4,3.91666667 C4,2.12612489 4.02044787,2 5.85714286,2 Z"" fill=""#000000"" fill-rule=""nonzero"" opacity=""0.3"" />
                                        <path d=""M11,14 L9,14 C8.44771525,14 8,13.5522847 8,13 C8,12.4477153 8.44771525,12 9,12 L11,12 L11,10 C11,9.44771525 11.4477153,9 12,9 C12.5522847,9 13,9.44771525 13,10 L13,12 L15,12 C15.5522847,12 16,12.4477153 16,13 C16,13.5522847 15.5522847,14 15,14 L13,14 L13,16 C13,16.5522847 12.5522847,17 12,17 C11.4477153,17 11,16.5522847 11,16 L11,14 Z"" fill=""#000000"" />
                                    </g>
                                </svg>                            <!--<i class=""flaticon2-plus""></i>-->
                            </a>
                            <div class=""dropdown-menu dropdown-menu-fit dropdown-menu-md dropdown-menu-right"">
                                <!--begin::Nav-->
                                <ul class=""kt-nav"">
                                    <li class=""kt-nav__head"">
     ");
            WriteLiteral(@"                                   Add New:
                                        <i class=""flaticon2-information"" data-toggle=""kt-tooltip"" data-placement=""right"" title=""Click to learn more...""></i>
                                    </li>
                                    <li class=""kt-nav__separator""></li>450 Total
                                    <li class=""kt-nav__item"">
                                        <a href=""#"" class=""kt-nav__link"">
                                            <i class=""kt-nav__link-icon flaticon2-drop""></i>
                                            <span class=""kt-nav__link-text"">Orders</span>
                                        </a>
                                    </li>
                                    <li class=""kt-nav__item"">
                                        <a href=""#"" class=""kt-nav__link"">
                                            <i class=""kt-nav__link-icon flaticon2-new-email""></i>
                                            <sp");
            WriteLiteral(@"an class=""kt-nav__link-text"">Members</span>
                                            <span class=""kt-nav__link-badge"">
                                                <span class=""kt-badge kt-badge--brand kt-badge--rounded"">15</span>
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""kt-nav__item"">
                                        <a href=""#"" class=""kt-nav__link"">
                                            <i class=""kt-nav__link-icon flaticon2-calendar-8""></i>
                                            <span class=""kt-nav__link-text"">Reports</span>
                                        </a>
                                    </li>
                                    <li class=""kt-nav__item"">
                                        <a href=""#"" class=""kt-nav__link"">
                                            <i class=""kt-nav__link-icon flaticon2-lin");
            WriteLiteral(@"k""></i>
                                            <span class=""kt-nav__link-text"">Finance</span>
                                        </a>
                                    </li>
                                    <li class=""kt-nav__separator""></li>
                                    <li class=""kt-nav__foot"">
                                        <a class=""btn btn-label-brand btn-bold btn-sm"" href=""#"">More options</a>
                                        <a class=""btn btn-clean btn-bold btn-sm kt-hidden"" href=""#"" data-toggle=""kt-tooltip"" data-placement=""right"" title=""Click to learn more..."">Learn more</a>
                                    </li>
                                </ul>
                                <!--end::Nav-->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- end:: Content Head -->
        <!-- begin:: Content -->
        <div class=""kt-containe");
            WriteLiteral(@"r  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
            <!--begin::Portlet-->
            <div class=""kt-portlet kt-portlet--mobile"">
                <div class=""kt-portlet__body kt-portlet__body--fit"">
                    <!--begin: Datatable -->
                    <div class=""kt-datatable kt-datatable--default kt-datatable--brand kt-datatable--loaded"" id=""kt_apps_user_list_datatable"" style="""">

                        <table class=""kt-datatable__table"" style=""display: block;"">
                            <thead class=""kt-datatable__head"">
                                <tr class=""kt-datatable__row"" style=""left: 0px;"">                                    
                                    <th data-field=""AgentName"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                        <span style=""width: 200px;"">User</span>
                                    </th>
                                    <th data-field=""Country"" class=""kt-datatable__cell kt-");
            WriteLiteral(@"datatable__cell--sort"">
                                        <span style=""width: 181px;"">EmailID</span>
                                    </th>
                                    <th data-field=""ShipDate"" class=""kt-datatable__cell kt-datatable__cell--sort"">
                                        <span style=""width: 181px;"">Phone</span>
                                    </th>
                                   
                                </tr>
                            </thead>
                            <tbody class=""kt-datatable__body"" style="""">
                                <!--ko if:$root.UserDetailGrid!= null-->
                                <!-- ko foreach:$root.UserDetailGrid -->
                                <tr data-row=""0"" class=""kt-datatable__row"" style=""left: 0px;"">                                    
                                    <td class=""kt-datatable__cell"">
                                        <span style=""width: 200px;"">
                         ");
            WriteLiteral(@"                   <div class=""kt-user-card-v2"">
                                                <div class=""kt-user-card-v2__details"">
                                                    <span class=""kt-user-card-v2__desc"" data-bind=""text:firstName() + ' ' + lastName()""></span>
                                                </div>
                                            </div>
                                        </span>
                                    </td>
                                    <td class=""kt-datatable__cell"">
                                        <span style=""width: 181px;"" data-bind=""text:emailID""></span>
                                    </td>
                                    <td class=""kt-datatable__cell"">
                                        <span style=""width: 181px;"" data-bind=""text:phone""></span>
                                    </td>                                 
                                </tr>
                                <!--/ko-->
            WriteLiteral(@"
                                <!--/ko-->
                            </tbody>
                            <tfoot>
                                <!--ko if:UserDetailGrid()==null || UserDetailGrid().length==0-->
                                    <tr>
                                        <td colspan=""6"">
                                            <div class=""alert alert-info"">
                                                <button type=""button"" class=""close"" data-dismiss=""alert"">
                                                    &times;
                                                </button>
                                                No Result Found.
                                            </div>
                                        </td>
                                    </tr>
                                    <!-- /ko -->
                            </tfoot>
                        </table>


                        <div class=""kt-datatable__pager kt-datatable");
            WriteLiteral("--paging-loaded\">\r\n                                ");
            EndContext();
            BeginContext(16339, 56, false);
#line 226 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml"
                           Write(await Html.PartialAsync("~/Views/Shared/_Paging.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(16395, 1913, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <!--end: Datatable -->
                </div>
            </div>
            <!--end::Portlet-->
            <!--begin::Modal-->
            <div class=""modal fade"" id=""kt_datatable_records_fetch_modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"">Selected Records</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true""></span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <div class=""kt-scroll ps"" data-scroll=""true"" da");
            WriteLiteral(@"ta-height=""200"" style=""height: 200px; overflow: hidden;"">
                                <ul id=""kt_apps_user_fetch_records_selected""></ul>
                                <div class=""ps__rail-x"" style=""left: 0px; bottom: 0px;""><div class=""ps__thumb-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps__rail-y"" style=""top: 0px; right: 0px;""><div class=""ps__thumb-y"" tabindex=""0"" style=""top: 0px; height: 0px;""></div></div>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-brand"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--end::Modal-->
        </div>
        <!-- end:: Content -->
        </div>
    </div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(18329, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(18339, 241, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afd4c6b6d347436baf0958d50008fee6", async() => {
                    BeginContext(18430, 141, true);
                    WriteLiteral("\r\n            var _indexViewModel = new IndexViewModel();\r\n            ko.applyBindings(_indexViewModel, $(\"#UserDataDiv\").get(0));\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 261 "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\User\Index.cshtml"
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
                BeginContext(18580, 6, true);
                WriteLiteral("\r\n    ");
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