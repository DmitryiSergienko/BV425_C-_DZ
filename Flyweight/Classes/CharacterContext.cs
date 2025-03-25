using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Flyweight.Classes;

// Контекст: Информация о положении символа
public class CharacterContext
{
    public int Position { get; }

    public CharacterContext(int position)
    {
        Position = position;
    }
}