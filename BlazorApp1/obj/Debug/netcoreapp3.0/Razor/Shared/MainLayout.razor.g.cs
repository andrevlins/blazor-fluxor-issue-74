#pragma checksum "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82bdf862c97b9f6e8dedd6820026d70cbfcc5d73"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#line 7 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddContent(0, 
#line 4 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\Shared\MainLayout.razor"
 Store.Initialize()

#line default
#line hidden
            );
            builder.AddMarkupContent(1, "\r\n\r\n");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "sidebar");
            builder.AddMarkupContent(4, "\r\n    ");
            builder.OpenComponent<BlazorApp1.Shared.NavMenu>(5);
            builder.CloseComponent();
            builder.AddMarkupContent(6, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(7, "\r\n\r\n");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "main");
            builder.AddMarkupContent(10, "\r\n    ");
            builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            builder.OpenElement(12, "div");
            builder.AddAttribute(13, "class", "content px-4");
            builder.AddMarkupContent(14, "\r\n        ");
            builder.AddContent(15, 
#line 16 "C:\Users\avl\source\repos\BlazorApp1\BlazorApp1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            builder.AddMarkupContent(16, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(17, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Fluxor.IStore Store { get; set; }
    }
}
#pragma warning restore 1591
