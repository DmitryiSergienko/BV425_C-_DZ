using BV425_C__DZ.Interfaces;

namespace BV425_C__DZ.Classes.Mode;

public class MethodCall : IMethods
{
    private string _method;
    MethodCall(string method)
    {
        _method = method;
    }
    public void Choice(UseMethod method)
    {
        //Content.StringsDictionary.TryGetValue(_method, );
    }
}