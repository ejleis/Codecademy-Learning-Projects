#pragma checksum "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "777e0dbdda25777252b5761ec427d39051a6153bc8f7998c944a9a40defd5194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorCountry.Pages.Countries.Pages_Countries_Detail), @"mvc.1.0.razor-page", @"/Pages/Countries/Detail.cshtml")]
namespace RazorCountry.Pages.Countries
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\_ViewImports.cshtml"
using RazorCountry;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"777e0dbdda25777252b5761ec427d39051a6153bc8f7998c944a9a40defd5194", @"/Pages/Countries/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5a5bdad389479b918ac04dcbdee8d1fcda8733360343bbe590ea215eb3254c89", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Countries_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
  
    ViewData["Title"] = "Country Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-3\">\r\n    <div class=\"d-flex align-items-center\">\r\n        <h1 class=\"display-4 flex-grow-1\">\r\n            Country Detail\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777e0dbdda25777252b5761ec427d39051a6153bc8f7998c944a9a40defd51944406", async() => {
                WriteLiteral("\r\n            Back to List\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 20 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.CountryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-top border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.CountryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 28 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.ContinentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 31 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.ContinentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 36 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 39 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 44 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 47 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 52 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 55 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 60 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.UnitedNationsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 63 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.UnitedNationsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 68 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Country.Density));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 71 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Countries\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Country.Density));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel>)PageContext?.ViewData;
        public DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
