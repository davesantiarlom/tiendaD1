#pragma checksum "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a6", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal"" tabindex=""-1"" id=""myCardShopping"">
    <div class=""modal-dialog modal-xl modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Carrito De Compras <span id=""TotalOrder""><b>$0</b></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <table id=""grid"" class=""table table-responsive"">
                    <thead>
                        <tr>
                            <th>
                                Producto
                            </th>
                            <th>
                                Precio C/U
                            </th>
                            <th>
                                Cantidad
                            </th");
            WriteLiteral(@">
                            <th>
                                Subtotal
                            </th>
                            <th>

                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td> q</td>
                            <td> </td>
                            <td> </td>
                            <td> </td>
                            <td> </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Cerrar</button>
                <button type=""submit"" class=""btn btn-primary"" onclick=""finishOrder()"">Finalizar Compra</button>
            </div>
        </div>
    </div>
</div>

<ul class=""navbar-nav"">
");
#nullable restore
#line 56 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a68972", async() => {
                WriteLiteral("Hello ");
#nullable restore
#line 59 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
                                                                                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a610982", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
                                                                                              WriteLiteral(Url.Action("Index", "Home", new { area = "" }));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
        <li class=""nav-item"">
            <div class=""form-group"">
                <label id=""QtyShopping"" class=""control-label notificacion""  onclick=""loadShoppingDetails()"">0</label>
                <i class=""fa fa-shopping-bag fa-2x"" onclick=""loadShoppingDetails()""></i>
            </div>
        </li>
");
#nullable restore
#line 72 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a614700", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc9dcb3dfda23f6fdc6e98904cfd5d8c8c650a616203", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 81 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<script type=\"text/javascript\">\r\n\r\n\r\n    setInterval(function () { getQtyShopping(); }, 1000);//Cada 10 segundos\r\n\r\n    function getQtyShopping() {\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 91 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
             Write(Url.Action("getQtyShopping", "OrderDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {

            },
            method: 'POST',
            success: function (result) {
                if (result != null) {
                    $(""#QtyShopping"").text(result);
                } else {
                    $(""#QtyShopping"").text(0);
                }
            },
            error: function (jqXHR, textStatus, error) {
            }
        });
    }

    function loadShoppingDetails() {
        $.ajax({
            url: '");
#nullable restore
#line 110 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
             Write(Url.Action("getShoppingDetails", "OrderDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
            },
            method: 'POST',
            success: function (records) {
                let body = $(""#grid tbody"");
                let TotalOrder = 0;
                body.empty();

                 if (records != null) {
                     $.each(records,function (index,record) {
                         TotalOrder += record.subTotal;
                         body.append(""<tr>"");
                         debugger;
                         body.append(""<td>"" + record.product.description + ""</td>"");
                        body.append(""<td>$"" + record.cost + ""</td>"");
                         body.append(""<td>"" + record.quantity + ""</td>"");
                        body.append(""<td>$"" + record.subTotal + ""</td>"");
                         body.append('<td><a  onclick=""deleteDetail(' + record.orderDetailId+')""><span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span></a> </td>');
                        body.append(""</tr>"");
                  ");
            WriteLiteral(@"  })
                     $(""#TotalOrder"").text(""$""+TotalOrder);
                    $(""#myCardShopping"").modal()
                    //$(""#QtyShopping"").text(records);
                }
            },
            error: function (jqXHR, textStatus, error) {
            }
        });
    }

    function finishOrder() {
        $.ajax({
            url: '");
#nullable restore
#line 143 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
             Write(Url.Action("finishShoppingDetails", "OrderDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {
            },
            method: 'POST',
            success: function (menssage) {
                alert(menssage);
                window.location.reload(); 
            },
            error: function (jqXHR, textStatus, error) {
            }
        });
    }

    function deleteDetail(orderDetailId) {
          $.ajax({
            url: '");
#nullable restore
#line 158 "D:\UNIVERSIDAD\6 SEMESTRE\PROGRAMACION .NET\Proyecto - TiendaD1-20201126T215255Z-001\Proyecto - TiendaD1\WebApplication1\WebApplication1\Views\Shared\_LoginPartial.cshtml"
             Write(Url.Action("deleteorderDetails", "OrderDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
              data: {
                  orderDetailId: orderDetailId
            },
            method: 'POST',
              success: function (menssage) {
                  loadShoppingDetails();
                  alert(menssage);

            },
            error: function (jqXHR, textStatus, error) {
            }
        })
    }


</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
