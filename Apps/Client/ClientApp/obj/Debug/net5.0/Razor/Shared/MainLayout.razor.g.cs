#pragma checksum "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b356a6815e4580a57c4d80a52d121640f66b7d9f"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudAppBar>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                  Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 21 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
     if (idClient != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudLink>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(8);
                __builder2.AddAttribute(9, "Class", "mx-2");
                __builder2.AddAttribute(10, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                         NavigateConf

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                              Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 25 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                   Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                             Icons.Material.Filled.DesignServices

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "Конфигуратор");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(19);
                __builder2.AddAttribute(20, "Class", "mx-2");
                __builder2.AddAttribute(21, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                           () => NavMan.NavigateTo("/order")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                      Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 27 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                           Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                                                     Icons.Material.Filled.Storage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "Мои заказы");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(30);
                __builder2.AddAttribute(31, "Class", "mx-2");
                __builder2.AddAttribute(32, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 29 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                    Typo.body1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(34, 
#nullable restore
#line 29 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                 clientSOAP.fio

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(36);
                __builder2.AddAttribute(37, "Class", "mx-2");
                __builder2.AddAttribute(38, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                         Logout

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(39, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                        Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                Icons.Material.Filled.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                                      Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "Выйти");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 31 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudButton>(44);
                __builder2.AddAttribute(45, "Class", "mx-2");
                __builder2.AddAttribute(46, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                         Log_in

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(47, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                        Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                Icons.Material.Filled.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                                      Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "Войти");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(53);
                __builder2.AddAttribute(54, "Class", "mx-2");
                __builder2.AddAttribute(55, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                         Registrartion

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                               Color.Dark

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                       Icons.Material.Filled.HowToReg

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                                                                                                                                Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "Регистрация");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 36 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudSpacer>(61);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudLink>(63);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudContainer>(65);
            __builder.AddAttribute(66, "Style", "height: 700px; width:100%;");
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(68, 
#nullable restore
#line 43 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.AddMarkupContent(70, @"<footer class=""footer-dark"" style="" margin-top: 60px;
        padding: 50px 0;
        color: #f0f9ff;
        background-color: #424242;"" b-9hqbptr0vy><div class=""container"" b-9hqbptr0vy><div class=""row"" b-9hqbptr0vy><div class=""col-sm-6 col-md-3 item"" b-9hqbptr0vy><h3 b-9hqbptr0vy>Сервисы</h3>
                <ul b-9hqbptr0vy><li b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy>Web design</a></li>
                    <li b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy>Hosting</a></li></ul></div>
            <div class=""col-sm-6 col-md-3 item"" b-9hqbptr0vy><h3 b-9hqbptr0vy>Информация</h3>
                <ul b-9hqbptr0vy><li b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy>Company</a></li>
                    <li b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy>Team</a></li>
                    <li b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy>Careers</a></li></ul></div>
            <div class=""col-md-6 item text"" b-9hqbptr0vy><h3 b-9hqbptr0vy>Ювелирка</h3>
                <p b-9hqbptr0vy>Praesent sed lobortis mi. Suspendisse vel placerat ligula. Vivamus ac sem lacus. Ut vehicula rhoncus elementum. Etiam quis tristique lectus. Aliquam in arcu eget velit pulvinar dictum vel in justo.</p></div>
            <div class=""col item social"" b-9hqbptr0vy><a href=""#"" b-9hqbptr0vy><i class=""icon ion-social-snapchat"" b-9hqbptr0vy></i></a><a href=""#"" b-9hqbptr0vy><i class=""icon ion-social-instagram"" b-9hqbptr0vy></i></a></div></div>
        <p class=""copyright"" b-9hqbptr0vy>Company Name © 2021</p></div></footer>




");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(71);
            __builder.AddAttribute(72, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 79 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
                         MyCustomTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(74);
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(76);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\User\Downloads\ClientApp\ClientApp\Shared\MainLayout.razor"
 
    int idClient;
    ClientSOAP clientSOAP;
    bool isAuthenticated;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            clientSOAP = await localStorage.GetItemAsync<ClientSOAP>("login");
            if (clientSOAP != null)
            {
                idClient = clientSOAP.id_client;
                StateHasChanged();
            }
        }

    }
    protected override async Task OnInitializedAsync()
    {

    }
    MudTheme MyCustomTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = Colors.Grey.Darken3,
            Dark = Colors.Shades.White,
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        }
    }; //цвета

    void NavigateConf()
    {
        NavMan.NavigateTo("/configurator_page");
        //else Snackbar.Add("Вы не авторизованы!", Severity.Error);
    }
    void Log_in()
    {
        DialogService.Show<Login>();
    }
    void Registrartion()
    {
        DialogService.Show<Registration>();
        StateHasChanged();

    }
    void Logout()
    {
        localStorage.RemoveItemAsync("login");
        NavMan.NavigateTo("/", true);
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
    }
}
#pragma warning restore 1591
