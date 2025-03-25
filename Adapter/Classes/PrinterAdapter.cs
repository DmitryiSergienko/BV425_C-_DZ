using BV425_C__DZ.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Adapter.Classes;

// Адаптер для старого принтера
public class PrinterAdapter : INewPrinter
{
    private readonly OldPrinter _oldPrinter;

    public PrinterAdapter(OldPrinter oldPrinter)
    {
        _oldPrinter = oldPrinter;
    }

    public void Print(string text)
    {
        // Преобразуем вызов нового интерфейса в старый
        _oldPrinter.PrintText(text);
    }
}