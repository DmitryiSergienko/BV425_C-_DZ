using BV425_C__DZ.Model;
using BV425_C__DZ.Commands.Interfaces;
using NLog;

namespace BV425_C__DZ.Commands;

public class AddTaskCommand(Dictionary<int, TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        Console.Write("Введите название: ");
        var title = Console.ReadLine();
        Console.Write("Введите описание: ");
        var description = Console.ReadLine();

        var taskToDo = new TaskToDo()
        {
            Title = title,
            Description = description
        };

        if (title != "" && description != "")
        {
            tasks.Add(taskToDo.ID, taskToDo);
            logger.Info($"Создание новой таски: {taskToDo}");
            Console.WriteLine($"Создание новой таски: {taskToDo}");
        }
        else
        {
            logger.Warn("Попытка создания таски с пустыми полями");
            Console.WriteLine("Попытка создания таски с пустыми полями");
        }
        Console.ReadKey();
    }
}