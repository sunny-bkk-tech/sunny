#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8db72b0152d520bc13f2e49c9f1cda0625e14b74"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
using KPSL.Collacteral.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
using Csla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
using Csla.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
using Csla.Blazor.Client.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "class", "text-danger");
            __builder.AddContent(3, 
#nullable restore
#line 13 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
                        vm.ViewModelErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
#nullable restore
#line 15 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
 if (vm.Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "  ");
            __builder.AddMarkupContent(6, "<div>Loading...</div>\n");
#nullable restore
#line 18 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "  ");
            __builder.OpenElement(8, "table");
            __builder.AddMarkupContent(9, "\n    ");
            __builder.AddMarkupContent(10, "<thead>\n      <tr>\n        <th></th>\n        <th></th>\n      </tr>\n    </thead>\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\n      ");
            __builder.OpenComponent<KPSL.Collacteral.Client.Shared.TextInputRow>(13);
            __builder.AddAttribute(14, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Csla.Blazor.IPropertyInfo>(
#nullable restore
#line 29 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
                              vm.GetPropertyInfo(nameof(vm.Model.Username))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n      ");
            __builder.OpenComponent<KPSL.Collacteral.Client.Shared.TextInputRow>(16);
            __builder.AddAttribute(17, "Property", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Csla.Blazor.IPropertyInfo>(
#nullable restore
#line 30 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
                              vm.GetPropertyInfo(nameof(vm.Model.Password))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "InputType", "password");
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n  ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
                    VerifyCredentials

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "disabled", 
#nullable restore
#line 33 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
                                                   !vm.Model.IsSavable

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 34 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Login.razor"
       
  protected override void OnInitialized()
  {
    vm.ModelPropertyChanged += async (s, e) => await InvokeAsync(() => StateHasChanged());
  }

  protected override async Task OnParametersSetAsync()
  {
    await vm.RefreshAsync();
  }

  private async void VerifyCredentials()
  {

    var identity = await DataPortal.FetchAsync<CustomIdentity>(vm.Model); 
    var baseidentity = new ClaimsIdentity(identity.AuthenticationType); 

    if (identity.Roles != null)
      foreach (var item in identity.Roles) 
      baseidentity.AddClaim(new Claim(ClaimTypes.Name, identity.Name));
      baseidentity.AddClaim(new Claim(ClaimTypes.Role, identity.Name));
      var principal = new System.Security.Claims.ClaimsPrincipal(baseidentity); 
      userService.CurrentUser = principal;
      StateHasChanged();
      nav.NavigateTo("/");
  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CslaUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ViewModel<UserCredentials> vm { get; set; }
    }
}
#pragma warning restore 1591
