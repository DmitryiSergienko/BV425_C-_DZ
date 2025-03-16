using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;
        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }
        public Computer BuildGamingComputer()
        {
            return _builder
                .SetProcessor("Intel Core i9")
                .SetRAM(32)
                .SetStorage(1024)
                .SetGPU("NVIDIA RTX 3080")
                .SetMotherboard("ASUS ROG Strix")
                .Build();
        }
        public Computer BuildOfficeComputer()
        {
            return _builder
                .SetProcessor("AMD Ryzen 5")
                .SetRAM(16)
                .SetStorage(512)
                .SetGPU("Integrated Graphics")
                .SetMotherboard("MSI B450")
                .Build();
        }
    }
}
