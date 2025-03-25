using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Memento.Classes;

// Класс-хранитель
public class Memento
{
    private readonly string _content;

    public Memento(string content)
    {
        _content = content;
    }

    // Возвращает сохранённое состояние
    public string GetContent()
    {
        return _content;
    }
}