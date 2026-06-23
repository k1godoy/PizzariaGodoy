using Microsoft.AspNetCore.Components.Web;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.JSInterop;
namespace Pizzaria_Godoy.Services.Extensions
{
    public static class IJSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }
}