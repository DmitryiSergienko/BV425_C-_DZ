using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Mediator.Interfaces;

// Интерфейс посредника
public interface IMediator
{
    void AddColleague(IColleague colleague);
    void SendMessage(IColleague sender, string message);
}