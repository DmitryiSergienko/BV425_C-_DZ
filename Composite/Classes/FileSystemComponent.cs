using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Composite.Classes;

// Интерфейс компонента
public abstract class FileSystemComponent
{
    public string Name { get; protected set; }

    public FileSystemComponent(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}