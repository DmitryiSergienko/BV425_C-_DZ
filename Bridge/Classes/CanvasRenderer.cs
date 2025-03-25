using BV425_C__DZ.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Bridge.Classes;

// Рендеринг в Canvas
public class CanvasRenderer : IRenderer
{
    public void Render(string shapeName)
    {
        Console.WriteLine($"Рендеринг {shapeName} в формате Canvas.");
    }
}