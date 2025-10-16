
using System;
using PropertyNotify;

namespace TestProject;

public partial class Class1
{
    [Notify]
    public partial string TestProperty { get; set; }

    private void OnPropertyChanged()
    {
        Console.WriteLine("property set");
    }
}
