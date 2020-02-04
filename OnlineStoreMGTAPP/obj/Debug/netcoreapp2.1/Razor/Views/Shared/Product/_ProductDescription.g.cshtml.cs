#pragma checksum "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\Shared\Product\_ProductDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "103505b3b3baa517ecf93e773e7e1636cb8c5409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Product__ProductDescription), @"mvc.1.0.view", @"/Views/Shared/Product/_ProductDescription.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Product/_ProductDescription.cshtml", typeof(AspNetCore.Views_Shared_Product__ProductDescription))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103505b3b3baa517ecf93e773e7e1636cb8c5409", @"/Views/Shared/Product/_ProductDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbd3f0bc60dd8c61db6ef2a7fa00b3c7f3d2b60", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Product__ProductDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6508, true);
            WriteLiteral(@"<div id=""divProductDescription"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-auto"">
                    <div class=""form-group"">
                        <label>&nbsp;</label>
                        <button type=""button"" class=""btn btn-primary"" data-target=""#kt_modal_3"" data-toggle=""modal"" style=""display:block;"">Add</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <table class=""table table-bordered table-hover"">
        <thead class=""thead-light"">
            <tr>
                <th data-bind=""text: HeadingName""></th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <select class=""form-control"" id=""hdSpecHeadingID"" data-bind=""options: AllSpecHeadingDropDown, optionsText: 'specHeadingTitle', optionsValue: 'specHeadingID',optionsCaption: 'Select ");
            WriteLiteral(@"Heading', value: selectedHeading""></select>
                </td>
                <td>
                    <input type=""hidden"" id=""hdSpecHeadingID"" />
                    <input type=""text"" class=""form-control kt-font-bold"" id=""txtSubHeading"" placeholder=""Enter Specification 1"">
                </td>
                <td>
                    
                    <input type=""hidden"" id=""hdProductSpecSubHeadingID"" />
                    <input type=""text"" class=""form-control"" id=""txtSubHeadingDescritption"" placeholder=""Enter Specification Value 1"">
                </td>
            </tr>
        </tbody>
    </table>

    <div class=""row"">
        <div class=""col-md-12"">
            <button type=""button"" class=""btn btn-dark"" data-toggle=""modal"" style=""width:100%;"" data-bind=""click:SaveProductDescriptionSubHeading""><i class=""fa fa-sm fa-plus""></i>Add New Specification</button>
        </div>
    </div>
    </br>
    <table class=""table table-bordered table-hover"">
        <thead class=""the");
            WriteLiteral(@"ad-light"">
            <tr>
                <th>SubHeading</th>
                <th>SubHeadingDescritption</th>
                <th>SpecificationHeading</th>
                <th> Actions</th>
            </tr>
        </thead>
        <!--ko if:ProductHeadingSubDescData!= null-->
        <!-- ko foreach:ProductHeadingSubDescData-->
        <tbody>
            <tr>
                <td>
                    <span data-bind=""text:SubHeading"" />
                    <input type=""hidden"" data-bind=""text:ProductSpecSubHeadingID"" />
                </td>
                <td>
                    <span data-bind=""text:SubHeadingDescritption"" />
                </td>
                <td>                    
                    <input type=""hidden"" data-bind=""text:SpecHeadingID"" />
                    <span data-bind=""text:ProductSpecHeadingTitle"" />
                </td>
                <td>
                    <button type=""button"" class=""btn btn-warning""  data-bind=""click:$root.EditSubDescItem"">");
            WriteLiteral(@"Edit</button>
                    <button type=""button"" class=""btn btn-danger"" data-bind=""click:$root.DeleteSubDesc"" >Remove</button>
                </td>
            </tr>
        </tbody>

        <!--/ko-->
        <!--/ko-->
    </table>


    <div class=""modal fade"" id=""kt_modal_3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Add New Product Heading</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <div class=""form-group"">
                                <label>Heading</label>
                                <input t");
            WriteLiteral(@"ype=""text"" class=""form-control"" id=""txtSpecHeadingTitle"" placeholder=""Enter Heading"">
                                <input type=""hidden"" id=""hdSpecHeadingID"" />
                            </div>
                        </div>
                        <div class=""col-md-auto"">
                            <div class=""form-group"">
                                <label>&nbsp;</label>
                                <button style=""display:block;"" data-bind=""click:SaveProductDescription"" type=""button"" class=""btn btn-success"">Save</button>
                            </div>
                        </div>
                    </div>
                    <table class=""table table-bordered"">
                        <!--ko if:ProductHeadingData!= null-->
                        <!-- ko foreach:ProductHeadingData -->
                        <tbody>
                            <tr>
                                <td style=""display:none"">
                                    <input type=""hidden"" id=""objSp");
            WriteLiteral(@"ecHeadingID"" data-bind=""text:SpecHeadingID"" />
                                </td>
                                <td>
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p><span data-bind=""text:SpecHeadingTitle"" /></p>
                                        </div>
                                        <div class=""col-md-auto"">
                                            <button type=""button"" class=""btn btn-warning"" data-bind=""click:$root.EditSpecHeading"">Edit</button>
                                            <button type=""button"" class=""btn btn-danger"" data-bind=""click:$root.DeleteSpecHeading"">Remove</button>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                        <!--/ko-->
                        <!--/ko-->
          ");
            WriteLiteral(@"          </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
