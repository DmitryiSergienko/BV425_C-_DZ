using BV425_C__DZ.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Mediator.Classes;

// Конкретный класс участника чата
public class ChatUser : IColleague
{
    private readonly IMediator _mediator;

    public string Name { get; }

    public ChatUser(IMediator mediator, string name)
    {
        _mediator = mediator;
        Name = name;
    }

    // Отправка сообщения через посредника
    public void SendMessage(string message)
    {
        Console.WriteLine($"{Name} отправил сообщение: \"{message}\"");
        _mediator.SendMessage(this, message);
    }

    // Получение сообщения от посредника
    public void ReceiveMessage(string sender, string message)
    {
        Console.WriteLine($"{Name} получил сообщение от {sender}: \"{message}\"");
    }
}