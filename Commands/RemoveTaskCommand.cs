using BV425_C__DZ.Model;
using BV425_C__DZ.Commands.Interfaces;
using NLog;

namespace BV425_C__DZ.Commands;

public class RemoveTaskCommand(Dictionary<int, TaskToDo> tasks, Logger logger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер таски: ");
            var ID = int.Parse(Console.ReadLine());

            if (tasks.ContainsKey(ID))
            {
                tasks.Remove(ID);
                logger.Info($"Удалена таска с индексом: {ID}");
                Console.WriteLine($"Удалена таска с индексом: {ID}");
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