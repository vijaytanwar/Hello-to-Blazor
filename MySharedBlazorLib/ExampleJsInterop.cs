using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace MySharedBlazorLib
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "MySharedBlazorLib.ExampleJsInterop.Prompt",
                message);
        }
    }
}
