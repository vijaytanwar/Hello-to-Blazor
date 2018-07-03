#pragma checksum "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Child.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477f8b5455c0b4d424e155c85a0cdd92c00682a6"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloFromBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using HelloFromBlazor;
    using HelloFromBlazor.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    public class Child : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h4");
            builder.AddContent(1, Title);
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, ChildContent);
            builder.CloseElement();
            builder.AddContent(5, "\n");
            builder.OpenElement(6, "p");
            builder.AddContent(7, "Child Year: ");
            builder.AddContent(8, ChildYear);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 1 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Child.cshtml"
           
    [Parameter]
    private RenderFragment ChildContent { get; set; }

    [Parameter]
    private string Title { get; set; }

    [Parameter]
    private int ChildYear { get; set; }

    [Parameter]
    private Action<int> ChildYearChanged { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591