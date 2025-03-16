using BV425_C__DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class Car : IPrototype<Car>
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        // Метод клонирования
        public Car Clone()
        {
            // Используем MemberwiseClone для создания поверхностной копии
            return (Car)this.MemberwiseClone();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {Model}, Цвет: {Color}");
        }
    }
}
