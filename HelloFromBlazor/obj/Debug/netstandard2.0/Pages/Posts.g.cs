#pragma checksum "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155e7fa8269166fb9d562af1f788aa8886b54bdf"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/posts")]
    public class Posts : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h2");
            builder.AddContent(1, "User Posts");
            builder.CloseElement();
            builder.AddContent(2, "\n");
#line 22 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"
 if (postList == null)
{

#line default
#line hidden
            builder.AddContent(3, "    ");
            builder.OpenElement(4, "h3");
            builder.AddContent(5, "Loading.....posts");
            builder.CloseElement();
            builder.AddContent(6, "\n");
#line 25 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"

}
else
{

#line default
#line hidden
            builder.AddContent(7, "    ");
            builder.OpenElement(8, "table");
            builder.AddAttribute(9, "class", "table");
            builder.AddContent(10, "\n        ");
            builder.OpenElement(11, "tr");
            builder.AddContent(12, "\n            ");
            builder.OpenElement(13, "th");
            builder.AddContent(14, "Title");
            builder.CloseElement();
            builder.AddContent(15, "\n            ");
            builder.OpenElement(16, "th");
            builder.AddContent(17, "Summary");
            builder.CloseElement();
            builder.AddContent(18, "\n        ");
            builder.CloseElement();
            builder.AddContent(19, "\n");
#line 34 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"
         foreach (Post post in postList)
        {

#line default
#line hidden
            builder.AddContent(20, "            ");
            builder.OpenElement(21, "tr");
            builder.AddContent(22, "\n                ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, post.title);
            builder.CloseElement();
            builder.AddContent(25, "\n                ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, post.body);
            builder.CloseElement();
            builder.AddContent(28, "\n            ");
            builder.CloseElement();
            builder.AddContent(29, "\n");
#line 40 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"
        }

#line default
#line hidden
            builder.AddContent(30, "    ");
            builder.CloseElement();
            builder.AddContent(31, "\n");
#line 42 "C:\Users\vsi124.SAPIENT\BlazorProjects\HelloFromBlazor\Pages\Posts.cshtml"
}

#line default
#line hidden
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
