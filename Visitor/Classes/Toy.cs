using BV425_C__DZ.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Classes;

public class Toy : IItem
{
    public string Name { get; }
    public double Price { get; }

    public Toy(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}