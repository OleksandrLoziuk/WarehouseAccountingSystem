#pragma checksum "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f30278343380eff135af60a919d8506a92460d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balance_Index), @"mvc.1.0.view", @"/Views/Balance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Balance/Index.cshtml", typeof(AspNetCore.Views_Balance_Index))]
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
#line 1 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\_ViewImports.cshtml"
using WarehouseAccountingSystem;

#line default
#line hidden
#line 2 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\_ViewImports.cshtml"
using WarehouseAccountingSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f30278343380eff135af60a919d8506a92460d04", @"/Views/Balance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345c80a2a6abd29de60587b21e184dd41aab9e29", @"/Views/_ViewImports.cshtml")]
    public class Views_Balance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WarehouseAccountingSystem.Entities.Balance>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(107, 108, true);
            WriteLiteral("\r\n<h1>Balance</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(216, 55, false);
#line 14 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(271, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(327, 44, false);
#line 17 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(371, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(427, 42, false);
#line 20 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(469, 100, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(601, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(650, 54, false);
#line 30 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(704, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(760, 43, false);
#line 33 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(803, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(859, 41, false);
#line 36 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(900, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 41 "E:\ProgTest\WarehouseAccountingSystem\WarehouseAccountingSystem\Views\Balance\Index.cshtml"
}

#line default
#line hidden
            BeginContext(976, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WarehouseAccountingSystem.Entities.Balance>> Html { get; private set; }
    }
}
#pragma warning restore 1591
