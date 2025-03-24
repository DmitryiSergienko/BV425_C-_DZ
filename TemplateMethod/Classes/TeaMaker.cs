using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.TemplateMethod.Classes;

// Конкретный класс для приготовления чая
public class TeaMaker : BeverageMaker
{
    protected override void Brew()
    {
        Console.WriteLine("Завариваю чай...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляю лимон...");
    }
}