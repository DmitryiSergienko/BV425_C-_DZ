using BV425_C__DZ.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class ToyotaFactory : IAutoFactory
    {
        public Transport CreateAuto()
        {
            return new Auto("Toyota", "Автомобиль", 10000, 5, 20, 3, 10, 2, 0, 4, "Дизель", "Auto");
        }
    }
}
