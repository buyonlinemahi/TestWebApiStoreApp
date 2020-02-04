#pragma checksum "D:\Mahi_TFS\Store (To Be Named After)\Web\MGT\OnlineStoreMGTAPP\Views\Shared\_Paging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152173092f06bb14724126591d9ff566335de504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Paging), @"mvc.1.0.view", @"/Views/Shared/_Paging.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Paging.cshtml", typeof(AspNetCore.Views_Shared__Paging))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152173092f06bb14724126591d9ff566335de504", @"/Views/Shared/_Paging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbd3f0bc60dd8c61db6ef2a7fa00b3c7f3d2b60", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Paging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(118, 3571, true);
            WriteLiteral(@"<!-- ko if:Pager().TotalItemCount() > 0 -->
<div class=""pagination-1"" data-bind=""with: Pager"">

    <div class=""row"">
        <div class=""col"">
            <ul class=""pagination"">
                <!-- ko if:CurrentPage() === 1 -->
                <li class=""disabled"">
                    <a href=""#"" class=""disabledPage"">&laquo;&laquo;</a>
                </li>
                <!-- /ko -->
                <!-- ko ifnot:CurrentPage() === 1 -->
                <li>
                    <a href=""#"" data-bind=""click: function(){ CurrentPage(1); }"">&laquo;&laquo;</a>
                </li>
                <!-- /ko -->
                <!-- ko if:HasPrevPage -->
                <li>
                    <a href=""#"" data-bind=""click: function(){ CurrentPage(CurrentPage() - 1); }"">&laquo;</a>
                </li>
                <!-- /ko -->
                <!-- ko ifnot:HasPrevPage -->
                <li class=""disabled"">
                    <a href=""#"" class=""disabledPage"">&laquo;</a>
         ");
            WriteLiteral(@"       </li>
                <!-- /ko -->
                <!-- ko foreach:Pages -->
                <!-- ko if:$data === $parent.CurrentPage() -->
                <li class=""active"">
                    <span class=""currentPage red-pagging"" data-bind=""text: $data""></span>
                </li>
                <!-- /ko -->
                <!-- ko if:$data !== $parent.CurrentPage() -->
                <li>
                    <a href=""#"" data-bind=""text: $data, click: function(){ $parent.CurrentPage($data); }""></a>
                </li>
                <!-- /ko -->
                <!-- /ko -->
                <!-- ko if:HasNextPage -->
                <li>
                    <a href=""#"" data-bind=""click: function(){ CurrentPage(CurrentPage() + 1); }"">&raquo;</a>
                </li>
                <!-- /ko -->
                <!-- ko ifnot:HasNextPage -->
                <li class=""disabled"">
                    <a href=""#"" class=""disabledPage"">&raquo;</a>
                </li>
       ");
            WriteLiteral(@"         <!-- /ko -->
                <!-- ko ifnot:CurrentPage() === LastPage() -->
                <li>
                    <a href=""#"" data-bind=""click: function(){ CurrentPage(LastPage()); }"">&raquo;&raquo;</a>
                </li>
                <!-- /ko -->
                <!-- ko if:CurrentPage() === LastPage() -->
                <li class=""disabled"">
                    <a href=""#"" class=""disabledPage"">&raquo;&raquo;</a>
                </li>
                <!-- /ko -->
            </ul>
        </div>
        <div class=""col-md-auto"">
            <div class=""pagexofx"">
                <span data-bind=""text:FirstItemIndex""></span>
                -
                <span data-bind=""text: LastItemIndex""></span>
                of
                <strong>
                    <span data-bind=""text: TotalItemCount""></span>
                </strong>
                total results.
            </div>
        </div>
    </div>
    
    
</div>
<style>
    ul.pagination li {
 ");
            WriteLiteral(@"       padding: 0px 1px;
    }
    ul.pagination li.active span {
        background: #5d78ff;
        color: #fff;
        padding: 5px 13px;
        border-radius: 3px;
    }
    ul.pagination li.disabled {
        opacity:0.5;
    }
    ul.pagination li a {
        padding: 5px 10px;
        border-radius: 3px;
    }
    ul.pagination li a:hover {
        background: #5d78ff;
        color: #fff;
    }
    .pagination-1 {
        width:100%;
    }
</style>
<!-- /ko -->");
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
