#pragma checksum "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4615fde05371589e206c71895c7f8a4b81e71a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\_ViewImports.cshtml"
using Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\_ViewImports.cshtml"
using Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4615fde05371589e206c71895c7f8a4b81e71a4f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435aa32aad823447c9e0ea38ebe6900b1f2e978f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proje.Models.YemekDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4615fde05371589e206c71895c7f8a4b81e71a4f5695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 24 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
  
    string culture = "", uiculture = "";
    if (Context.Request.QueryString.HasValue)
    {
        string url = Context.Request.QueryString.Value;
        culture = Context.Request.Query["culture"];
        uiculture = Context.Request.Query["ui-culture"];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 38 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 1121, "\"", 1190, 1);
#nullable restore
#line 40 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
WriteAttributeValue("", 1129, item.YemekId==1 ? "carousel-item active" : "carousel-item", 1129, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4615fde05371589e206c71895c7f8a4b81e71a4f8521", async() => {
                WriteLiteral("\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 1314, "\"", 1331, 1);
#nullable restore
#line 42 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
WriteAttributeValue("", 1320, item.Resim, 1320, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-block w-100 h-100\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                   WriteLiteral(item.KategoriAdi);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                                                                       WriteLiteral(item.YemekId);

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
            WriteLiteral("\r\n\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<h1 class=""my-4"">");
#nullable restore
#line 59 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
            Write(Localizer["hosgeldiniz"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !</h1>\r\n\r\n<!-- Marketing Icons Section -->\r\n<div class=\"row\">\r\n");
#nullable restore
#line 63 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4 mb-4\">\r\n            <div class=\"card h-100\">\r\n                <h4 class=\"card-header\">");
#nullable restore
#line 67 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                                   Write(item.YemekBaslıgı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <div class=\"card-body\">\r\n                    <a href=\"#\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2298, "\"", 2315, 1);
#nullable restore
#line 70 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
WriteAttributeValue("", 2304, item.Resim, 2304, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 h-200\">\r\n                    </a>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4615fde05371589e206c71895c7f8a4b81e71a4f14029", async() => {
#nullable restore
#line 74 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                                                                                                                           Write(Localizer["daha"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                           WriteLiteral(item.KategoriAdi);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
                                                                               WriteLiteral(item.YemekId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 78 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


</div>
<script>
    function SetCulture(selectedValue) {
        alert(selectedValue);
        var url = window.location.href.split('?')[0];
        var culture = ""?culture="" + selectedValue + ""&ui-culture="" + selectedValue;
        window.location.href = url + culture;
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proje.Models.YemekDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
