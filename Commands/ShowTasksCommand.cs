using BV425_C__DZ.Model;
using BV425_C__DZ.Commands.Interfaces;

namespace BV425_C__DZ.Commands;

public class ShowTasksCommand(Dictionary<int, TaskToDo> tasks, Action<string> show) : ITaskCommand
{
    public void Execute()
    {
        if (tasks.Count() != 0)
        {
            var sortTasks = tasks.OrderBy(kv => kv.Key).ToDictionary(kv => kv.Key, kv => kv.Value);
            foreach (var task in sortTasks)
            {
                show.Invoke($"{task.Value}");
                Console.WriteLine(task.Value);
            }
        }
        else
        {
            show.Invoke($"Списко тасок пуст!");
            Console.WriteLine("Списко тасок пуст!");
        }
        Console.ReadKey();
    }
}