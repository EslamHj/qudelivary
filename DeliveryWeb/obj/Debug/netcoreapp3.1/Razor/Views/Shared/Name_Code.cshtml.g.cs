#pragma checksum "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0aff6f8727418368d18286e9dd71ee88c9c26c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Name_Code), @"mvc.1.0.view", @"/Views/Shared/Name_Code.cshtml")]
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
#line 1 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\_ViewImports.cshtml"
using DeliveryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\_ViewImports.cshtml"
using DeliveryWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\_ViewImports.cshtml"
using DeliveryWeb.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
using DeliveryWeb.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0aff6f8727418368d18286e9dd71ee88c9c26c1", @"/Views/Shared/Name_Code.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8893afc77a53546479bf611519519f7775643042", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Name_Code : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li><p class=\"name\" style=\" margin-bottom: -2rem; font-family: \'Changa\', sans-serif; color:#fff ;font-size: 16px;\">");
#nullable restore
#line 8 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
                                                                                                                       Write(Db.Customers.SingleOrDefault(item => item.UserName == User.Identity.Name).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\n         <li><p class=\"code\" style=\" margin-bottom: 3rem; font-family: \'Changa\', sans-serif; border-bottom: 1px solid #e5e3e3; color:#fff ;font-size: 16px;\">");
#nullable restore
#line 9 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
                                                                                                                                                        Write(Db.Customers.SingleOrDefault(item => item.UserName == User.Identity.Name).Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li> \n");
#nullable restore
#line 10 "C:\Users\Eslam\Downloads\deliverweb-main\deliverweb-main\DeliveryWeb\Views\Shared\Name_Code.cshtml"
    }                           

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext Db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
