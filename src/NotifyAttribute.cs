namespace PropertyNotify;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class NotifyAttribute(string method_name = "OnPropertyChanged", bool pass_changed_name = false) : Attribute
{
    public string MethodName { get; } = method_name;
    public bool PassChangedName { get; } = pass_changed_name;
}
