// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('ShowAlert', (message) => {
    alert(message);
    Blazor.invokeDotNetMethod(
        {
            type: {
                assembly: "MySharedBlazorLib",
                name: "MySharedBlazorLib.WindowFunctions"
            },
            method: {
                name: "AlertShowCallback"
            }
        },
        "calling dotnet method"
    );
});

