#pragma checksum "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f37408f8fc78924491ac91d5733172e13cc326e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Degrees), @"mvc.1.0.view", @"/Views/Home/Degrees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f37408f8fc78924491ac91d5733172e13cc326e", @"/Views/Home/Degrees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Degrees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3.ViewModels.DegreeViewModel>
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
            WriteLiteral("\r\n");
            WriteLiteral("<h2>");
#nullable restore
#line 9 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"makeFlex majors-content\">\r\n");
#nullable restore
#line 12 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
     foreach (var under in Model.UnderGrads)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card majorCard\" >\r\n            <div class=\"card-header majorHeader\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
                                  Write(under.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"class-subtitle\">Undergraduate Program</h6>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
               Write(under.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <button class=\"seeConcentrationBtn\"");
            BeginWriteAttribute("id", " id=", 742, "", 778, 1);
#nullable restore
#line 24 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 746, String.Concat(under.degreeName), 746, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"displayUnderGradDialog(id)\">See Concentrations</button>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
     foreach (var graduate in Model.Graduates)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card majorCard\"");
            BeginWriteAttribute("style", " style=\"", 958, "\"", 1030, 2);
            WriteAttributeValue("", 966, "display:", 966, 8, true);
#nullable restore
#line 29 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 974, removeUnwanted(graduate.degreeName) ? "flex" : "none", 974, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-header majorHeader\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 31 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
                                  Write(graduate.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"class-subtitle\">Graduate</h6>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
               Write(graduate.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <button class=\"seeConcentrationBtn\"");
            BeginWriteAttribute("id", "  id=", 1432, "", 1472, 1);
#nullable restore
#line 39 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 1437, String.Concat(graduate.degreeName), 1437, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  onclick=\"displayGradDialog(id)\">See Concentrations</button>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div id=""dialog""></div>
<footer>
    <div class=""container"">
        <div class=""container-fluid text-center text-md-left"">
            <!-- Grid row -->
            <div class=""row"">

                <!-- Grid column -->
                <div class=""col-md-3 mt-md-0 mt-3"">
                    <!-- Content -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f37408f8fc78924491ac91d5733172e13cc326e10846", async() => {
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
#line 64 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
                         foreach (var quicklink in Model.FooterInfo.quickLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=", 2537, "", 2558, 1);
#nullable restore
#line 66 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 2543, quicklink.href, 2543, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
                                                   Write(quicklink.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 67 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
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
            BeginWriteAttribute("href", " href=", 3028, "", 3066, 1);
#nullable restore
#line 76 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 3034, Model.FooterInfo.social.twitter, 3034, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Twitter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3115, "\"", 3155, 1);
#nullable restore
#line 77 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
WriteAttributeValue("", 3122, Model.FooterInfo.social.facebook, 3122, 33, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f37408f8fc78924491ac91d5733172e13cc326e15478", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f37408f8fc78924491ac91d5733172e13cc326e16518", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f37408f8fc78924491ac91d5733172e13cc326e17634", async() => {
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
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var undergradData = ");
#nullable restore
#line 95 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
                   Write(Html.Raw(Json.Serialize(Model.UnderGrads)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var gradData = ");
#nullable restore
#line 96 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
              Write(Html.Raw(Json.Serialize(Model.Graduates)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n    var footInfo = ");
#nullable restore
#line 98 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
              Write(Html.Raw(Json.Serialize(@Model.FooterInfo)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    $j(""#copyright"").append(footInfo.copyright.html);

    function displayGradDialog(degreeName) {
        var grad = gradData.filter(item => item.degreeName == degreeName)[0];
        let elmnt = document.getElementById(degreeName);

        var divContent = ""<div><ul class='list-group list-group-flush bg-'>"";

        $j.each(grad.concentrations, function (index, value) {
            divContent += '<li class=""list-group-item concentration"" style=""color:#000000"">';
            divContent += value;
            divContent += '</li>';
        });

        divContent += ""</ul></div>"";

        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: grad.title,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt }
        });
        $j(""#dialog"").dialog(""open"");
    }
    function displayUnderGradDialog(degreeName) {
        var under = undergradData.filter(item => item.degreeName == degreeName )[0];
        let elmnt =");
            WriteLiteral(@" document.getElementById(degreeName);

        var divContent = ""<div><ul class='list-group list-group-flush bg-'>"";

        $j.each(under.concentrations, function (index, value) {
            divContent += '<li class=""list-group-item concentration"" style=""color:#000000"">';
            divContent += value;
            divContent += '</li>';
        });

        divContent += ""</ul></div>"";

        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: under.title,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt }
        });
        $j(""#dialog"").dialog(""open"");
    }



</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Degrees.cshtml"
           
    public bool removeUnwanted(String value)
    {
        return value != "graduate advanced certificates";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3.ViewModels.DegreeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
