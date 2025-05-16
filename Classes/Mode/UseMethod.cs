using BV425_C__DZ.Interfaces;

namespace BV425_C__DZ.Classes.Mode;

public class UseMethod
{
    private IMethods _method;
    public void SetMethod(IMethods method)
    {
        _method = method;
    }

    public void Method(UseMethod method)
    {
        _method.Choice(method);
    }
}