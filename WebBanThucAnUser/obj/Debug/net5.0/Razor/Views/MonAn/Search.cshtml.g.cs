#pragma checksum "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a3d4974c3c869da219b57ebd1ec7515f584f838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MonAn_Search), @"mvc.1.0.view", @"/Views/MonAn/Search.cshtml")]
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
#line 1 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\_ViewImports.cshtml"
using WebBanThucAnUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\_ViewImports.cshtml"
using WebBanThucAnUser.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a3d4974c3c869da219b57ebd1ec7515f584f838", @"/Views/MonAn/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac90b0710492376b467531d5edd3c3ccede5dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_MonAn_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MonAn>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MonAn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"background-color: black;opacity:0.8\" id=\"htmlContainer\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a3d4974c3c869da219b57ebd1ec7515f584f8384839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<section class=\"food_section layout_padding\">\r\n    <div class=\"container\">\r\n        <div class=\"heading_container heading_center\">\r\n            <h2>\r\n                Our Menu\r\n            </h2>\r\n        </div>\r\n\r\n");
#nullable restore
#line 26 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"filters-content\">\r\n                <div class=\"row grid\">\r\n\r\n");
#nullable restore
#line 31 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6 col-lg-4 all pizza\">\r\n                            <div class=\"box\">\r\n                                <div>\r\n                                    <div class=\"img-box\">\r\n");
            WriteLiteral("                                    </div>\r\n                                    <div class=\"detail-box\">\r\n                                        <h5>\r\n                                            ");
#nullable restore
#line 41 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </h5>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 44 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                       Write(item.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <div class=\"options\">\r\n                                            <h6>\r\n\r\n                                                ");
#nullable restore
#line 49 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                            Write(item.Gia.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đồng\r\n                                            </h6>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a3d4974c3c869da219b57ebd1ec7515f584f8388569", async() => {
                WriteLiteral("\r\n                                                <i class=\"fa fa-info-circle\" aria-hidden=\"true\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 54 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                             if (item.Quantity > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"#\" class=\"addcartitem\"\r\n                                                   data-productid=\"");
#nullable restore
#line 57 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    <svg version=""1.1"" id=""Capa_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" viewBox=""0 0 456.029 456.029"" style=""enable-background:new 0 0 456.029 456.029;"" xml:space=""preserve"">
                                                    <g>
                                                    <g>
                                                    <path d=""M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                         c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z"" />
                          </g>
                        </g>
                                                    <g>
                                                    <g>
                                                    <path d=""M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
      ");
            WriteLiteral(@"                   C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                         c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                         C457.728,97.71,450.56,86.958,439.296,84.91z"" />
                          </g>
                        </g>
                                                    <g>
                                                    <g>
                                                    <path d=""M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                         c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z"" />
                          </g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g");
            WriteLiteral(@">
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
                        </g>
                                                    <g>
       ");
            WriteLiteral("                 </g>\r\n                                                    <g>\r\n                        </g>\r\n                      </svg>\r\n                                                </a>\r\n");
#nullable restore
#line 111 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 120 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 128 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"h1 text-center\">Sản phẩm không tìm được</p>\r\n");
#nullable restore
#line 132 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
          $(document).ready(function () {
              $("".addcartitem"").click(function (event) {
                  event.preventDefault();
                  var productid = $(this).attr(""data-productid"");
                  $.ajax({
                      type: ""POST"",
                      url:""");
#nullable restore
#line 150 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                      Write(Url.Action("AddToCartPost"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                      data: {\r\n                          productid: productid,\r\n                      },\r\n                      success: function (result) {\r\n                          //window.location.href = \"");
                WriteLiteral("@Url.Action(\"index\")\";\r\n                          $.get(\'");
#nullable restore
#line 156 "D:\Myproject\CSharp\NET105\Assignment\WebBanThucAn\WebBanThucAnUser\Views\MonAn\Search.cshtml"
                            Write(Url.Action("RefreshLoginPartial", "Shared"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', function (result) {\r\n                              $(\'#htmlContainer\').html(result);\r\n            });\r\n                      }\r\n                  });\r\n              });\r\n          });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MonAn>> Html { get; private set; }
    }
}
#pragma warning restore 1591
