using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Composite.Classes;

// Композит (папка)
public class Folder : FileSystemComponent
{
    private readonly List<FileSystemComponent> _children = new List<FileSystemComponent>();

    public Folder(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}