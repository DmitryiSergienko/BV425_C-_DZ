using BV425_C__DZ.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Bridge.Classes;

// Форма
public abstract class Shape
{
    protected IRenderer _renderer;

    public Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract void Draw();
}