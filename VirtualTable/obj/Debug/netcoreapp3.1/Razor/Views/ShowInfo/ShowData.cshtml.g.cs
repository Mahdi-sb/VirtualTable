#pragma checksum "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3492e7d3b718a2f1b27a7bde479271b8dd11973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowInfo_ShowData), @"mvc.1.0.view", @"/Views/ShowInfo/ShowData.cshtml")]
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
#line 1 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\_ViewImports.cshtml"
using VirtualTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\_ViewImports.cshtml"
using VirtualTable.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3492e7d3b718a2f1b27a7bde479271b8dd11973", @"/Views/ShowInfo/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6875ce851a29aae4180f79cc5732e568f68fc4", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowInfo_ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Infrastructure.DTO.ValueDTO>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
   ViewData["Title"] = "ShowData";
    var column = ViewData["column"] as List<string>;
    int xt = column.Count;
    int ct = 0; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3492e7d3b718a2f1b27a7bde479271b8dd119733569", async() => {
                WriteLiteral(@"
    <style>
        table, td, th {
            border: 1px solid #ddd;
            text-align: left;
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            padding: 15px;
        }

        th {
            background-color: dodgerblue;
            color: white;
        }

        td {
            background-color: antiquewhite;
            color: black;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3492e7d3b718a2f1b27a7bde479271b8dd119734990", async() => {
                WriteLiteral("\n");
#nullable restore
#line 35 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
     if (column.Count != 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<table>\n    <tr>\n");
#nullable restore
#line 39 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
         foreach (var item1 in column)
        {



#line default
#line hidden
#nullable disable
                WriteLiteral("<th>");
#nullable restore
#line 43 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
Write(item1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n");
#nullable restore
#line 44 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tr>\n\n");
#nullable restore
#line 47 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
     for (int i = 0; i < Model.Count / column.Count; i++)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n");
#nullable restore
#line 51 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
     for (int j = ct; j < xt; j++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<td>");
#nullable restore
#line 53 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
Write(Model[j].FieldValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 54 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("</tr>\n");
#nullable restore
#line 56 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
ct += column.Count;
xt += column.Count;
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</table> ");
#nullable restore
#line 60 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>دیتایی در این جدول وجود ندارد</h1>");
#nullable restore
#line 63 "C:\Users\mhadi\Desktop\CreateTable2\VirtualTable\VirtualTable\Views\ShowInfo\ShowData.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Infrastructure.DTO.ValueDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591