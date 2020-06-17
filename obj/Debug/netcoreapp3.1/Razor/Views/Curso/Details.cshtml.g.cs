#pragma checksum "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4f5f5c4f6a5231948831726a590f124e1c5033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Details), @"mvc.1.0.view", @"/Views/Curso/Details.cshtml")]
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
#line 1 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4f5f5c4f6a5231948831726a590f124e1c5033", @"/Views/Curso/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Curso>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
  
    ViewData["Title"] = "Curso";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container "">

    <div class=""container border rounded p-2  m-2"">
        <h3>Detalles del curso</h3>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">
                        Numero del Curso
                    </th>
                    <th scope=""col"">
                        Salon Del Curso
                    </th>
                    <th scope=""col"">
                        Jordana del Curso
                    </th>
                    <th>
                        Id del Curso
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 31 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 32 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                               Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 33 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                               Write(Model.Jornada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
#nullable restore
#line 34 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>

    </div>
    

    <div class=""container border rounded p-2  m-2"">
        <h3>Asignaturas</h3>

        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">
                        Nombre
                    </th>
                    <th scope=""col"">
                        Id
                    </th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 58 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                 foreach (var item in Model.Asignaturas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"container border rounded p-2  m-2\">\r\n        <h3>Alumnos</h3>\r\n        <table class=\"table\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n");
#nullable restore
#line 80 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                     foreach (var item in Model.Alumnos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>\r\n                            ");
#nullable restore
#line 83 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n");
#nullable restore
#line 85 "C:\Users\Illu Gonzalez\Desktop\CURSOS\Backend\.NET\Escuela\Views\Curso\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591