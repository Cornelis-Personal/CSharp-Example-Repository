#pragma checksum "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e22bed94befdc8bf76838cd12e58498446c709"
// <auto-generated/>
#pragma warning disable 1591
namespace Cornelis.Examples.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\source\repos\Cornelis.Examples.Blazor\Cornelis.Examples.Blazor\_Imports.razor"
using Cornelis.Examples.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Title>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Hello, world!");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Blazorise.Label>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, @"
    Welcome to my Blazor example. This example is meant to integrate with an SQL Server Database using code first.

    You can add a database by changing the Appsettings.json connectionstring, Selecting the Cornelis.Examples.DataAccess project in package manager and
    running following command in package manager: ");
                __builder2.AddMarkupContent(7, "<code>Update-Database</code>.\r\n\r\n    In the project you will also find:\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
