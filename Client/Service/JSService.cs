using Microsoft.JSInterop;

namespace EnvSelector.Client.Service{

    public class JSService{
        private readonly IJSRuntime JS;
        public JSService(IJSRuntime jsRuntime)
        {
            JS = jsRuntime;
        }

        public async Task Reload(){
            await JS.InvokeVoidAsync("location.reload");
        }

        public async Task<string> GetFromLocalStorage(string key, string defaultValue){
            string value = await JS.InvokeAsync<string>("localStorage.getItem", key);
            return value ?? defaultValue;
        }

        public async Task SetToLocalStorage(string key, string value){
            await JS.InvokeVoidAsync("localStorage.setItem", key, value);
        }
    }
}