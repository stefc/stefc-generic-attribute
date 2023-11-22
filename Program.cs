
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var methodInfo = typeof(THExtender).GetMethod(nameof(THExtender.GetStatus));
        var attr =  methodInfo?.GetCustomAttribute(typeof(StatusAttribute<>), false);
        
    }
}


public class THExtender {

    [Status<Program>(Name="Hello")]
    public decimal GetStatus() => 0m;
}
