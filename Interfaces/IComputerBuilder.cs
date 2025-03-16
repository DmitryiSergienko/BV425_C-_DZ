using BV425_C__DZ.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Interfaces
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetProcessor(string processor);
        IComputerBuilder SetRAM(int ram);
        IComputerBuilder SetStorage(int storage);
        IComputerBuilder SetGPU(string gpu);
        IComputerBuilder SetMotherboard(string motherboard);
        Computer Build();
    }
}
