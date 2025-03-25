using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Flyweight.Classes;

// Менеджер для управления символами
public class TextEditor
{
    private readonly List<(CharacterFlyweight Flyweight, CharacterContext Context)> _characters = 
        new List<(CharacterFlyweight, CharacterContext)>();
    private readonly CharacterFactory _factory;

    public TextEditor(CharacterFactory factory)
    {
        _factory = factory;
    }

    public void AddCharacter(char symbol, int position)
    {
        var flyweight = _factory.GetCharacter(symbol);
        var context = new CharacterContext(position);

        _characters.Add((flyweight, context));
    }

    public void Display()
    {
        foreach (var (flyweight, context) in _characters)
        {
            flyweight.Display(context.Position);
        }
    }
}