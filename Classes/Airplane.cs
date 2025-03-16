using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    class Airplane : Transport
    {
        public Airplane(string manufacturer, string type, double weight, double hight, double length, 
            byte wheels, byte window, byte wings, byte blade, byte engine, string fuel, string transmission) : 
            base(manufacturer, type, weight, hight, length, wheels, window, wings, blade, engine, fuel, transmission){}
    }
}
