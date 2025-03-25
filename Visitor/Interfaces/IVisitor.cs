using BV425_C__DZ.Visitor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Interfaces;

// Интерфейс посетителя
public interface IVisitor
{
    void Visit(Book book);
    void Visit(Toy toy);
    void Visit(Electronics electronics);
}