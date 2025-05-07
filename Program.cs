using BV425_C__DZ.Model;
using BV425_C__DZ.Commands;
using BV425_C__DZ.Commands.Interfaces;
using NLog;
using NLog.Config;
using NLog.Targets; 

var pathLog = "log.txt";
var loggingConfiguration = new LoggingConfiguration();

var fileTarget = new FileTarget
{
    FileName = pathLog,
    Layout = @"${longdate}|${level:uppercase=true}|${message} ${exception}"
};

loggingConfiguration.AddRule(LogLevel.Info, LogLevel.Error, fileTarget);

LogManager.Configuration = loggingConfiguration;

var logger = LogManager.GetCurrentClassLogger();

//var fileLogger = new FileLogger(pathLog);

var tasks = new Dictionary<int, TaskToDo>();

var commandByNumberCommand = new Dictionary<string, ITaskCommand>
{
    { "1", new AddTaskCommand(tasks, logger) },
    { "2", new RemoveTaskCommand(tasks, logger) },
    { "3", new UpdateTaskCommand(tasks, logger) },
    { "4", new ShowTasksCommand(tasks, logger.Info) },
    { "5", new ChangeStatusTaskCommand(tasks, logger) }
};

string numberCommand = null;
do
{
    Console.Clear();
    Console.WriteLine(@"Команды:
    1 - Добавить таску
    2 - Удалить таску
    3 - Обновить таску
    4 - Показать информацию по таскам
    5 - Поменять стаутус у таски
    6 - Выход
");

    numberCommand = Console.ReadLine();

    if (commandByNumberCommand.TryGetValue(numberCommand, out ITaskCommand command))
    {
        command.Execute();
    }

}
while (numberCommand != "6");