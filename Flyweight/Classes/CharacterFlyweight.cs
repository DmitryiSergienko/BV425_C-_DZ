using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Flyweight.Classes;

// Легковес: Общие данные символов
public class CharacterFlyweight
{
    public char Symbol { get; }

    public CharacterFlyweight(char symbol)
    {
        Symbol = symbol;
    }

    public void Display(int position)
    {
        Console.WriteLine($"Символ '{Symbol}' на позиции {position}");
    }
}