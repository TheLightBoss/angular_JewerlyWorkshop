// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/conf_osobenn")]
    public partial class Conf_Osobenn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\User\Downloads\ClientApp\ClientApp\Pages\Conf_Osobenn.razor"
       
    string spec1, spec2, spec3, nameTip, chh;
    public IList<RefProd> izdelies = Conf_tipizd.izdelies;
    public IList<RefProd> need = new List<RefProd>();
    public static RefProd selectedIzd;

    protected override void OnInitialized()
    {

        if (Conf_tipizd.selectedTip == 1)
        {
            nameTip = "гравировку для кольца";
            chh = "кольцо";
        }
        if (Conf_tipizd.selectedTip == 2)
        {
            nameTip = "камень для кольца";
            chh = "с камнем";
        }
        if (Conf_tipizd.selectedTip == 3)
        {
            nameTip = "плетение цепочки";
            chh = "цепь";
        }
        foreach (var i in izdelies)
        {
            if (i.id_material == Configurator_page.result && i.types_pr == chh)
            {
                need.Add(i);
            }
        }
        spec1 = need[0].url_pic;
        spec2 = need[1].url_pic;
        spec3 = need[2].url_pic;//ДОБАВИТЬ ДО КОНЦА ВСЕ ИЗДЕЛИЯ
    }
    private void OpenCol()
    {
        selectedIzd = need[0];
        NavigationManager.NavigateTo("final_zakaz");
    }
    private void OpenCam()
    {
        selectedIzd = need[1];
        NavigationManager.NavigateTo("final_zakaz");
    }
    private void OpenCep()
    {
        selectedIzd = need[2];
        NavigationManager.NavigateTo("final_zakaz");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RefProdService Service { get; set; }
    }
}
#pragma warning restore 1591
