#pragma checksum "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c4abc0ef5c3b8a30de64b6377e9682f5f6595c7"
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
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(5);
                    __builder3.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                            Icons.Material.Filled.Login

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "mr-3 mb-n1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            Регистрация\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(9, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_0(__builder2, 10, 11, "ФИО", 12, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                      true

#line default
#line hidden
#nullable disable
                , 13, 
#nullable restore
#line 15 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.fio

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.fio = __value, client.fio)));
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_1(__builder2, 16, 17, "Реквизиты", 18, 
#nullable restore
#line 16 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                , 19, 
#nullable restore
#line 16 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.requisites

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.requisites = __value, client.requisites)));
                __builder2.AddMarkupContent(21, "\r\n        ");
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_2(__builder2, 22, 23, "Адрес", 24, 
#nullable restore
#line 17 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
                , 25, 
#nullable restore
#line 17 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.address_live

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.address_live = __value, client.address_live)));
                __builder2.AddMarkupContent(27, "\r\n        ");
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_3(__builder2, 28, 29, "Конт. данные", 30, 
#nullable restore
#line 18 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                , 31, 
#nullable restore
#line 18 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.contact_face

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.contact_face = __value, client.contact_face)));
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_4(__builder2, 34, 35, "Логин", 36, 
#nullable restore
#line 19 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                , 37, 
#nullable restore
#line 19 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.login

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.login = __value, client.login)));
                __builder2.AddMarkupContent(39, "\r\n        ");
                __Blazor.ClientApp.Pages.Registration.TypeInference.CreateMudTextField_5(__builder2, 40, 41, "Пароль", 42, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                , 43, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                                     PasswordInput

#line default
#line hidden
#nullable disable
                , 44, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                                                               Adornment.End

#line default
#line hidden
#nullable disable
                , 45, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                                                                                              PasswordInputIcon

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                                                                                                                                                                                   ButtonTestclick

#line default
#line hidden
#nullable disable
                ), 47, 
#nullable restore
#line 20 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                   client.password_hash

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.password_hash = __value, client.password_hash)));
            }
            ));
            __builder.AddAttribute(49, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(50);
                __builder2.AddAttribute(51, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "Отмена");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(55);
                __builder2.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                          Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
                                               RegistrationS

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "Зарегистрироваться");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Registration.razor"
      
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    ClientSOAP client = new();

    void Cancel()
    {
        MudDialog.Cancel();
    }
    bool isShow;
    InputType PasswordInput = InputType.Password;
    string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

    void ButtonTestclick()
    {
        if (isShow)
        {
            isShow = false;
            PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            PasswordInput = InputType.Password;
        }
        else
        {
            isShow = true;
            PasswordInputIcon = Icons.Material.Filled.Visibility;
            PasswordInput = InputType.Text;
        }
    }
    void RegistrationS()
    {
        var result = soap.Registration(client);

        if (result != null)
        {
            localStorage.SetItemAsync("login", result);
            navigationManager.NavigateTo("/", true);
        }
        else Snackbar.Add("Ошибка логина", Severity.Error);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SOAPService soap { get; set; }
    }
}
namespace __Blazor.ClientApp.Pages.Registration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.InputType __arg2, int __seq3, global::MudBlazor.Adornment __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Clearable", __arg1);
        __builder.AddAttribute(__seq2, "InputType", __arg2);
        __builder.AddAttribute(__seq3, "Adornment", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentIcon", __arg4);
        __builder.AddAttribute(__seq5, "OnAdornmentClick", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
