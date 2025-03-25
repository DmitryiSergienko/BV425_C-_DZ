using BV425_C__DZ.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Classes;

public class Book : IItem
{
    public string Title { get; }
    public double Price { get; }

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}