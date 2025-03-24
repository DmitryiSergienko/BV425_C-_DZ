using BV425_C__DZ.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Strategy.Classes;

// Конкретная стратегия: Вычитание
public class SubtractionStrategy : ICalculationStrategy
{
    public int Calculate(int a, int b)
    {
        return a - b;
    }
}