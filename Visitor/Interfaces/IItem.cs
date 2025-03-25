using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Visitor.Interfaces;

// Интерфейс элемента (товара)
public interface IItem
{
    void Accept(IVisitor visitor);
}