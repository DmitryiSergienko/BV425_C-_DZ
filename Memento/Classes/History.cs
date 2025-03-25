using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Memento.Classes;

// Класс для управления состояниями (история)
public class History
{
    private readonly Stack<Memento> _states = new Stack<Memento>();

    // Сохранение состояния
    public void Push(Memento memento)
    {
        _states.Push(memento);
    }

    // Восстановление предыдущего состояния
    public Memento Pop()
    {
        if (_states.Count > 0)
        {
            return _states.Pop();
        }
        throw new InvalidOperationException("Нет сохранённых состояний.");
    }
}