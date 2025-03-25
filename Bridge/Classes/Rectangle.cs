using BV425_C__DZ.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Bridge.Classes;

// Расширение абстракции: Прямоугольник
public class Rectangle : Shape
{
    public Rectangle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        _renderer.Render("прямоугольник");
    }
}