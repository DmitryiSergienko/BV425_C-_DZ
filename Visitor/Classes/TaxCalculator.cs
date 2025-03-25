using BV425_C__DZ.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Classes;

// Конкретный посетитель: Расчёт налогов
public class TaxCalculator : IVisitor
{
    private double _totalTax = 0;

    public void Visit(Book book)
    {
        double tax = book.Price * 0.05; // Налог 5% для книг
        Console.WriteLine($"Налог для книги \"{book.Title}\": {tax}");
        _totalTax += tax;
    }

    public void Visit(Toy toy)
    {
        double tax = toy.Price * 0.1; // Налог 10% для игрушек
        Console.WriteLine($"Налог для игрушки \"{toy.Name}\": {tax}");
        _totalTax += tax;
    }

    public void Visit(Electronics electronics)
    {
        double tax = electronics.Price * 0.2; // Налог 20% для электроники
        Console.WriteLine($"Налог для электроники \"{electronics.Model}\": {tax}");
        _totalTax += tax;
    }

    public double GetTotalTax()
    {
        return _totalTax;
    }
}