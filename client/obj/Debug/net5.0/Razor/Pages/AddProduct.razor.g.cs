#pragma checksum "C:\NovorfayWASM\client\Pages\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2c9350325428dd072a688931c5978c0db5719f"
// <auto-generated/>
#pragma warning disable 1591
namespace Novorfay.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\NovorfayWASM\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NovorfayWASM\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NovorfayWASM\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NovorfayWASM\client\_Imports.razor"
using Novorfay.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\NovorfayWASM\client\_Imports.razor"
using Novorfay.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Novorfay.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Novorfay.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-product")]
    public partial class AddProduct : Novorfay.Pages.AddProductComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Novorfay.Models.ConData.Product>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Novorfay.Models.ConData.Product>(
#nullable restore
#line 18 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                   product

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                               product != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Novorfay.Models.ConData.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Novorfay.Models.ConData.Product>(this, 
#nullable restore
#line 18 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                                                          Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Component", "CategoryID");
                    __builder3.AddAttribute(19, "style", "width: 100%");
                    __builder3.AddAttribute(20, "Text", "Product Category");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.Novorfay.Client.Pages.AddProduct.TypeInference.CreateRadzenDropDown_0(__builder3, 24, 25, 
#nullable restore
#line 26 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                       getProductCategoriesResult

#line default
#line hidden
#nullable disable
                    , 26, "Choose ProductCategory", 27, "display: block; width: 100%", 28, "CategoryName", 29, "CategoryID", 30, "CategoryID", 31, 
#nullable restore
#line 26 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                                                                                                                       product.CategoryID

#line default
#line hidden
#nullable disable
                    , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryID = __value, product.CategoryID)), 33, () => product.CategoryID);
                    __builder3.AddMarkupContent(34, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(35);
                    __builder3.AddAttribute(36, "Component", "CategoryID");
                    __builder3.AddAttribute(37, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                              0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "style", "position: absolute");
                    __builder3.AddAttribute(39, "Text", "CategoryID is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(46);
                    __builder3.AddAttribute(47, "Component", "ProductName");
                    __builder3.AddAttribute(48, "style", "width: 100%");
                    __builder3.AddAttribute(49, "Text", "Product Name");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(53);
                    __builder3.AddAttribute(54, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 38 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                          150

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(56, "Name", "ProductName");
                    __builder3.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                                  product.ProductName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                    __builder3.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(61);
                    __builder3.AddAttribute(62, "Component", "ProductName");
                    __builder3.AddAttribute(63, "style", "position: absolute");
                    __builder3.AddAttribute(64, "Text", "ProductName is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(68, "class", "row");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(71);
                    __builder3.AddAttribute(72, "Component", "Price");
                    __builder3.AddAttribute(73, "style", "width: 100%");
                    __builder3.AddAttribute(74, "Text", "Price");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-9");
                    __Blazor.Novorfay.Client.Pages.AddProduct.TypeInference.CreateRadzenNumeric_1(__builder3, 78, 79, "display: block; width: 100%", 80, "Price", 81, 
#nullable restore
#line 50 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                  product.Price

#line default
#line hidden
#nullable disable
                    , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 83, () => product.Price);
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(85);
                    __builder3.AddAttribute(86, "Component", "Price");
                    __builder3.AddAttribute(87, "style", "position: absolute");
                    __builder3.AddAttribute(88, "Text", "Price is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n            ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(92, "class", "row");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(95);
                    __builder3.AddAttribute(96, "Component", "Picture");
                    __builder3.AddAttribute(97, "style", "width: 100%");
                    __builder3.AddAttribute(98, "Text", "Picture");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\n              ");
                    __builder3.OpenElement(100, "div");
                    __builder3.AddAttribute(101, "class", "col-md-9");
                    __Blazor.Novorfay.Client.Pages.AddProduct.TypeInference.CreateRadzenFileInput_2(__builder3, 102, 103, "FileInput0", 104, 
#nullable restore
#line 62 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                product.Picture

#line default
#line hidden
#nullable disable
                    , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Picture = __value, product.Picture)), 106, () => product.Picture);
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(108);
                    __builder3.AddAttribute(109, "Component", "FileInput0");
                    __builder3.AddAttribute(110, "Text", "Picture is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "row");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(116);
                    __builder3.AddAttribute(117, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 70 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 70 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Icon", "save");
                    __builder3.AddAttribute(120, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(122);
                    __builder3.AddAttribute(123, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(125, "Text", "Cancel");
                    __builder3.AddAttribute(126, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\NovorfayWASM\client\Pages\AddProduct.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Novorfay.Client.Pages.AddProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenFileInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenFileInput<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
