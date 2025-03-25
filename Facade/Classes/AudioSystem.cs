using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Facade.Classes;

// Подсистема: Аудио
public class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Аудиосистема включена.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Аудиосистема выключена.");
    }
}