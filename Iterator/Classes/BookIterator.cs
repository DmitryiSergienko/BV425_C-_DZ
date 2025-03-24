using BV425_C__DZ.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Iterator.Classes;

// Конкретный итератор: Итератор для книг
public class BookIterator : IIterator<string>
{
    private readonly string[] _books;
    private int _position = 0;

    public BookIterator(string[] books)
    {
        _books = books;
    }

    public bool HasNext()
    {
        return _position < _books.Length;
    }

    public string Next()
    {
        if (HasNext())
        {
            return _books[_position++];
        }
        throw new InvalidOperationException("Нет больше элементов.");
    }
}