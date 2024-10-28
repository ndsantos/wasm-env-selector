using System.ComponentModel;

namespace EnvSelector.Shared.Structure.TypeConverters
{
    public class StringEnumTypeConverter<T>: TypeConverter where T: StringEnum, new()
    {
        public override bool CanConvertFrom(ITypeDescriptorContext? context, System.Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object value)
        {
            if (value is string && !string.IsNullOrEmpty(value as string))
            {
                return new T { Value = (value as string)! };
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext? context, System.Type? destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        }

        public override object? ConvertTo(ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object? value, System.Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return value?.ToString() ?? string.Empty;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}