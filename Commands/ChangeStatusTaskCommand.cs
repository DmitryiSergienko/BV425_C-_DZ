using BV425_C__DZ.Model;
using BV425_C__DZ.Commands.Interfaces;
using NLog;

namespace BV425_C__DZ.Commands;

public class ChangeStatusTaskCommand(Dictionary<int, TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер таски: ");
            var ID = int.Parse(Console.ReadLine());
            logger.Info($"Обращение к таске по номеру: {ID}");

            if (tasks.ContainsKey(ID))
            {
                var task = tasks[ID];
                task.ChangeComplete();
                logger.Info($"Статус такси {ID} обновился!");
                Console.WriteLine($"Статус такси {ID} обновился!");
            }
            else
            {
                logger.Warn($"Попытка обратиться несуществующему номеру: {ID}");
                Console.WriteLine($"Попытка обратиться несуществующему номеру: {ID}");
            }
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            logger.Error(ex.Message);
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
}