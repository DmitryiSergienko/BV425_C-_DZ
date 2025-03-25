using BV425_C__DZ.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Decorator.Classes;

// Логирование действий
public class LoggingDecorator : TextEditorDecorator
{
    public LoggingDecorator(ITextEditor editor) : base(editor) { }

    public override void Write(string text)
    {
        Console.WriteLine($"Лог: Запись текста \"{text}\"");
        base.Write(text);
    }
}