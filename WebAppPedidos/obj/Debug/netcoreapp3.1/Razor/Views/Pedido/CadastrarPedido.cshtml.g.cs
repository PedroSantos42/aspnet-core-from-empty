#pragma checksum "C:\Code\workana\aspnet-core-from-empty\WebAppPedidos\Views\Pedido\CadastrarPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55591500c038e5291ddc269c13fa1a0cd0c92b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CadastrarPedido), @"mvc.1.0.view", @"/Views/Pedido/CadastrarPedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55591500c038e5291ddc269c13fa1a0cd0c92b1", @"/Views/Pedido/CadastrarPedido.cshtml")]
    public class Views_Pedido_CadastrarPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>Cadastro de Pedidos</title>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55591500c038e5291ddc269c13fa1a0cd0c92b12633", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Code\workana\aspnet-core-from-empty\WebAppPedidos\Views\Pedido\CadastrarPedido.cshtml"
       var existePedidoInfo = ViewData["existePedido"];
        if (existePedidoInfo != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script>alert(\"Este pedido já existe!\")</script>\r\n");
#nullable restore
#line 7 "C:\Code\workana\aspnet-core-from-empty\WebAppPedidos\Views\Pedido\CadastrarPedido.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h2>Criar Pedido</h2>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 13 "C:\Code\workana\aspnet-core-from-empty\WebAppPedidos\Views\Pedido\CadastrarPedido.cshtml"
             using (Html.BeginForm("SalvarPedido", "Pedido", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""form-group"">
                    <label for=""produto"">Produto</label><br>
                    <input type=""text"" id=""produto"" name=""produto"" required><br>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""quantidade"">Quantidade</label><br>
                    <input type=""text"" id=""quantidade"" name=""quantidade""><br>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""valor"">Valor</label><br>
                    <input type=""text"" id=""valor"" name=""valor"" required><br>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""data"">Data</label><br>
                    <input type=""text"" id=""data"" name=""data""><br>
                </div>
                <br />
                <div class=""form-group"">
                    <label for=""fornecedor"">Fornecedor</label><br>
    ");
                WriteLiteral("                <input type=\"text\" id=\"fornecedor\" name=\"fornecedor\"><br>\r\n                </div>\r\n                <br />\r\n                <input type=\"submit\" value=\"Salvar\" />\r\n");
#nullable restore
#line 41 "C:\Code\workana\aspnet-core-from-empty\WebAppPedidos\Views\Pedido\CadastrarPedido.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
