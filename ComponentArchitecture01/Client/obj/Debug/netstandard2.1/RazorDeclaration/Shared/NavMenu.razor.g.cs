#pragma checksum "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daca60b6e8a4309c9ba347f24fa901edb9518622"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComponentArchitecture01.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using ComponentArchitecture01.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using ComponentArchitecture01.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\_Imports.razor"
using ComponentArchitecture01.Client.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Projeler\WebAssemblyAndBlazor\ComponentArchitecture01\ComponentArchitecture01\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
