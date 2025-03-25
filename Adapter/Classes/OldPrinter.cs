using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Adapter.Classes;

// Старый класс, который нужно адаптировать
public class OldPrinter
{
    public void PrintText(string text)
    {
        Console.WriteLine($"Старый принтер печатает: {text}");
    }
}