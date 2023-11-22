
[AttributeUsage(AttributeTargets.Method)]
public class StatusAttribute<T> : Attribute
{
    public StatusAttribute()
    {
    }

    public string? Name  { get; init; }
    
}  //Requires C# 11
