using EnvSelector.Shared.Structure;
namespace EnvSelector.Client.Service
{
    public class ServiceConfig
    {
        public readonly Dictionary<string, string> HostNames = new Dictionary<string, string>
        {
            { ServiceEnvironment.Development.Value, "http://localhost:5263" },
            { ServiceEnvironment.Stage.Value, "https://stage.westeurope-01.azurewebsites.net" },
            { ServiceEnvironment.Production.Value, "https://prod.westeurope-01.azurewebsites.net" }
        };

        string DefaultHostName => HostNames[ServiceEnvironment.Production.Value];
        public ServiceEnvironment? Environment { get; set; }
        public string Hostname => Environment != null ? HostNames[Environment.Value] : DefaultHostName;

        
        
    }
}