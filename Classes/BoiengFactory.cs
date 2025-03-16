using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class BoiengFactory : IAirplaneFactory
    {
        public Transport CreateAirplane()
        {
            return new Airplane("Boieng", "Самолет", 1500.32, 17.24, 56.43, 10, 50, 2, 0, 2, "Солярка", "Auto");
        }
    }
}
