#pragma checksum "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552e68351cdd34e9f61581f9c75df965f6492f7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Nova pasta\sistemacontrole\Pratice\Views\_ViewImports.cshtml"
using Pratice;

#line default
#line hidden
#line 2 "C:\Nova pasta\sistemacontrole\Pratice\Views\_ViewImports.cshtml"
using Pratice.Models;

#line default
#line hidden
#line 1 "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552e68351cdd34e9f61581f9c75df965f6492f7d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf4b0dce28e28c255240b1abf392976bb8f8803", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml"
  
    var x = Context.Session.GetString("SessionUser");


#line default
#line hidden
            BeginContext(100, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(164, 873, true);
            WriteLiteral(@"


    <div id=""content"">

        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <div class=""container-fluid"">

                <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info"">
                    <i class=""fas fa-align-left""></i>
                    <span>Menu</span>
                </button>
                <button class=""btn btn-dark d-inline-block d-lg-none ml-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <i class=""fas fa-align-justify""></i>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""nav navbar-nav ml-auto"">

                        <li class=""nav-item"">
");
            EndContext();
#line 35 "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml"
                             using (Html.BeginForm("Logout", "Login", FormMethod.Post))
                            {

#line default
#line hidden
            BeginContext(1157, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1189, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e448057acc714b81bef7c389cef16377", async() => {
                BeginContext(1195, 131, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-dark\" value=\"Logout\" />\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Nova pasta\sistemacontrole\Pratice\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1366, 120, true);
            WriteLiteral("                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n\r\n");
            EndContext();
            BeginContext(1621, 101, true);
            WriteLiteral("        \r\n            <div class=\"panel panel-info\">Cadastro de Cliente</div>\r\n        \r\n            ");
            EndContext();
            BeginContext(1722, 3669, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "214c0b4f68b940d0a699dfac9a609979", async() => {
                BeginContext(1764, 3620, true);
                WriteLiteral(@"
                <div class=""form-row"">
                    <div class=""col-md-4 mb-3"">
                        <label for=""validationCustom01"">First name</label>
                        <input type=""text"" class=""form-control"" id=""validationCustom01"" placeholder=""First name"" value=""Mark"" required>
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                    </div>
                    <div class=""col-md-4 mb-3"">
                        <label for=""validationCustom02"">Last name</label>
                        <input type=""text"" class=""form-control"" id=""validationCustom02"" placeholder=""Last name"" value=""Otto"" required>
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                    </div>
                    <div class=""col-md-4 mb-3"">
                        <label for=""validationCustomUsername"">Username</label>
                     ");
                WriteLiteral(@"   <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""inputGroupPrepend""></span>
                            </div>
                            <input type=""text"" class=""form-control"" id=""validationCustomUsername"" placeholder=""Username"" aria-describedby=""inputGroupPrepend"" required>
                            <div class=""invalid-feedback"">
                                Please choose a username.
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""col-md-6 mb-3"">
                        <label for=""validationCustom03"">City</label>
                        <input type=""text"" class=""form-control"" id=""validationCustom03"" placeholder=""City"" required>
                        <div class=""invalid-feedback"">
                            Please provide a valid city.
 ");
                WriteLiteral(@"                       </div>
                    </div>
                    <div class=""col-md-3 mb-3"">
                        <label for=""validationCustom04"">State</label>
                        <input type=""text"" class=""form-control"" id=""validationCustom04"" placeholder=""State"" required>
                        <div class=""invalid-feedback"">
                            Please provide a valid state.
                        </div>
                    </div>
                    <div class=""col-md-3 mb-3"">
                        <label for=""validationCustom05"">Zip</label>
                        <input type=""text"" class=""form-control"" id=""validationCustom05"" placeholder=""Zip"" required>
                        <div class=""invalid-feedback"">
                            Please provide a valid zip.
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-check"">
                        <input ");
                WriteLiteral(@"class=""form-check-input"" type=""checkbox"" value="""" id=""invalidCheck"" required>
                        <label class=""form-check-label"" for=""invalidCheck"">
                            Agree to terms and conditions
                        </label>
                        <div class=""invalid-feedback"">
                            You must agree before submitting.
                        </div>
                    </div>
                </div>
                <button class=""btn btn-primary"" type=""submit"">Submit form</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5391, 38, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(5429, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d3a66ecfb4c40cc986e1ea0cecbf30a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5467, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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