using BV425_C__DZ.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Proxy.Classes;

// Реальный ресурс
public class RealResource : IResource
{
    public void Access()
    {
        Console.WriteLine("Доступ к реальному ресурсу.");
    }
}