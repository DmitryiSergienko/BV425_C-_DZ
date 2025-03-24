using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Mediator.Interfaces;

// Интерфейс для коллег (участников чата)
public interface IColleague
{
    string Name { get; }
    void ReceiveMessage(string sender, string message);
    void SendMessage(string message);
}