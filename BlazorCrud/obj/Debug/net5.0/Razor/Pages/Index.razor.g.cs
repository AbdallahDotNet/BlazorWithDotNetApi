#pragma checksum "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "262b910adb9847dbbf63d272eaff67257d192874"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "btn btn-success");
            __builder.AddAttribute(2, "href", "add");
            __builder.AddAttribute(3, "style", "color:#fff");
            __builder.AddAttribute(4, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, "Add");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n<hr>");
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
 if (CarsList.Count() < 1 || CarsList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<div class=\"alert alert-danger\">no items</div>");
#nullable restore
#line 9 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
     foreach (var item in CarsList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorCrud.Pages.DisplayCar>(9);
            __builder.AddAttribute(10, "carViewModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Interfaces.ViewModels.CarViewModel.GetCarViewModel>(
#nullable restore
#line 14 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                  item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "refillCarList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 14 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
                                                       Refill

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
