using BV425_C__DZ.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Decorator.Classes;

// Шифрование текста
public class EncryptionDecorator : TextEditorDecorator
{
    public EncryptionDecorator(ITextEditor editor) : base(editor) { }

    public override void Write(string text)
    {
        var encryptedText = Encrypt(text);
        Console.WriteLine("Текст зашифрован.");
        base.Write(encryptedText);
    }

    private string Encrypt(string text)
    {
        // Простое шифрование для примера
        return new string(text.Reverse().ToArray());
    }
}