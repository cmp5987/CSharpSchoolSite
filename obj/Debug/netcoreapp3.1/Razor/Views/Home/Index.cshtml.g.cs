#pragma checksum "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b452b058ba234d721cbaab971f6dfe42d81e1db5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b452b058ba234d721cbaab971f6dfe42d81e1db5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slide_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/RIT_1505C_hor.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Long logo for RIT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div id=\"homepageImage\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b452b058ba234d721cbaab971f6dfe42d81e1db54739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<h2>");
#nullable restore
#line 5 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div id=\"index-content\">\r\n    <div>\r\n        <h3>");
#nullable restore
#line 8 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
       Write(Model.AboutInfo.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
      Write(Model.AboutInfo.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"quote\">\r\n            <p>\"");
#nullable restore
#line 11 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
           Write(Model.AboutInfo.quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n            <h6>");
#nullable restore
#line 12 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
           Write(Model.AboutInfo.quoteAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div id=\"news\">\r\n    <h2>Recent News</h2>\r\n    <div id=\"tweets\"");
            BeginWriteAttribute("class", " class=\"", 486, "\"", 494, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <!-- API request to twitter for twitter data-->
        <a class=""twitter-timeline"" data-tweet-limit=""3"" href=""https://twitter.com/RITNEWS?ref_src=twsrc%5Etfw"">Tweets by RITNEWS</a>
        <script async src=""https://platform.twitter.com/widgets.js"" charset=""utf-8""></script>
    </div>
</div>
<hr />
<footer>
    <div class=""container"">
        <div class=""container-fluid text-center text-md-left"">
            <!-- Grid row -->
            <div class=""row"">

                <!-- Grid column -->
                <div class=""col-md-3 mt-md-0 mt-3"">
                    <!-- Content -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b452b058ba234d721cbaab971f6dfe42d81e1db58261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
#line 46 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
                         foreach (var quicklink in Model.FooterInfo.quickLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=", 1759, "", 1780, 1);
#nullable restore
#line 48 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1765, quicklink.href, 1765, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
                                                   Write(quicklink.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
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
            BeginWriteAttribute("href", " href=", 2250, "", 2288, 1);
#nullable restore
#line 58 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
WriteAttributeValue("", 2256, Model.FooterInfo.social.twitter, 2256, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Twitter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2337, "\"", 2377, 1);
#nullable restore
#line 59 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
WriteAttributeValue("", 2344, Model.FooterInfo.social.facebook, 2344, 33, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b452b058ba234d721cbaab971f6dfe42d81e1db512878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var footInfo = ");
#nullable restore
#line 74 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Index.cshtml"
              Write(Html.Raw(Json.Serialize(@Model.FooterInfo)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    $j(\"#copyright\").append(footInfo.copyright.html);\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591