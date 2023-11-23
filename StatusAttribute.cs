
public abstract class StatusAttribute : Attribute
{
    public string? Name  { get; init; }

     public abstract string TypeName { get; }
}

[AttributeUsage(AttributeTargets.Method)]
public class StatusAttribute<T> : StatusAttribute 
{
    public override string TypeName => typeof(T).Name;
    
}  
