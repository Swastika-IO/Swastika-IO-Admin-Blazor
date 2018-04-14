#pragma checksum "E:\_Workspace\Github\Swastika-IO-Admin-Blazor\src\Swastika.Admin.Blazor\Swastika.Admin.Blazor.Client\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8159ad91007647423ae6927d0e97fa574de14e38"
// <auto-generated/>
#pragma warning disable 1591
namespace Swastika.Admin.Blazor.Client.Shared
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
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main-nav");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "navbar");
            builder.AddContent(5, "\n        ");
            builder.OpenElement(6, "ul");
            builder.AddAttribute(7, "class", "nav navbar-nav");
            builder.AddContent(8, "\n            ");
            builder.OpenElement(9, "li");
            builder.AddContent(10, "\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(11);
            builder.AddAttribute(12, "href", "/");
            builder.AddAttribute(13, "Match", NavLinkMatch.All);
            builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(15, "\n                    ");
                builder2.OpenElement(16, "span");
                builder2.AddAttribute(17, "class", "glyphicon glyphicon-home");
                builder2.CloseElement();
                builder2.AddContent(18, " Home\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(19, "\n            ");
            builder.CloseElement();
            builder.AddContent(20, "\n            ");
            builder.OpenElement(21, "li");
            builder.AddContent(22, "\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(23);
            builder.AddAttribute(24, "href", "/counter");
            builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(26, "\n                    ");
                builder2.OpenElement(27, "span");
                builder2.AddAttribute(28, "class", "glyphicon glyphicon-education");
                builder2.CloseElement();
                builder2.AddContent(29, " Counter\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(30, "\n            ");
            builder.CloseElement();
            builder.AddContent(31, "\n            ");
            builder.OpenElement(32, "li");
            builder.AddContent(33, "\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(34);
            builder.AddAttribute(35, "href", "/fetchdata");
            builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(37, "\n                    ");
                builder2.OpenElement(38, "span");
                builder2.AddAttribute(39, "class", "glyphicon glyphicon-th-list");
                builder2.CloseElement();
                builder2.AddContent(40, " Fetch data\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(41, "\n            ");
            builder.CloseElement();
            builder.AddContent(42, "\n            ");
            builder.OpenElement(43, "li");
            builder.AddContent(44, "\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(45);
            builder.AddAttribute(46, "href", "/portal");
            builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(48, "\n                    ");
                builder2.OpenElement(49, "span");
                builder2.AddAttribute(50, "class", "glyphicon glyphicon-th-list");
                builder2.CloseElement();
                builder2.AddContent(51, " Portal\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(52, "\n            ");
            builder.CloseElement();
            builder.AddContent(53, "\n        ");
            builder.CloseElement();
            builder.AddContent(54, "\n    ");
            builder.CloseElement();
            builder.AddContent(55, "\n");
            builder.CloseElement();
            builder.AddContent(56, "\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
