#pragma checksum "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c3516537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorCountry.Pages.Continents.Pages_Continents_Detail), @"mvc.1.0.razor-page", @"/Pages/Continents/Detail.cshtml")]
namespace RazorCountry.Pages.Continents
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c3516537", @"/Pages/Continents/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5a5bdad389479b918ac04dcbdee8d1fcda8733360343bbe590ea215eb3254c89", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Continents_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Countries/Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Countries/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Countries/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
  
    ViewData["Title"] = "Continent Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-3\">\r\n    <div class=\"d-flex align-items-center\">\r\n        <h1 class=\"display-4 flex-grow-1\">\r\n            Continent Detail\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c35165375707", async() => {
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
#line 20 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-top border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Continent.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex\">\r\n    <div class=\"p-2 bg-primary text-white text-right\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 28 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2 border-right border-bottom border-primary\" style=\"flex:1 0 auto\">\r\n        ");
#nullable restore
#line 31 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayFor(model => model.Continent.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"d-flex bg-success text-white mt-3\">\r\n    <div class=\"p-2\" style=\"flex:0 0 10%\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Countries.FirstOrDefault().ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2\" style=\"flex:0 0 10%\">\r\n        ");
#nullable restore
#line 40 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Countries.FirstOrDefault().ContinentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2\" style=\"flex:0 0 20%\">\r\n        ");
#nullable restore
#line 43 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Countries.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2\" style=\"flex:0 0 15%\">\r\n        ");
#nullable restore
#line 46 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Countries.FirstOrDefault().Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2\" style=\"flex:0 0 20%\">\r\n        ");
#nullable restore
#line 49 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
   Write(Html.DisplayNameFor(model => model.Continent.Countries.FirstOrDefault().UnitedNationsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"p-2\" style=\"flex:0 0 25%\">Options</div>\r\n</div>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
 foreach (var item in Model.Continent.Countries)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex border-left border-right border-bottom border-success\">\r\n        <div class=\"p-2\" style=\"flex:0 0 10%\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"p-2\" style=\"flex:0 0 10%\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
       Write(Html.DisplayFor(modelItem => item.ContinentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"p-2\" style=\"flex:0 0 20%\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"p-2\" style=\"flex:0 0 15%\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
       Write(Html.DisplayFor(modelItem => item.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"p-2\" style=\"flex:0 0 20%\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
       Write(Html.DisplayFor(modelItem => item.UnitedNationsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"p-2 btn-group\" style=\"flex:0 0 25%\" role=\"group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c351653713323", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
                                                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c351653715674", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
                                                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75544c811d379bd3404deda2b07b7504d00b4733ac3de82ee55cce80c351653718020", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
                                                                            WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 78 "C:\Users\Adafish\Documents\03 -Learnings\Codecademy\Codecademy_Learning_Projects\RazorCountry\Pages\Continents\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
