#pragma checksum "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6d59b13165a90fd22c52c087748078ff8278ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faculty), @"mvc.1.0.view", @"/Views/Home/Faculty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6d59b13165a90fd22c52c087748078ff8278ef", @"/Views/Home/Faculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Faculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3.ViewModels.FacultyViewModel>
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
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 16 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div id=\"people\" class=\"makeFlex\">\r\n");
#nullable restore
#line 18 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
     foreach (var faculty in Model.Faculty)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card facultyCard\">\r\n            <div class=\"card-header facultyHeader\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                  Write(faculty.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle\">");
#nullable restore
#line 23 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                     Write(faculty.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"facultyImageDiv\">\r\n                <img class=\"card-img-top facultyImage\"");
            BeginWriteAttribute("src", " src=\"", 816, "\"", 840, 1);
#nullable restore
#line 26 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 822, faculty.imagePath, 822, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            </div>\r\n\r\n            <ul class=\"list-group list-group-flush bg-light\">\r\n                <li class=\"list-group-item\">");
#nullable restore
#line 30 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                       Write(faculty.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"");
            BeginWriteAttribute("style", " style=\"", 1058, "\"", 1127, 2);
            WriteAttributeValue("", 1066, "display:", 1066, 8, true);
#nullable restore
#line 31 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue(" ", 1074, validateString(faculty.office) ? "block" : "none", 1075, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                                                                                             Write(faculty.office);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"");
            BeginWriteAttribute("style", " style=\"", 1194, "\"", 1262, 2);
            WriteAttributeValue("", 1202, "display:", 1202, 8, true);
#nullable restore
#line 32 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue(" ", 1210, validateString(faculty.phone) ? "block" : "none", 1211, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                                                                                            Write(faculty.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Departments: ");
#nullable restore
#line 33 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                                    Write(faculty.interestArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <button class=\"btn btn-light researchBtn\"");
            BeginWriteAttribute("style", " style=\"", 1442, "\"", 1540, 2);
            WriteAttributeValue("", 1450, "display:", 1450, 8, true);
#nullable restore
#line 35 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue(" ", 1458, checkForResearch(faculty.username, Model.ResearchByFaculty) ? "block" : "none", 1459, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=", 1541, "", 1577, 1);
#nullable restore
#line 35 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 1545, String.Concat(faculty.username), 1545, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"displayResearch(id)\">See Research</button>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb6d59b13165a90fd22c52c087748078ff8278ef11958", async() => {
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
#line 60 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                         foreach (var quicklink in Model.FooterInfo.quickLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=", 2634, "", 2655, 1);
#nullable restore
#line 62 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 2640, quicklink.href, 2640, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                                                   Write(quicklink.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 63 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
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
            BeginWriteAttribute("href", " href=", 3125, "", 3163, 1);
#nullable restore
#line 72 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 3131, Model.FooterInfo.social.twitter, 3131, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Twitter</a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3212, "\"", 3252, 1);
#nullable restore
#line 73 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
WriteAttributeValue("", 3219, Model.FooterInfo.social.facebook, 3219, 33, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb6d59b13165a90fd22c52c087748078ff8278ef16596", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb6d59b13165a90fd22c52c087748078ff8278ef17640", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb6d59b13165a90fd22c52c087748078ff8278ef18760", async() => {
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
            WriteLiteral("\r\n\r\n    <script>\r\n        var $j = jQuery.noConflict();\r\n        var researchData = ");
#nullable restore
#line 93 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                      Write(Html.Raw(Json.Serialize(Model.ResearchByFaculty)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n        var footInfo = ");
#nullable restore
#line 96 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
                  Write(Html.Raw(Json.Serialize(@Model.FooterInfo)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        $j(""#copyright"").append(footInfo.copyright.html);


        function displayResearch(username) {
            var facultyResearch = researchData.filter(item => item.username == username)[0];
            var elmnt = document.getElementById(username);
            var divContent = ""<div><ul class='list-group list-group-flush bg-'>"";

            $j.each(facultyResearch.citations, function (index, value) {
                divContent += '<li class=""list-group-item citation"" style=""color:#000000"">';
                divContent += value;
                divContent += '</li>';
            });

            divContent += ""</ul></div>"";

            $j(""#dialog"").html(divContent);
            $j(""#dialog"").dialog({
                title: ""Research by "" + facultyResearch.facultyName,
                width: 500,
                position: { my: ""center"", at: ""bottom+40%"", of: elmnt }
            });
            $j(""#dialog"").dialog(""open"");
        }



    </script>
");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\cmpog\Desktop\2020\Fall2020Sem\ClientP\Lecture24_Project3_Continued_1\FinalVersion\RITFacultyV1\Views\Home\Faculty.cshtml"
           
    public bool validateString(String value)
    {
        return value != null && value != "";
    }
    public bool checkForResearch(String username, List<ByFaculty> byfaculties)
    {
        var results = byfaculties.Where(obj => obj.username == username);

        return results.Any();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3.ViewModels.FacultyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591