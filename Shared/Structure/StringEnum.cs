using System.Collections;
using System.Reflection.Metadata;

namespace EnvSelector.Shared.Structure
{

    public class StringEnum : IStringEnum
    {
        public StringEnum(string value) { Value = value; }

        public string Value { get; set; }

                
        public override string ToString()
        {
            return Value;
        }

        public bool Equals(IStringEnum? other)
        {
            if (other != null)
            {
                return ToString().Equals(other!.ToString());
            }
            return false;
        }

    }
}