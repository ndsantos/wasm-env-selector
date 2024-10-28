namespace EnvSelector.Shared.Structure
{
    public interface IStringEnum: IEquatable<IStringEnum>
    {
        string Value { get; }
    }
}