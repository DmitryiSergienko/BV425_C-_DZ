using BV425_C__DZ.Model;
using BV425_C__DZ.Commands.Interfaces;
using NLog;

namespace BV425_C__DZ.Commands;

public class UpdateTaskCommand(Dictionary<int, TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер таски: ");
            var ID = int.Parse(Console.ReadLine());

            if (tasks.ContainsKey(ID))
            {
                var task = tasks[ID];

                Console.Write("Введите название: ");
                var title = Console.ReadLine();
                Console.Write("Введите описание: ");
                var description = Console.ReadLine();

                task.Title = title;
                task.Description = description;

                logger.Info($"Таска {ID} обновлена!");
                Console.WriteLine($"Таска {ID} обновлена!");
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