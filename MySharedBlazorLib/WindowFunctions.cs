using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace MySharedBlazorLib
{
    public class WindowFunctions
    {
        public static void Alert(string msg)
        {
            RegisteredFunction.Invoke<string>("ShowAlert", msg);
        }

        public static string AlertShowCallback(string msg)
        {
            Console.WriteLine(msg);
            return "message written";
        }
    }
}
