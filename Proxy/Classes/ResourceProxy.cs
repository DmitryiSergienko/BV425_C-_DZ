using BV425_C__DZ.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Proxy.Classes;

// Прокси для управления доступом
public class ResourceProxy : IResource
{
    private RealResource _realResource;
    private bool _isAuthorized;

    public ResourceProxy(bool isAuthorized)
    {
        _isAuthorized = isAuthorized;
    }

    public void Access()
    {
        if (_isAuthorized)
        {
            if (_realResource == null)
            {
                _realResource = new RealResource();
            }
            _realResource.Access();
        }
        else
        {
            Console.WriteLine("Доступ запрещён.");
        }
    }
}