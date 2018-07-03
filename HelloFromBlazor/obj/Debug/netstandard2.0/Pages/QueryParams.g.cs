#pragma checksum "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\QueryParams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead1a84c6fd702f146f44b32cbda5a060f463578"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/query-params")]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/query-params/{text}")]
    public class QueryParams : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h3");
            builder.AddContent(1, "Query String Value");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.AddContent(3, Text);
        }
        #pragma warning restore 1998
#line 5 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\QueryParams.cshtml"
           
    [Parameter]
    private string Text { get; set; } = "DefaultValue";

#line default
#line hidden
    }
}
#pragma warning restore 1591
