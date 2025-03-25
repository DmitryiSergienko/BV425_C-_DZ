using BV425_C__DZ.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Classes;

public class Electronics : IItem
{
    public string Model { get; }
    public double Price { get; }

    public Electronics(string model, double price)
    {
        Model = model;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}