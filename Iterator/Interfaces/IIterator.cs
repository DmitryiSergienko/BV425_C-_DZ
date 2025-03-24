using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Iterator.Interfaces;

// Интерфейс итератора
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}