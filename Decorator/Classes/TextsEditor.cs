using BV425_C__DZ.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Decorator.Classes;

// Базовый текстовый редактор
public class TextsEditor : ITextEditor
{
    public virtual void Write(string text)
    {
        Console.WriteLine($"Записан текст: {text}");
    }
}