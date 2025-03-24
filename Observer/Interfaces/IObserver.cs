using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Observer.Interfaces;

// Интерфейс наблюдателя
public interface IObserver
{
    void Update(string message);
}