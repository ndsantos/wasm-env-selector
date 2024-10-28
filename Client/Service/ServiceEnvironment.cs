using System.ComponentModel;
using EnvSelector.Shared.Structure;
using EnvSelector.Shared.Structure.TypeConverters;

namespace EnvSelector.Client.Service
{
    [TypeConverter(typeof(StringEnumTypeConverter<ServiceEnvironment>))]
    public class ServiceEnvironment: StringEnum
    {
        public ServiceEnvironment() : base("") { }
        public ServiceEnvironment(string value) : base(value) { }
        public static ServiceEnvironment Development = new ServiceEnvironment("Development");
        public static ServiceEnvironment Stage = new ServiceEnvironment("Stage");
        public static ServiceEnvironment Production = new ServiceEnvironment("Production");

        public static List<ServiceEnvironment> All = new List<ServiceEnvironment> { Development, Stage, Production };
    }
}