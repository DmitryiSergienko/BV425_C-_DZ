using BV425_C__DZ.Interfaces;

namespace BV425_C__DZ.Classes.Mode;

public class MethodPrint<T> : IMethods
{
    T _Value { get; set; }
    public MethodPrint(T Value)
    {
        _Value = Value;
    }
    public void Choice(UseMethod method)
    {
        Console.WriteLine(_Value);
    }
}