using BV425_C__DZ.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Iterator.Classes;

// Конкретная коллекция: Библиотека книг
public class BookLibrary : ILibrary<string>
{
    private readonly string[] _books;

    public BookLibrary(string[] books)
    {
        _books = books;
    }

    public IIterator<string> CreateIterator()
    {
        return new BookIterator(_books);
    }
}