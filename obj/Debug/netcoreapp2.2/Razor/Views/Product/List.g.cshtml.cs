#pragma checksum "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fb2dce3034691525a86bc47c811a690185789ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\_ViewImports.cshtml"
using pos.Models;

#line default
#line hidden
#line 2 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\_ViewImports.cshtml"
using pos.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\_ViewImports.cshtml"
using POS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb2dce3034691525a86bc47c811a690185789ce", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40166284c16504ac5a0578fe9204ebe9ac275d15", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("food"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fiyat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";
        Layout = "_Layout";
        string filter1="";

#line default
#line hidden
            BeginContext(126, 1185, true);
            WriteLiteral(@"  <link href=""https://fonts.googleapis.com/css?family=DM+Serif+Display&display=swap"" rel=""stylesheet"">
  <link href=""https://fonts.googleapis.com/css?family=Archivo:400i&display=swap"" rel=""stylesheet"">


<style> 
    .right{
         float:right;
    }
    .left{
         float:left;
    }
    .icerik {
display: table-cell;
vertical-align: middle;
    }
    .a{
      width:50px;
    }
    .ab{
      width:170px;
    }

html,body {
	width:100%;
	position:relative;
}

h4, h5{
  font-family: 'Archivo', sans-serif;
}


</style>

<br>
<div class=""dropdown"">
  <button class=""btn btn-danger dropdown-toggle right"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
    Kategori Seç
  </button>
  <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
    <button class=""dropdown-item"" href=""#""></button>
    <button class=""dropdown-item"" href=""#"">Et</button>
    <button class=""dropdown-item"" href=""#"">İçecekler</butto");
            WriteLiteral("n>\r\n    <button class=\"dropdown-item\" href=\"#\">Pideler</button>\r\n    <button class=\"dropdown-item\" href=\"#\">Tatlılar</button>\r\n  </div>\r\n</div>\r\n\r\n<br>\r\n<br>\r\n\r\n");
            EndContext();
#line 58 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
 foreach (var item in Model)
{
  
  
      

#line default
#line hidden
            BeginContext(1360, 235, true);
            WriteLiteral("<div class=\"form-row  \">\r\n\r\n    <div class=\"col-md-6  \">\r\n\r\n        <div class=\"card text-center icerik \" style=\"width: 300px; height:350px \">\r\n\r\n            <div class=\"card-header bg-white\"> \r\n\r\n            <h4 class=\"card-title  \"> ");
            EndContext();
            BeginContext(1596, 9, false);
#line 71 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 150, true);
            WriteLiteral("\r\n            </h4>\r\n\r\n            </div> <!-- CARD HEADER SONU-->\r\n\r\n       <div class=\"card-body\">\r\n    \r\n        <h5 class=\"card-subtitle mb-2   \">");
            EndContext();
            BeginContext(1756, 14, false);
#line 78 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                     Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 47, true);
            WriteLiteral("\r\n        </h5>\r\n        <h5 class=\"card-text\">");
            EndContext();
            BeginContext(1818, 16, false);
#line 80 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                         Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1834, 48, true);
            WriteLiteral("\r\n        </h5>\r\n         <h5 class=\"card-text\">");
            EndContext();
            BeginContext(1883, 10, false);
#line 82 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                          Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 164, true);
            WriteLiteral(" TL\r\n        </h5>\r\n    \r\n\r\n\r\n          <hr class=\"bg-danger\">\r\n\r\n          <button type=\"button\" class=\"btn btn-outline-danger  btn-lg \" data-target=\"#DeleteModal-");
            EndContext();
            BeginContext(2058, 14, false);
#line 89 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                                                                             Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2072, 173, true);
            WriteLiteral("\" data-toggle=\"modal\">\r\n            Sil\r\n          </button>\r\n          <button type=\"button\" class=\"btn btn-outline-success btn-lg\" data-toggle=\"modal\" data-target=\"#modal_");
            EndContext();
            BeginContext(2246, 14, false);
#line 92 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                                                                                          Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(2260, 235, true);
            WriteLiteral("\">\r\n          Sipariş Ver\r\n          </button>\r\n\r\n       \r\n   \r\n            </div> <!-- CARD BODY SONU -->  \r\n\r\n        </div>  <!--CARD SONU --> \r\n\r\n    </div> <!-- DİV CLASS COL-MD-6 SONU --> \r\n\r\n            <div class=\"col-md-6 \">\r\n");
            EndContext();
#line 105 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
               if(item.Image!=null)
              {
              var base64=Convert.ToBase64String(item.Image);
              var imgsrc = string.Format("data:image/jpeg;base64,{0}", base64);

#line default
#line hidden
            BeginContext(2692, 18, true);
            WriteLiteral("              <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 2710, "\'", 2723, 1);
#line 109 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
WriteAttributeValue("", 2716, imgsrc, 2716, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2724, 99, true);
            WriteLiteral(" class=\"card-img img-thumbnail rounded-circle\" alt=\"Card image cap\" width=\"280px\" height=\"300px\">\r\n");
            EndContext();
#line 110 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
              }

#line default
#line hidden
            BeginContext(2840, 138, true);
            WriteLiteral("            </div>   <!--DİV CLASS COL-MD-6 SONU -->\r\n            \r\n            </div>  <!--FORM ROW SONU-->\r\n        <br>\r\n        <br>\r\n");
            EndContext();
            BeginContext(2980, 39, true);
            WriteLiteral("<!-- Modal -->\r\n<div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3019, "\"", 3045, 2);
            WriteAttributeValue("", 3024, "modal_", 3024, 6, true);
#line 118 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
WriteAttributeValue("", 3030, item.ProductId, 3030, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3046, 606, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""OrderModale"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Sipariş Ver</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div id=""app"" class=""modal-body"">
        <div class=""container-fluid"">
          <div class=""row"">
            <div class=""col-md-5"">Yemek<hr>
            ");
            EndContext();
            BeginContext(3652, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fb2dce3034691525a86bc47c811a690185789ce13857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 131 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3735, 214, true);
            WriteLiteral("\r\n  \r\n            </div>\r\n            <div class=\"col-md-3\">Adet<hr>\r\n            <input id=\"adet\" type=\"number\" min=\"1\" max=\"20\"/>\r\n            </div>\r\n\r\n\r\n            <div class=\"col-md-4\">Fiyat<hr>\r\n            ");
            EndContext();
            BeginContext(3949, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fb2dce3034691525a86bc47c811a690185789ce16494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 140 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Price);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4020, 316, true);
            WriteLiteral(@"
            </div>
      
      
      </div>
      <br>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-danger"">Sil</button>
        <button type=""button"" class=""btn btn-success"">Onayla</button>
      </div>
    </div>
  </div>
</div>
</div>
</div>
<!-- MODAL END -->
");
            EndContext();
            BeginContext(4340, 27, true);
            WriteLiteral("<!-- BU DELETE MODALI -->\r\n");
            EndContext();
            BeginContext(4369, 34, true);
            WriteLiteral(" <div class=\"modal fade text-dark\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4403, "\"", 4435, 2);
            WriteAttributeValue("", 4408, "DeleteModal-", 4408, 12, true);
#line 160 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
WriteAttributeValue("", 4420, item.ProductId, 4420, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4436, 266, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModal"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">

        <h5 class=""modal-title"" id=""DeleteTitle"">");
            EndContext();
            BeginContext(4703, 14, false);
#line 165 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                            Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(4717, 258, true);
            WriteLiteral(@" numaralı ürün

        </h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>
          ");
            EndContext();
            BeginContext(4976, 9, false);
#line 174 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4985, 205, true);
            WriteLiteral(" \r\n          \"silinsin mi?\"\r\n\r\n      </p>\r\n \r\n      </div>\r\n\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-outline-secondary\" data-dismiss=\"modal\">İptal</button>\r\n        ");
            EndContext();
            BeginContext(5190, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb2dce3034691525a86bc47c811a690185789ce21178", async() => {
                BeginContext(5303, 15, true);
                WriteLiteral("\r\n          Sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 183 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"
                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5322, 46, true);
            WriteLiteral("\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(5370, 32, true);
            WriteLiteral("<!-- Delete Modalının sonu -->\r\n");
            EndContext();
#line 191 "C:\Users\MAKTAS-STJ\Desktop\try\pos\Views\Product\List.cshtml"


}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(5426, 77, true);
                WriteLiteral("\r\n<script>\r\n  \r\n  function filter1() {\r\n    return filter1;\r\n  }\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(5506, 22, true);
            WriteLiteral("\r\n        \r\n      \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
