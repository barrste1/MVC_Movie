#pragma checksum "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33771bdff708f14a9f53feebe9c65ab42ad349f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#line 1 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\_ViewImports.cshtml"
using _08202020_Lab21Lab25;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\_ViewImports.cshtml"
using _08202020_Lab21Lab25.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33771bdff708f14a9f53feebe9c65ab42ad349f", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335ca2432058bf7e8b5f378b8dbe06a8da3ae757", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33771bdff708f14a9f53feebe9c65ab42ad349f3987", async() => {
                WriteLiteral("\r\n        \r\n        Movie Title <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 131, "\"", 151, 1);
#nullable restore
#line 10 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
WriteAttributeValue("", 139, Model.Title, 139, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 10 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
                                                                      Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n       \r\n        Genre: <br /> ");
#nullable restore
#line 13 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
                 Write(Html.ValidationMessageFor(m1 => m1.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        &nbsp;  Horror<input type=""radio"" name=""Genre"" value=""Horror"" /><br />
        &nbsp; Comedy<input type=""radio"" name=""Genre"" value=""Comedy"" /><br />
        &nbsp; Drama<input type=""radio"" name=""Genre"" value=""Drama"" /><br />
        &nbsp; Thriller<input type=""radio"" name=""Genre"" value=""Thriller"" /><br />

        Date Made <input type=""date"" name=""Year""");
                BeginWriteAttribute("value", " value=\"", 649, "\"", 668, 1);
#nullable restore
#line 19 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
WriteAttributeValue("", 657, Model.Year, 657, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 19 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
                                                                   Write(Html.ValidationMessageFor(m2 => m2.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        \r\n        Actors <input type=\"text\" name=\"Actors\"");
                BeginWriteAttribute("value", " value=\"", 780, "\"", 801, 1);
#nullable restore
#line 21 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
WriteAttributeValue("", 788, Model.Actors, 788, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n \r\n        Directors <input type=\"text\" name=\"Director\"");
                BeginWriteAttribute("value", " value=\"", 868, "\"", 892, 1);
#nullable restore
#line 23 "C:\Users\Stephen Barr (Work)\source\repos\08202020_Lab21Lab25\Views\Home\Registration.cshtml"
WriteAttributeValue("", 876, Model.Directors, 876, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n        <input type=\"submit\" value=\"Register new movie!\" />\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
