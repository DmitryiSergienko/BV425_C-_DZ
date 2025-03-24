using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Command.Classes;

// Получатель команды
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Свет включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Свет выключен.");
    }
}