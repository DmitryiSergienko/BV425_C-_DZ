using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Memento.Classes;

// Класс, состояние которого нужно сохранять
public class TextEditor
{
    private string _content = string.Empty;

    // Установка содержимого
    public void Write(string text)
    {
        _content += text;
        Console.WriteLine($"Текущее содержимое: {_content}");
    }

    // Получение текущего состояния
    public Memento Save()
    {
        Console.WriteLine("Состояние сохранено.");
        return new Memento(_content);
    }

    // Восстановление состояния
    public void Restore(Memento memento)
    {
        _content = memento.GetContent();
        Console.WriteLine($"Состояние восстановлено: {_content}");
    }
}