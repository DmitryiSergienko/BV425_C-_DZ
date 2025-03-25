using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Flyweight.Classes;

// Фабрика легковесов
public class CharacterFactory
{
    private readonly Dictionary<char, CharacterFlyweight> _flyweights = 
        new Dictionary<char, CharacterFlyweight>();

    public CharacterFlyweight GetCharacter(char symbol)
    {
        if (!_flyweights.ContainsKey(symbol))
        {
            _flyweights[symbol] = new CharacterFlyweight(symbol);
        }
        return _flyweights[symbol];
    }
}