#pragma checksum "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\CustoemrProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ddcb7c2ac16a263e19ff035393b3ebe47356175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_CustoemrProfile_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/CustoemrProfile/Index.cshtml")]
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
#line 1 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\_ViewImports.cshtml"
using DeliveryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\_ViewImports.cshtml"
using DeliveryWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\_ViewImports.cshtml"
using DeliveryWeb.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\_ViewImports.cshtml"
using DeliveryWeb.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ddcb7c2ac16a263e19ff035393b3ebe47356175", @"/Areas/Customer/Views/CustoemrProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03fb70f3b0477ab48df793478ff44cf7292234e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_CustoemrProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Areas\Customer\Views\CustoemrProfile\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<form class="" WhiteBacground font"" dir=""rtl""  method=""post"">
    <div class=""row"">
        <div class=""col-6 text-right"">
            <br />
            <h3 class=""text-info"">اضافة طرد</h3>
            <br />

        </div>
    </div>

    <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>-->
");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px"">
        <div id=""di"" class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Code"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Code"" />
        </div>
    </div>-->

");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px;"">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Name"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Name"" />
            <span class=""text-danger"" data-valmsg-replace=""true"" asp-validation-for=""Name""></span>
        </div>
    </div>-->

");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px; "">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Email"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">-->
");
            WriteLiteral("            <!--<input class=\"text form-control\" asp-for=\"Email\" />\n            <span class=\"text-danger\" asp-validation-for=\"Email\"></span>\n        </div>\n    </div>-->\n");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px;"">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Phone1"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Phone1"" />
            <span class=""text-danger"" data-valmsg-replace=""true"" asp-validation-for=""Phone1""></span>

        </div>
    </div>-->

");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px; "">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Phone2"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Phone2"" />
        </div>
    </div>-->

");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px; "">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Address"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Address"" />
            <span class=""text-danger"" data-valmsg-replace=""true"" asp-validation-for=""Address""></span>
        </div>
    </div>-->

");
            WriteLiteral(@"    <!--<div class=""row text-right"" style=""padding-right:20px; padding-top:20px; "">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""Password"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""Password"" />
            <span class=""text-danger"" data-valmsg-replace=""true"" asp-validation-for=""Password""></span>
        </div>
    </div>

     ConfirmPassWord 
    <div class=""row text-right"" style=""padding-right:20px; padding-top:20px; "">
        <div class=""col-md-2 col-sm-12 col-lg-2"">
            <label asp-for=""ConfirmPassword"" class=""col-form-label font"" style=""font-size:15px""></label>
        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <input class=""text form-control"" asp-for=""ConfirmPassword"" />
            <span class=""text-danger"" data-valmsg-replace=""true"" asp-validation-for=""Input.ConfirmPassword""></span>
        </div>
   ");
            WriteLiteral(" </div>-->\n\n\n");
            WriteLiteral(@"    <!--<div class=""row"" style=""padding-right:20px; padding-top:20px;"">
        <div class=""col-lg-2 col-md-2"">

        </div>
        <div class=""col-md-5 col-sm-12 col-lg-5"">
            <div class=""row"">
                <div class=""col-6"">
                    <a class=""btn-secondary form-control"" asp-area=""Customer"" asp-controller=""Home"" asp-action=""Index"" style=""text-align:center;"">رجوع</a>
                </div>
                <div class=""col-6"">
                    <input type=""submit"" class=""btn-primary form-control"" value=""تسجيل"" style=""text-align:center;"" />
                    <button type=""submit"" class=""btn btn-primary"">Register</button>

                </div>
            </div>
        </div>
    </div>

</form>-->

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ddcb7c2ac16a263e19ff035393b3ebe473561759717", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
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