#pragma checksum "E:\_Workspace\Github\Swastika-IO-Admin-Blazor\src\Swastika.Admin.Blazor\Swastika.Admin.Blazor.Client\Pages\portal\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378d7868d5b0b4c7ca86539d403eb92aca6d1a71"
// <auto-generated/>
#pragma warning disable 1591
namespace Swastika.Admin.Blazor.Client.Pages.portal
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(PortalLayout))]

    public class Dashboard : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddContent(0, "\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "row sortable ui-sortable");
            builder.AddContent(3, "\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "col-sm-4 ui-sortable-handle");
            builder.AddContent(6, "\n        ");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "card draggable1");
            builder.AddContent(9, "\n            ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "card-body");
            builder.AddContent(12, "\n                ");
            builder.OpenElement(13, "h4");
            builder.AddAttribute(14, "class", "card-title");
            builder.AddContent(15, "CMS");
            builder.CloseElement();
            builder.AddContent(16, "\n                ");
            builder.OpenElement(17, "p");
            builder.AddAttribute(18, "class", "card-text");
            builder.AddContent(19, "With supporting text below as a natural lead-in to additional content.");
            builder.CloseElement();
            builder.AddContent(20, "\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(21);
            builder.AddAttribute(22, "href", "/portal/cms");
            builder.AddAttribute(23, "class", "btn btn-primary");
            builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(25, "\n                    ");
                builder2.OpenElement(26, "span");
                builder2.AddAttribute(27, "class", "glyphicon glyphicon-education");
                builder2.CloseElement();
                builder2.AddContent(28, " CMS Dashboard\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(29, "\n            ");
            builder.CloseElement();
            builder.AddContent(30, "\n        ");
            builder.CloseElement();
            builder.AddContent(31, "\n    ");
            builder.CloseElement();
            builder.AddContent(32, "\n    ");
            builder.OpenElement(33, "div");
            builder.AddAttribute(34, "class", "col-sm-4 ui-sortable-handle");
            builder.AddContent(35, "\n        ");
            builder.OpenElement(36, "div");
            builder.AddAttribute(37, "class", "card draggable1");
            builder.AddContent(38, "\n            ");
            builder.OpenElement(39, "div");
            builder.AddAttribute(40, "class", "card-body");
            builder.AddContent(41, "\n                ");
            builder.OpenElement(42, "h4");
            builder.AddAttribute(43, "class", "card-title");
            builder.AddContent(44, "eCommerce");
            builder.CloseElement();
            builder.AddContent(45, "\n                ");
            builder.OpenElement(46, "p");
            builder.AddAttribute(47, "class", "card-text");
            builder.AddContent(48, "With supporting text below as a natural lead-in to additional content.");
            builder.CloseElement();
            builder.AddContent(49, "\n\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(50);
            builder.AddAttribute(51, "href", "/portal/ecom");
            builder.AddAttribute(52, "class", "btn btn-primary");
            builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(54, "\n                    ");
                builder2.OpenElement(55, "span");
                builder2.AddAttribute(56, "class", "glyphicon glyphicon-education");
                builder2.CloseElement();
                builder2.AddContent(57, " eCom Dashboard\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(58, "\n            ");
            builder.CloseElement();
            builder.AddContent(59, "\n        ");
            builder.CloseElement();
            builder.AddContent(60, "\n    ");
            builder.CloseElement();
            builder.AddContent(61, "\n    ");
            builder.OpenElement(62, "div");
            builder.AddAttribute(63, "class", "col-sm-4 ui-sortable-handle");
            builder.AddContent(64, "\n        ");
            builder.OpenElement(65, "div");
            builder.AddAttribute(66, "class", "card draggable1");
            builder.AddContent(67, "\n            ");
            builder.OpenElement(68, "div");
            builder.AddAttribute(69, "class", "card-body");
            builder.AddContent(70, "\n                ");
            builder.OpenElement(71, "h4");
            builder.AddAttribute(72, "class", "card-title");
            builder.AddContent(73, "Forum");
            builder.CloseElement();
            builder.AddContent(74, "\n                ");
            builder.OpenElement(75, "p");
            builder.AddAttribute(76, "class", "card-text");
            builder.AddContent(77, "With supporting text below as a natural lead-in to additional content.");
            builder.CloseElement();
            builder.AddContent(78, "\n\n                ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(79);
            builder.AddAttribute(80, "href", "/portal/forum");
            builder.AddAttribute(81, "class", "btn btn-primary");
            builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddContent(83, "\n                    ");
                builder2.OpenElement(84, "span");
                builder2.AddAttribute(85, "class", "glyphicon glyphicon-education");
                builder2.CloseElement();
                builder2.AddContent(86, " Forum Dashboard\n                ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(87, "\n            ");
            builder.CloseElement();
            builder.AddContent(88, "\n        ");
            builder.CloseElement();
            builder.AddContent(89, "\n    ");
            builder.CloseElement();
            builder.AddContent(90, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591