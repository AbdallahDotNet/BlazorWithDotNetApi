#pragma checksum "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6558b5a50310f8b7d1fe35137d1a81fde2d77f"
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
    public partial class DisplayCar : DisplayCarBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-info");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                               carViewModel.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, "  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "class", "btn btn-warning");
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                                                                                           $"update/{carViewModel.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "style", "color:#fff");
            __builder.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                                                                                                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddContent(11, " | ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "class", "btn btn-danger");
            __builder.AddAttribute(14, "style", "color:#fff");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                                                                                                                                                                                                                                             showModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<BlazorCrud.Pages.ConfirmDelete>(18);
            __builder.AddAttribute(19, "onChangeModelState", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                                                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(20, (__value) => {
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorCrud\BlazorCrud\Pages\DisplayCar.razor"
                     deleteBase = (BlazorCrud.Pages.ConfirmDelete)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
