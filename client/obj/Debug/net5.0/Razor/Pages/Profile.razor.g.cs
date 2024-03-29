#pragma checksum "C:\NovorfayWASM\client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5adbf66988ea33261a865fd004dbaa140f5c7d"
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
#line 5 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Novorfay.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Novorfay.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\NovorfayWASM\client\Pages\Profile.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\NovorfayWASM\client\Pages\Profile.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Novorfay.Pages.ProfileComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Profile");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(11);
                __builder2.AddAttribute(12, "Method", "post");
                __builder2.AddAttribute(13, "Action", "account/changepassword");
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 20 "C:\NovorfayWASM\client\Pages\Profile.razor"
                                                                                                          user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\NovorfayWASM\client\Pages\Profile.razor"
                                                                                                                            user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(19, "class", "row");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(22);
                    __builder3.AddAttribute(23, "Component", "OldPassword");
                    __builder3.AddAttribute(24, "style", "width: 100%");
                    __builder3.AddAttribute(25, "Text", "Old Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\n              ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(29);
                    __builder3.AddAttribute(30, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(31, "Name", "OldPassword");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(33);
                    __builder3.AddAttribute(34, "Component", "OldPassword");
                    __builder3.AddAttribute(35, "style", "position: absolute");
                    __builder3.AddAttribute(36, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(40, "class", "row");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(43);
                    __builder3.AddAttribute(44, "Component", "NewPassword");
                    __builder3.AddAttribute(45, "style", "width: 100%");
                    __builder3.AddAttribute(46, "Text", "New Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\n              ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(50);
                    __builder3.AddAttribute(51, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(52, "Name", "NewPassword");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(54);
                    __builder3.AddAttribute(55, "Component", "NewPassword");
                    __builder3.AddAttribute(56, "style", "position: absolute");
                    __builder3.AddAttribute(57, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(61, "class", "row");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(64);
                    __builder3.AddAttribute(65, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(66, "style", "width: 100%");
                    __builder3.AddAttribute(67, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(71);
                    __builder3.AddAttribute(72, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(73, "Name", "ConfirmPassword");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(75);
                    __builder3.AddAttribute(76, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(77, "style", "position: absolute");
                    __builder3.AddAttribute(78, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "row");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 60 "C:\NovorfayWASM\client\Pages\Profile.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 60 "C:\NovorfayWASM\client\Pages\Profile.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "Icon", "save");
                    __builder3.AddAttribute(88, "Text", "Change password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(90);
                    __builder3.AddAttribute(91, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 62 "C:\NovorfayWASM\client\Pages\Profile.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(92, "Text", "Cancel");
                    __builder3.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\NovorfayWASM\client\Pages\Profile.razor"
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
#pragma warning restore 1591
