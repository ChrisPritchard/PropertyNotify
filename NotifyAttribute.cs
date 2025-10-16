
namespace PropertyNotify
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class NotifyAttribute(string methodName = "OnPropertyChanged") : Attribute
    {
        public string MethodName { get; } = methodName;
    }
}