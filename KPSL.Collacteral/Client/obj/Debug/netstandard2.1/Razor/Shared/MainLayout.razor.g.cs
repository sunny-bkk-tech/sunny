#pragma checksum "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b5aefc328a7081c015924d927c9f1845dd71e9"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/Shared/MainLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n  ");
            __builder.OpenComponent<KPSL.Collacteral.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n  ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\n        Hello, ");
                __builder2.AddContent(15, 
#nullable restore
#line 11 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/Shared/MainLayout.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.AddMarkupContent(17, "<a href=\"/Logout\">Log out</a>\n      ");
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.AddMarkupContent(20, "<a href=\"/Login\">Log in</a>\n      ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.AddMarkupContent(22, "<a href=\"https://cslanet.com\" target=\"_blank\">About</a>\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n  ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "content px-4");
            __builder.AddMarkupContent(26, "\n    ");
            __builder.AddContent(27, 
#nullable restore
#line 22 "/Users/Hachintosh-oldData/Users/sunny/test/KPSL.Collacteral/Client/Shared/MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591