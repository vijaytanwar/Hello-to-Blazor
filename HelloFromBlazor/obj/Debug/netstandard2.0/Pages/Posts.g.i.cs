#pragma checksum "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155e7fa8269166fb9d562af1f788aa8886b54bdf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/posts")]
    public class Posts : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 4 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"
           
    class Post
    {
        public int userId;
        public int id;
        public string title;
        public string body;
    }

    Post[] postList;

    protected override async Task OnInitAsync()
    {
        postList = await http.GetJsonAsync<Post[]>("https://jsonplaceholder.typicode.com/posts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591