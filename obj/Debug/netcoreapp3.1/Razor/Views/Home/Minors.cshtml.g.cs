#pragma checksum "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d736ec96b81ade12294b78caf2625b21f97aaac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Minors), @"mvc.1.0.view", @"/Views/Home/Minors.cshtml")]
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
#line 1 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\_ViewImports.cshtml"
using Project3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\_ViewImports.cshtml"
using Project3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d736ec96b81ade12294b78caf2625b21f97aaac", @"/Views/Home/Minors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Minors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3.ViewModels.MinorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/RIT_1505C_hor.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Long logo for RIT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryui/themes/ui-darkness/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div id=\"minors\">\r\n    <div id=\"minors-content\">\r\n");
#nullable restore
#line 6 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
         foreach (var minor in Model.Minors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3");
            BeginWriteAttribute("id", " id=\"", 190, "\"", 231, 1);
#nullable restore
#line 8 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
WriteAttributeValue("", 195, String.Concat("myHdng", minor.name), 195, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordian-title\">");
#nullable restore
#line 8 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
                                                                             Write(minor.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 292, "\"", 332, 1);
#nullable restore
#line 9 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
WriteAttributeValue("", 297, String.Concat("myDiv", minor.name), 297, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordian-details\">\r\n                <p class=\"acccordian-para\">");
#nullable restore
#line 10 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
                                      Write(minor.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 12 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<footer>
    <div class=""container"">
        <div class=""container-fluid text-center text-md-left"">
            <!-- Grid row -->
            <div class=""row"">

                <!-- Grid column -->
                <div class=""col-md-3 mt-md-0 mt-3"">
                    <!-- Content -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7d736ec96b81ade12294b78caf2625b21f97aaac8364", async() => {
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
            WriteLiteral(@"
                </div>
                <!-- Grid column -->

                <hr class=""clearfix w-100 d-md-none pb-3"">

                <!-- Grid column -->
                <div class=""col-md-3 mb-md-0 mb-3 d-flex flex-column align-items-center"">
                    <!-- Links -->
                    <h5 class=""text-uppercase"">Helpful Links</h5>
                    <ul class=""list-unstyled"" id=""helpfulLinks"">
");
#nullable restore
#line 35 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
                         foreach (var quicklink in Model.FooterInfo.quickLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=", 1426, "", 1447, 1);
#nullable restore
#line 37 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
WriteAttributeValue("", 1432, quicklink.href, 1432, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
                                                   Write(quicklink.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 38 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-3 mb-md-0 mb-3 d-flex flex-column align-items-center"">
                    <!-- Links -->
                    <h5 class=""text-uppercase"">Social Media</h5>
                    <ul class=""list-unstyled"" id=""socialMedia"">
                        <li><a");
            BeginWriteAttribute("href", " href=", 1917, "", 1955, 1);
#nullable restore
#line 47 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
WriteAttributeValue("", 1923, Model.FooterInfo.social.twitter, 1923, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Twitter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2004, "\"", 2044, 1);
#nullable restore
#line 48 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
WriteAttributeValue("", 2011, Model.FooterInfo.social.facebook, 2011, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Facebook</a></li>
                    </ul>
                </div>
                <!-- Grid column -->
            </div>
            <!-- Grid row -->
        </div>
        <!-- Footer Links -->
        <!-- Copyright -->
        <div class=""footer-copyright text-center py-3"" id=""copyright""></div>
    </div>
</footer>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d736ec96b81ade12294b78caf2625b21f97aaac12989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7d736ec96b81ade12294b78caf2625b21f97aaac14029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d736ec96b81ade12294b78caf2625b21f97aaac15145", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var footInfo = ");
#nullable restore
#line 67 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Minors.cshtml"
              Write(Html.Raw(Json.Serialize(@Model.FooterInfo)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    $j(\"#copyright\").append(footInfo.copyright.html);\r\n\r\n    $(\'#minors-content\').accordion({\r\n        collapsible: true,\r\n        active: false,\r\n        heightStyle: \"content\"\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3.ViewModels.MinorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591