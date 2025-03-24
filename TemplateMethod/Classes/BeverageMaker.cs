using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.TemplateMethod.Classes;

// Абстрактный класс с шаблонным методом
public abstract class BeverageMaker
{
    // Шаблонный метод определяет скелет алгоритма
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    // Общие шаги, которые одинаковы для всех напитков
    private void BoilWater()
    {
        Console.WriteLine("Кипячу воду...");
    }

    private void PourInCup()
    {
        Console.WriteLine("Наливаю напиток в чашку...");
    }

    // Абстрактные методы, которые должны быть реализованы в подклассах
    protected abstract void Brew();
    protected abstract void AddCondiments();

    // Хук-метод (hook), который можно переопределить в подклассах
    protected virtual bool CustomerWantsCondiments()
    {
        return true; // По умолчанию добавляем дополнительные ингредиенты
    }
}