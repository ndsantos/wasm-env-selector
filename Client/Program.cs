using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EnvSelector.Client;
using EnvSelector.Client.Service;
using EnvSelector.Client.Storage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<StorageHandler>();
builder.Services.AddSingleton<ServiceConfig>();
builder.Services.AddScoped<JSService>();
builder.Services.AddScoped(sp => {
    ServiceConfig config = sp.GetRequiredService<ServiceConfig>();
    return new HttpClient { BaseAddress = new Uri(config.Hostname) };
});

await builder.Build().RunAsync();
