using BV425_C__DZ.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Strategy.Classes;

// Контекст, который использует стратегию
public class Calculator
{
    private ICalculationStrategy _strategy;

    public void SetStrategy(ICalculationStrategy strategy)
    {
        _strategy = strategy;
    }

    public int ExecuteCalculation(int a, int b)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Стратегия не установлена.");
        }
        return _strategy.Calculate(a, b);
    }
}