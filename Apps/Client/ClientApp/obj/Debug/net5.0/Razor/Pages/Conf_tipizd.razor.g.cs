#pragma checksum "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52053abdf4f53d29c408d6750e2b4d6feed3a151"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/conf_tipizd")]
    public partial class Conf_tipizd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(3);
                __builder2.AddAttribute(4, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                   Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 6 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                   Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "Конфигуратор изделий");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudText>(10);
                __builder2.AddAttribute(11, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                   Typo.h5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 7 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                   Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "Выберите тип изделия");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(16);
                __builder2.AddAttribute(17, "Class", "mt-8");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(19);
                    __builder3.AddAttribute(20, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(24);
                        __builder4.AddAttribute(25, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Class", "rounded-lg pb-4 mudblazor-goal-paper in-c");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(28);
                            __builder5.AddAttribute(29, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(30);
                                __builder6.AddAttribute(31, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(32, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 13 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(34, "Кольцо");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(35, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(36);
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(38, "div");
                                __builder6.AddAttribute(39, "class", "d-flex justify-center");
                                __builder6.OpenElement(40, "img");
                                __builder6.AddAttribute(41, "class", "mud-elevation-4");
                                __builder6.AddAttribute(42, "src", 
#nullable restore
#line 18 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                           colco

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(43, "width", "230");
                                __builder6.AddAttribute(44, "height", "200");
                                __builder6.AddAttribute(45, "alt", "кольцо");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(47);
                            __builder5.AddAttribute(48, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(50);
                                __builder6.AddAttribute(51, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 22 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(52, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(53, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                       OpenCol

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(54, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 22 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                                      Size.Large

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "Style", "width:50%;");
                                __builder6.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(57, "Выбрать");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(59);
                    __builder3.AddAttribute(60, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(64);
                        __builder4.AddAttribute(65, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "Class", "rounded-lg pb-4");
                        __builder4.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(68);
                            __builder5.AddAttribute(69, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(70);
                                __builder6.AddAttribute(71, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(72, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 30 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(74, "Кольцо с камнем");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(76);
                            __builder5.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(78, "div");
                                __builder6.AddAttribute(79, "class", "d-flex justify-center");
                                __builder6.OpenElement(80, "img");
                                __builder6.AddAttribute(81, "class", "mud-elevation-4");
                                __builder6.AddAttribute(82, "src", 
#nullable restore
#line 35 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                           camen

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(83, "width", "230");
                                __builder6.AddAttribute(84, "height", "200");
                                __builder6.AddAttribute(85, "alt", "кольцо с камнем");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(87);
                            __builder5.AddAttribute(88, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(90);
                                __builder6.AddAttribute(91, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 40 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(92, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(93, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                       OpenCam

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(94, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 40 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                                      Size.Large

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(95, "Style", "width:50%;");
                                __builder6.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(97, "Выбрать");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(99);
                    __builder3.AddAttribute(100, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(104);
                        __builder4.AddAttribute(105, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(106, "Class", "rounded-lg pb-4");
                        __builder4.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(108);
                            __builder5.AddAttribute(109, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(110);
                                __builder6.AddAttribute(111, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 49 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(112, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 49 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(114, "Цепь");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(115, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(116);
                            __builder5.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(118, "div");
                                __builder6.AddAttribute(119, "class", "d-flex justify-center");
                                __builder6.OpenElement(120, "img");
                                __builder6.AddAttribute(121, "class", "mud-elevation-4");
                                __builder6.AddAttribute(122, "src", 
#nullable restore
#line 54 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                           cepochka

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(123, "width", "230");
                                __builder6.AddAttribute(124, "height", "200");
                                __builder6.AddAttribute(125, "alt", "цепь");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(126, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(127);
                            __builder5.AddAttribute(128, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(130);
                                __builder6.AddAttribute(131, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 59 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(132, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(133, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                       OpenCep

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(134, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 59 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
                                                                                                      Size.Large

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(135, "Style", "width:50%;");
                                __builder6.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(137, "Выбрать");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_tipizd.razor"
       

    string colco, cepochka, camen;
    int idMat;
    public static int selectedTip;
    public static IList<RefProd> izdelies;

    protected override void OnInitialized()
    {
        idMat = Configurator_page.result;
        izdelies = Service.GetRefProds();
        foreach (var i in izdelies)
        {
            if (i.types_pr == "кольцо" && i.id_material == idMat)
            {
                colco = i.url_pic;

            }
            if (i.types_pr == "с камнем" && i.id_material == idMat)
            {
                camen = i.url_pic;

            }
            if (i.types_pr == "цепь" && i.id_material == idMat)
            {
                cepochka = i.url_pic;

            }
        }

    }

    private void OpenCol()
    {
        selectedTip = 1;
        NavigationManager.NavigateTo("conf_osobenn");
    }
    private void OpenCam()
    {
        selectedTip = 2;
        NavigationManager.NavigateTo("conf_osobenn");
    }
    private void OpenCep()
    {
        selectedTip = 3;
        NavigationManager.NavigateTo("conf_osobenn");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RefProdService Service { get; set; }
    }
}
#pragma warning restore 1591
