#pragma checksum "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78982cd7602e888ecd3aa9cb307a87f6a91a66db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnaYemekler_Index), @"mvc.1.0.view", @"/Views/AnaYemekler/Index.cshtml")]
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
#line 5 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78982cd7602e888ecd3aa9cb307a87f6a91a66db", @"/Views/AnaYemekler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435aa32aad823447c9e0ea38ebe6900b1f2e978f", @"/Views/_ViewImports.cshtml")]
    public class Views_AnaYemekler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proje.Models.YemekDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnaYemekler", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
  
    //ViewData["Title"] = "AnaYemekler";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78982cd7602e888ecd3aa9cb307a87f6a91a66db6654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 23 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
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
#line 24 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
  
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
            WriteLiteral("<div class=\"container\">\r\n\r\n    <h1 class=\"mt-4 mb-3\">\r\n        ");
#nullable restore
#line 36 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
   Write(Localizer["ana"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78982cd7602e888ecd3aa9cb307a87f6a91a66db9100", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 43 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                      Write(Localizer["ana"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n\r\n\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 48 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-4\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-6\">\r\n                            <a href=\"#\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1590, "\"", 1607, 1);
#nullable restore
#line 56 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
WriteAttributeValue("", 1596, item.Resim, 1596, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 h-200\">\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                            <h2 class=\"card-title\">");
#nullable restore
#line 60 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                              Write(item.YemekBaslıgı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>Malzemeler:</p>\r\n                            <p class=\"card-text\"><ul>");
#nullable restore
#line 62 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                                Write(Html.Raw(@item.Malzemeler));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul></p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78982cd7602e888ecd3aa9cb307a87f6a91a66db12572", async() => {
#nullable restore
#line 63 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                                                                                                               Write(Localizer["daha"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &rarr;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                                                                 WriteLiteral(item.YemekId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
               Write(item.YuklemeTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 72 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <ul class=\"pagination justify-content-center mb-4\">\r\n        <li class=\"page-item\">\r\n            <a class=\"page-link\" href=\"#\">&larr;");
#nullable restore
#line 77 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                           Write(Localizer["eski"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"page-item disabled\">\r\n            <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 80 "C:\Users\busra\Desktop\Proje\Proje\Proje\Views\AnaYemekler\Index.cshtml"
                                     Write(Localizer["yeni"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" &rarr;</a>
        </li>
    </ul>

</div>
<script>
    function SetCulture(selectedValue) {
        alert(selectedValue);
        var url = window.location.href.split('?')[0];
        var culture = ""?culture="" + selectedValue + ""&ui-culture="" + selectedValue;
        window.location.href = url + culture;
    }
</script>
");
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