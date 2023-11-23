using System.Reflection;

Console.WriteLine("Hello, World!");

var methodInfo = typeof(THExtender).GetMethod(nameof(THExtender.GetStatus));
if (methodInfo?.GetCustomAttribute(typeof(StatusAttribute<>), false) is StatusAttribute statusAttribute)
{
    Console.WriteLine($"Name:'{statusAttribute.Name}'");
    Console.WriteLine($"TypeName:'{statusAttribute.TypeName}'");
}
else
    Console.WriteLine("Generic Attributes not supported");

public class THExtender {

    [Status<Program>(Name="Hello")]
    public decimal GetStatus() => 0m;
}