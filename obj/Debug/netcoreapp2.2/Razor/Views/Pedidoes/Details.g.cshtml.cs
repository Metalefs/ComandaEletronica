#pragma checksum "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22c1ae033f7f73c6ba88cfdc98e8a7220e87a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidoes_Details), @"mvc.1.0.view", @"/Views/Pedidoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidoes/Details.cshtml", typeof(AspNetCore.Views_Pedidoes_Details))]
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
#line 1 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\_ViewImports.cshtml"
using Ia_ComandaRestaurante;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\_ViewImports.cshtml"
using Ia_ComandaRestaurante.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22c1ae033f7f73c6ba88cfdc98e8a7220e87a0e", @"/Views/Pedidoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b74cd5f50aaf07f187707eea8d38697a1d3a97d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ia_ComandaRestaurante.Models.ViewModels.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";
    int i = 0;
    

#line default
#line hidden
            BeginContext(125, 130, true);
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(256, 49, false);
#line 17 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrazoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(305, 71, true);
            WriteLiteral(" minutos\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(377, 45, false);
#line 20 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrazoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(422, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(485, 61, false);
#line 23 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MesaDoPedido.NumeroDaMesa));

#line default
#line hidden
            EndContext();
            BeginContext(546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(610, 44, false);
#line 26 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.MesaDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(654, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(717, 63, false);
#line 29 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GetFuncionarioResponsavel()));

#line default
#line hidden
            EndContext();
            BeginContext(780, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(844, 59, false);
#line 32 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.GetFuncionarioResponsavel()));

#line default
#line hidden
            EndContext();
            BeginContext(903, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(966, 49, false);
#line 35 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 69, true);
            WriteLiteral(" Reais\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1085, 45, false);
#line 38 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1203, 49, false);
#line 42 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItensDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 76, true);
            WriteLiteral("\r\n        </dt>\r\n           \r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1329, 45, false);
#line 46 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItensDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1437, 42, false);
#line 49 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1543, 38, false);
#line 52 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1628, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22c1ae033f7f73c6ba88cfdc98e8a7220e87a0e9828", async() => {
                BeginContext(1680, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Details.cshtml"
                           WriteLiteral(Model.IdPedido);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1688, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1696, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22c1ae033f7f73c6ba88cfdc98e8a7220e87a0e12176", async() => {
                BeginContext(1718, 18, true);
                WriteLiteral("Voltar aos pedidos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1740, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ia_ComandaRestaurante.Models.ViewModels.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
