using BV425_C__DZ.Interfaces;

namespace BV425_C__DZ.Classes.Mode;

public class MethodSet : IMethods
{
    private string _name;
    private string _value;
    MethodSet(string name, string value)
    {
        _name = name;
        _value = value;
    }
    public void Choice(UseMethod method)
    {
        Memory.Parameters.Add(_name, _value);
    }
}