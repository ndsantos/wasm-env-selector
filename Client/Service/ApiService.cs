using Microsoft.JSInterop;

namespace EnvSelector.Client.Service{

    public class ApiService
    {
        private readonly IJSRuntime JS;
        private HttpClient Http;
        public ApiService(IJSRuntime jsRuntime, HttpClient http)
        {
            JS = jsRuntime;
            Http = http;
        }
    }
}

/*
Console.WriteLine("Starting");
    StorageHandler storage = sp.GetRequiredService<StorageHandler>();
    Console.WriteLine("loaded storage");
    
    ServiceEnvironment environment = storage.GetEnvironment().GetAwaiter().GetResult();
    string host = ServiceConfig.HostNames[environment];

    Console.WriteLine($"Using environment {environment.Value} with host {host}");
    return new HttpClient { BaseAddress = new Uri(host) };

    */