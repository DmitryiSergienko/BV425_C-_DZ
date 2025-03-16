using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; } // В гигабайтах
        public int Storage { get; set; } // В гигабайтах
        public string GPU { get; set; }
        public string Motherboard { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("=== Спецификации компьютера ===\n" +
                                $"Процессор: {Processor}\n" +
                                $"Оперативная память: {RAM} ГБ\n" +
                                $"Жесткий диск: {Storage} ГБ\n" +
                                $"Видеокарта: {GPU}\n" +
                                $"Материнская плата: {Motherboard}\n");
        }
    }
}
