using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public abstract class Transport : ITransport<Transport>, ILabel<Transport>
    {
        protected string _manufacturer = "None";
        protected string _type = "None";
        protected double _weight = 0;
        protected double _hight = 0;
        protected double _length = 0;
        protected byte _wheels = 0;
        protected byte _window = 0;
        protected byte _wings = 0;
        protected byte _blade = 0;
        protected byte _engine = 0;
        protected string _fuel = "None";
        protected string _transmission = "None";

        protected Transport(string manufacturer, string type, double weight, double hight, double length, byte wheels, byte window,
                        byte wings, byte blade, byte engine, string fuel, string transmission) 
        {
            _manufacturer = manufacturer;
            _type = type;
            _weight = weight;
            _hight = hight;
            _length = length;
            _wheels = wheels;
            _window = window;
            _wings = wings;
            _blade = blade;
            _engine = engine;
            _fuel = fuel;
            _transmission = transmission;
        }

        public Transport printParameters()
        {
            Console.WriteLine("Параметры:" +
                "\nТип: " + _type +
                "\nМасса: " + _weight +
                "\nВысота: " + _hight +
                "\nДлина: " + _length +
                "\nКолеса: " + _wheels +
                "\nОкна: " + _window +
                "\nКрылья: " + _wings +
                "\nПропеллеры: " + _blade +
                "\nДвигатель: " + _engine +
                "\nТопливо: " + _fuel +
                "\nКоробка: " + _transmission + "\n"
                );
            return this;
        }
        public Transport printLabel() { Console.WriteLine("Производитель: " + _manufacturer); return this; }
    }
}
