using BV425_C__DZ.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Mediator.Classes;

// Конкретный класс посредника (чат-комната)
public class ChatRoom : IMediator
{
    private readonly List<IColleague> _colleagues = new List<IColleague>();

    // Добавление участника в чат
    public void AddColleague(IColleague colleague)
    {
        if (!_colleagues.Contains(colleague))
        {
            _colleagues.Add(colleague);
        }
    }

    // Пересылка сообщений всем участникам, кроме отправителя
    public void SendMessage(IColleague sender, string message)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.ReceiveMessage(sender.Name, message);
            }
        }
    }
}