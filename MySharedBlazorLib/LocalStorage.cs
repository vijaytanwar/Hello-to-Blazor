using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;
using Newtonsoft.Json;

namespace MySharedBlazorLib
{
    public class LocalStorage
    {
        private class StoreItem<T>
        {
            public T obj;
            public string key;
        }

        public static void SetItem<T>(string key, T obj)
        {
            var finalObj = new StoreItem<T>() { obj = obj, key = key };
            var str = JsonConvert.SerializeObject(finalObj);
            RegisteredFunction.Invoke<string>("localStorage.setItem", str);
        }

        public static T GetItem<T>(string key)
        {
            var str = RegisteredFunction.Invoke<string>("localStorage.getItem", key);
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
