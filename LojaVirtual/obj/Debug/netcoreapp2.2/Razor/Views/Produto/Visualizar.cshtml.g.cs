#pragma checksum "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29bf2a4b16334c1056d16f70f8ba3cc2ad533b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29bf2a4b16334c1056d16f70f8ba3cc2ad533b00", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Nicholas Dela Torre";


#line default
#line hidden
            BeginContext(88, 6, true);
            WriteLiteral("\r\n<h5>");
            EndContext();
            BeginContext(95, 4, false);
#line 8 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
            EndContext();
            BeginContext(99, 49, true);
            WriteLiteral("</h5>\r\n<br />\r\n<h2>Produto</h2>\r\n<b>Código: </b> ");
            EndContext();
            BeginContext(149, 8, false);
#line 11 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(157, 16, true);
            WriteLiteral("\r\n<b>Nome: </b> ");
            EndContext();
            BeginContext(174, 10, false);
#line 12 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(184, 21, true);
            WriteLiteral("\r\n<b>Descrição: </b> ");
            EndContext();
            BeginContext(206, 15, false);
#line 13 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
              Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(221, 17, true);
            WriteLiteral("\r\n<b>Valor: </b> ");
            EndContext();
            BeginContext(239, 11, false);
#line 14 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(250, 40, true);
            WriteLiteral("\r\n\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(291, 17, false);
#line 16 "C:\Users\dev\Documents\Udemy\LojaVirtual\LojaVirtual\LojaVirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
