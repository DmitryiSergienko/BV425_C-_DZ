using BV425_C__DZ.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Classes;

// Конкретный посетитель: Расчёт стоимости
public class PriceCalculator : IVisitor
{
    private double _totalPrice = 0;

    public void Visit(Book book)
    {
        Console.WriteLine($"Книга \"{book.Title}\" стоит {book.Price}");
        _totalPrice += book.Price;
    }

    public void Visit(Toy toy)
    {
        Console.WriteLine($"Игрушка \"{toy.Name}\" стоит {toy.Price}");
        _totalPrice += toy.Price;
    }

    public void Visit(Electronics electronics)
    {
        Console.WriteLine($"Электроника \"{electronics.Model}\" стоит {electronics.Price}");
        _totalPrice += electronics.Price;
    }

    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}