using BV425_C__DZ.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Observer.Classes;

// Конкретный наблюдатель
public class Subscriber : IObserver
{
    private readonly string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} получил уведомление: {message}");
    }
}