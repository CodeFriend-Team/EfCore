#pragma checksum "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54cd868245333baf20afe0d1749ceac80d0f5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_details), @"mvc.1.0.view", @"/Views/Home/details.cshtml")]
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
#line 1 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\_ViewImports.cshtml"
using EfCore_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\_ViewImports.cshtml"
using EfCore_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54cd868245333baf20afe0d1749ceac80d0f5c5", @"/Views/Home/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9440469d5e30bd1fac8242bd900fd86c1184e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EfCore_Project.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
  
    ViewData["Title"] = "details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.IsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\EntityFrameWorkCore\EfCore_Project\Views\Home\details.cshtml"
       Write(Html.DisplayFor(model => model.ProductCategory.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EfCore_Project.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
