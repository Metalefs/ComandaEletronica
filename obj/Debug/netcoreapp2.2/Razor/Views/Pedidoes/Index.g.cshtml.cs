#pragma checksum "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db309f63e3a0cea58255ac2cc37184f03a66bb34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidoes_Index), @"mvc.1.0.view", @"/Views/Pedidoes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidoes/Index.cshtml", typeof(AspNetCore.Views_Pedidoes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db309f63e3a0cea58255ac2cc37184f03a66bb34", @"/Views/Pedidoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b74cd5f50aaf07f187707eea8d38697a1d3a97d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ia_ComandaRestaurante.Models.ViewModels.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
  
    ViewData["Title"] = "Pedidos";
    

#line default
#line hidden
            BeginContext(119, 31, true);
            WriteLiteral("\r\n<h1>Pedidos</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(150, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db309f63e3a0cea58255ac2cc37184f03a66bb344849", async() => {
                BeginContext(173, 18, true);
                WriteLiteral("Anotar novo Pedido");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 151, true);
            WriteLiteral(";\r\n</p>\r\n<table class=\"table\">\r\n    <thead class=\"table table-success \">\r\n        <tr class=\"table table-success\" >\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 49, false);
#line 17 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrazoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(396, 142, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"alert-light\">\r\n                Id da Mesa\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(539, 49, false);
#line 24 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(588, 120, true);
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                Id do Menu\r\n            </td>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(709, 47, false);
#line 30 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Observacoes));

#line default
#line hidden
            EndContext();
            BeginContext(756, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(812, 53, false);
#line 33 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeDoFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(921, 42, false);
#line 36 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(963, 103, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </trtable>\r\n    </theadclass=\"table>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1115, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 48, false);
#line 46 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrazoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"alert-light\">\r\n                ");
            EndContext();
            BeginContext(1288, 41, false);
#line 49 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMesa));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 59, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                R$");
            EndContext();
            BeginContext(1389, 48, false);
#line 53 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
             Write(Html.DisplayFor(modelItem => item.PrecoDoPedido));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1493, 41, false);
#line 56 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMenu));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1590, 46, false);
#line 59 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Observacoes));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1692, 52, false);
#line 62 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeDoFuncionario));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1800, 41, false);
#line 65 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1896, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db309f63e3a0cea58255ac2cc37184f03a66bb3412298", async() => {
                BeginContext(1947, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
                                       WriteLiteral(item.IdPedido);

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
            BeginContext(1957, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1977, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db309f63e3a0cea58255ac2cc37184f03a66bb3414671", async() => {
                BeginContext(2031, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
                                          WriteLiteral(item.IdPedido);

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
            BeginContext(2043, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2063, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db309f63e3a0cea58255ac2cc37184f03a66bb3417049", async() => {
                BeginContext(2116, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
                                         WriteLiteral(item.IdPedido);

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
            BeginContext(2127, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\User\source\repos\Ia-ComandaRestaurante\Ia-ComandaRestaurante\Views\Pedidoes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2174, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ia_ComandaRestaurante.Models.ViewModels.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
