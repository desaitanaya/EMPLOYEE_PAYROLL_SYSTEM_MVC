#pragma checksum "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f56661112f87cc94326c4e8986d8a3b2f57f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetAllEmployees), @"mvc.1.0.view", @"/Views/Employee/GetAllEmployees.cshtml")]
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
#line 1 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\_ViewImports.cshtml"
using EmployeePayroll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\_ViewImports.cshtml"
using EmployeePayroll.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f56661112f87cc94326c4e8986d8a3b2f57f0c", @"/Views/Employee/GetAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aef9691ee69b6b72041338598cd32639cbfd2ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommonLayer.Model.EmployeeModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
  
    ViewData["Title"] = "GetAllEmployees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class = \"heading\">\r\n    <h5>All Employee Details</h5>\r\n</div>\r\n\r\n<p>\r\n    <button type = \"button\" button class =\"btn btn-primary \"");
            BeginWriteAttribute("onclick", " onclick=\"", 245, "\"", 309, 3);
            WriteAttributeValue("", 255, "location.href=\'", 255, 15, true);
#nullable restore
#line 13 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
WriteAttributeValue("", 270, Url.Action("AddEmployee", "Employee"), 270, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 308, "\'", 308, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add New Employee </button>\r\n  \r\n    \r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n");
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src = \"", 1296, "\"", 1335, 1);
#nullable restore
#line 48 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
WriteAttributeValue("", 1304, Url.Content(item.ProfileImage), 1304, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.ActionLink("Edit", "EditEmployee", new { id = item.EmployeeID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 56 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.ActionLink("Details", "GetEmployeeById", new { id = item.EmployeeID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 57 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.ActionLink("Delete", "DeleteEmployee", new { id = item.EmployeeID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    \r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
            
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n\r\n    <button type=\"button\" button class=\"btn btn-primary \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1935, "\"", 1989, 3);
            WriteAttributeValue("", 1945, "location.href=\'", 1945, 15, true);
#nullable restore
#line 68 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
WriteAttributeValue("", 1960, Url.Action("Index", "Home"), 1960, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1988, "\'", 1988, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back To Home </button>\r\n    \r\n</div>\r\n");
#nullable restore
#line 71 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
  
    string admin = ViewBag.Name;

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\5570\Desktop\CFP_DOTNET_MVC\EmployeePayroll\EmployeePayroll\Views\Employee\GetAllEmployees.cshtml"
Write(admin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommonLayer.Model.EmployeeModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591