#pragma checksum "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112633422c1cdc2b3e015d6cd89414e889e52413"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Downloads\ClientApp\ClientApp\_Imports.razor"
using ClientApp.Pages;

#line default
#line hidden
#nullable disable
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(5);
                    __builder3.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                            Icons.Material.Filled.Login

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "mr-3 mb-n1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            Вход\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(9, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.ClientApp.Pages.Login.TypeInference.CreateMudTextField_0(__builder2, 10, 11, 
#nullable restore
#line 14 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                     true

#line default
#line hidden
#nullable disable
                , 12, "Логин", 13, 
#nullable restore
#line 14 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                , 14, 
#nullable restore
#line 14 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                   login

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => login = __value, login)));
                __builder2.AddMarkupContent(16, "\r\n        ");
                __Blazor.ClientApp.Pages.Login.TypeInference.CreateMudTextField_1(__builder2, 17, 18, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                        true

#line default
#line hidden
#nullable disable
                , 19, "Пароль", 20, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                , 21, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                          PasswordInput

#line default
#line hidden
#nullable disable
                , 22, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                                                    Adornment.End

#line default
#line hidden
#nullable disable
                , 23, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                                                                                   PasswordInputIcon

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                        ButtonTestclick

#line default
#line hidden
#nullable disable
                ), 25, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                   password

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => password = __value, password)));
            }
            ));
            __builder.AddAttribute(27, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(28);
                __builder2.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "Отмена");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(33);
                __builder2.AddAttribute(34, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                               string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ? true : false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                                     Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Login.razor"
                                                                                                                                           Log_in

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "Войти");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SOAPService soap { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.ClientApp.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Immediate", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Clearable", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::MudBlazor.InputType __arg3, int __seq4, global::MudBlazor.Adornment __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg6, int __seq7, T __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Immediate", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Clearable", __arg2);
        __builder.AddAttribute(__seq3, "InputType", __arg3);
        __builder.AddAttribute(__seq4, "Adornment", __arg4);
        __builder.AddAttribute(__seq5, "AdornmentIcon", __arg5);
        __builder.AddAttribute(__seq6, "OnAdornmentClick", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
