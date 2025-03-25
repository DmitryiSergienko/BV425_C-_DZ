using BV425_C__DZ.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Decorator.Classes;

// Абстрактный декоратор
public abstract class TextEditorDecorator : ITextEditor
{
    protected readonly ITextEditor _editor;

    protected TextEditorDecorator(ITextEditor editor)
    {
        _editor = editor;
    }

    public virtual void Write(string text)
    {
        _editor.Write(text);
    }
}