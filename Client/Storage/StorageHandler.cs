using Microsoft.JSInterop;
using EnvSelector.Client.Service;

namespace EnvSelector.Client.Storage
{
    public class StorageHandler
    {
        private readonly JSService JSService;
        public StorageHandler(JSService jSService)
        {
            JSService = jSService;
        }

        public async Task<ServiceEnvironment> GetEnvironment()
        {
                string value = await JSService.GetFromLocalStorage("environment", ServiceEnvironment.Production.Value);
                return new ServiceEnvironment(value);
        }
        
        public async Task SetEnvironment(ServiceEnvironment value)
        {
            await JSService.SetToLocalStorage("environment", value.Value);
        }
        
    }
}