#pragma checksum "E:\_Workspace\Github\Swastika-IO-Admin-Blazor\src\Swastika.Admin.Blazor\Swastika.Admin.Blazor.Client\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8328161a9f0eb9df222918dbcd4ae1834d568ade"
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
            builder.AddAttribute(4, "class", "navbar navbar-inverse");
            builder.AddContent(5, "\n        ");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "navbar-header");
            builder.AddContent(8, "\n            ");
            builder.OpenElement(9, "button");
            builder.AddAttribute(10, "type", "button");
            builder.AddAttribute(11, "class", "navbar-toggle");
            builder.AddAttribute(12, "data-toggle", "collapse");
            builder.AddAttribute(13, "data-target", ".navbar-collapse");
            builder.AddContent(14, "\n                ");
            builder.OpenElement(15, "span");
            builder.AddAttribute(16, "class", "sr-only");
            builder.AddContent(17, "Toggle navigation");
            builder.CloseElement();
            builder.AddContent(18, "\n                ");
            builder.OpenElement(19, "span");
            builder.AddAttribute(20, "class", "icon-bar");
            builder.CloseElement();
            builder.AddContent(21, "\n                ");
            builder.OpenElement(22, "span");
            builder.AddAttribute(23, "class", "icon-bar");
            builder.CloseElement();
            builder.AddContent(24, "\n                ");
            builder.OpenElement(25, "span");
            builder.AddAttribute(26, "class", "icon-bar");
            builder.CloseElement();
            builder.AddContent(27, "\n            ");
            builder.CloseElement();
            builder.AddContent(28, "\n            ");
            builder.OpenElement(29, "a");
            builder.AddAttribute(30, "class", "navbar-brand");
            builder.AddAttribute(31, "href", "/");
            builder.AddContent(32, "Swastika.Admin.Blazor");
            builder.CloseElement();
            builder.AddContent(33, "\n        ");
            builder.CloseElement();
            builder.AddContent(34, "\n        ");
            builder.OpenElement(35, "div");
            builder.AddAttribute(36, "class", "clearfix");
            builder.CloseElement();
            builder.AddContent(37, "\n        ");
            builder.OpenElement(38, "div");
            builder.AddAttribute(39, "class", "navbar-collapse collapse");
            builder.AddContent(40, "\n            ");
            builder.OpenElement(41, "ul");
            builder.AddAttribute(42, "class", "nav navbar-nav");
            builder.AddContent(43, "\n                ");
            builder.OpenElement(44, "li");
            builder.AddContent(45, "\n                    ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(46);
            builder.AddAttribute(47, "href", "/");
            builder.AddAttribute(48, "Match", NavLinkMatch.All);
            builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(50, "\n                        ");
                builder2.OpenElement(51, "span");
                builder2.AddAttribute(52, "class", "glyphicon glyphicon-home");
                builder2.CloseElement();
                builder2.AddContent(53, " Home\n                    ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(54, "\n                ");
            builder.CloseElement();
            builder.AddContent(55, "\n                ");
            builder.OpenElement(56, "li");
            builder.AddContent(57, "\n                    ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(58);
            builder.AddAttribute(59, "href", "/counter");
            builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(61, "\n                        ");
                builder2.OpenElement(62, "span");
                builder2.AddAttribute(63, "class", "glyphicon glyphicon-education");
                builder2.CloseElement();
                builder2.AddContent(64, " Counter\n                    ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(65, "\n                ");
            builder.CloseElement();
            builder.AddContent(66, "\n                ");
            builder.OpenElement(67, "li");
            builder.AddContent(68, "\n                    ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(69);
            builder.AddAttribute(70, "href", "/fetchdata");
            builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(72, "\n                        ");
                builder2.OpenElement(73, "span");
                builder2.AddAttribute(74, "class", "glyphicon glyphicon-th-list");
                builder2.CloseElement();
                builder2.AddContent(75, " Fetch data\n                    ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(76, "\n                ");
            builder.CloseElement();
            builder.AddContent(77, "\n            ");
            builder.CloseElement();
            builder.AddContent(78, "\n        ");
            builder.CloseElement();
            builder.AddContent(79, "\n    ");
            builder.CloseElement();
            builder.AddContent(80, "\n");
            builder.CloseElement();
            builder.AddContent(81, "\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
