using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Strategy.Interfaces;

// Интерфейс для всех стратегий
public interface ICalculationStrategy
{
    int Calculate(int a, int b);
}