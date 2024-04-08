namespace Bookify.Domain.Abstractions;

public class Error
{
    public Error(string code, string name)
    {
        Code = code;
        Name = name;
    }
    
    public string Code { get; }
    public string Name { get; }

    public static Error None => new(string.Empty, string.Empty);
    public static Error NullValue => new("Error.NullValue", "Null value was provided");
}