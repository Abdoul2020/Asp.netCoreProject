#pragma checksum "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c19c7565ea64e2d5bcf0ffd3ddd4e486cbe2210"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Index), @"mvc.1.0.view", @"/Views/Personel/Index.cshtml")]
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
#line 1 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\_ViewImports.cshtml"
using oyabi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
using oyabi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c19c7565ea64e2d5bcf0ffd3ddd4e486cbe2210", @"/Views/Personel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ab83016f1970fe4cda9e0ff5fef87ec77f15e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_testLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>AD</th>\r\n        <th>SOYAD</th>\r\n        <th>Şehir</th>\r\n        <th>DepartementId</th>\r\n        <th>Supprimer</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
           Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
           Write(x.personelad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
           Write(x.personelsoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
           Write(x.personelsehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
           Write(x.depar.DepartmanAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 642, "\"", 672, 2);
            WriteAttributeValue("", 649, "/Depart/departsil/", 649, 18, true);
#nullable restore
#line 30 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
WriteAttributeValue("", 667, x.ID, 667, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 761, 2);
            WriteAttributeValue("", 736, "/Depart/departGetir/", 736, 20, true);
#nullable restore
#line 31 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
WriteAttributeValue("", 756, x.ID, 756, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\abdou\source\repos\oyabi\oyabi\Views\Personel\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Personel/yenipersonel\" class=\"btn btn-primary\">Nouveau Personel</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591