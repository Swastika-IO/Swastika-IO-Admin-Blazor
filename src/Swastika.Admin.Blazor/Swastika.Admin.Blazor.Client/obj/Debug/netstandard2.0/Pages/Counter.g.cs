#pragma checksum "E:\_Workspace\Github\Swastika-IO-Admin-Blazor\src\Swastika.Admin.Blazor\Swastika.Admin.Blazor.Client\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ad2dd449cbc9f09f8b759e1f06e7eb5e9583b4"
// <auto-generated/>
#pragma warning disable 1591
namespace Swastika.Admin.Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Swastika.Admin.Blazor.Client;
    using Swastika.Admin.Blazor.Client.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Counter");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "Current count: ");
            builder.AddContent(5, currentCount);
            builder.CloseElement();
            builder.AddContent(6, "\n\n");
            builder.OpenElement(7, "button");
            builder.AddAttribute(8, onclick(IncrementCount));
            builder.AddContent(9, "Click me");
            builder.CloseElement();
            builder.AddContent(10, "\n\n");
        }
        #pragma warning restore 1998
        
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }
    }
}
#pragma warning restore 1591
