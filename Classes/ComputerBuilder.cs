using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public IComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = processor;
            return this;
        }
        public IComputerBuilder SetRAM(int ram)
        {
            _computer.RAM = ram;
            return this;
        }
        public IComputerBuilder SetStorage(int storage)
        {
            _computer.Storage = storage;
            return this;
        }
        public IComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }
        public IComputerBuilder SetMotherboard(string motherboard)
        {
            _computer.Motherboard = motherboard;
            return this;
        }
        public Computer Build()
        {
            if (string.IsNullOrEmpty(_computer.Processor) || _computer.RAM <= 0 || _computer.Storage <= 0)
            {
                throw new InvalidOperationException("Компьютер не может быть собран без обязательных компонентов.");
            }
            return _computer;
        }
    }
}
