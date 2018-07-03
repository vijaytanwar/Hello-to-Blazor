// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('localStorage.setItem', function (objString) {
    const obj = JSON.parse(objString);
    localStorage.setItem(obj.key, obj.obj);
});

Blazor.registerFunction('localStorage.getItem', function (key) {
    return localStorage.getItem(key);
});
