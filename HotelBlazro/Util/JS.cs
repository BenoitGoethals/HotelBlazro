using System.Threading.Tasks;
using Microsoft.JSInterop;


namespace HotelBlazro.Util
{
    public static class JS
    {
        public static async Task ShowSucces(this IJSRuntime runtime,string msg)
        {
            await runtime.InvokeVoidAsync("ShowSwal","success",msg);
        }
    }
}