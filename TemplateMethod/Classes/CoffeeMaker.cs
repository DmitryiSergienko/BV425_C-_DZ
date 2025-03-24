using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.TemplateMethod.Classes;

// Конкретный класс для приготовления кофе
public class CoffeeMaker : BeverageMaker
{
    protected override void Brew()
    {
        Console.WriteLine("Варю кофе...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляю молоко и сахар...");
    }

    // Переопределяем хук-метод, если клиент не хочет дополнительные ингредиенты
    protected override bool CustomerWantsCondiments()
    {
        return false; // Например, клиент не хочет молоко и сахар
    }
}