using BV425_C__DZ.Command.Classes;
using BV425_C__DZ.Observer.Classes;
using BV425_C__DZ.Strategy.Classes;

//Паттерн "Стратегия" (Strategy)
//Пример: Калькулятор с различными стратегиями вычислений
var calculator = new Calculator();

// Устанавливаем стратегию сложения
calculator.SetStrategy(new AdditionStrategy());
Console.WriteLine("Результат сложения: " + calculator.ExecuteCalculation(5, 3));

// Устанавливаем стратегию вычитания
calculator.SetStrategy(new SubtractionStrategy());
Console.WriteLine("Результат вычитания: " + calculator.ExecuteCalculation(5, 3) + "\n");

/////////////////////////////////////////////////////////////////////////////////////////////////////

//Паттерн "Наблюдатель" (Observer)
//Пример: Уведомление подписчиков о новостях
var publisher = new NewsPublisher();
var subscriber1 = new Subscriber("Подписчик 1");
var subscriber2 = new Subscriber("Подписчик 2");

publisher.Attach(subscriber1);
publisher.Attach(subscriber2);

publisher.PublishNews("Сегодня солнечная погода!");

publisher.Detach(subscriber1);

publisher.PublishNews("Завтра ожидается дождь.\n");

/////////////////////////////////////////////////////////////////////////////////////////////////////

//Паттерн "Команда" (Command)
//Пример: Управление устройствами через команды
var light = new Light();
var turnOnCommand = new TurnOnLightCommand(light);
var turnOffCommand = new TurnOffLightCommand(light);

var remote = new RemoteControl();

remote.SetCommand(turnOnCommand);
remote.PressButton();

remote.SetCommand(turnOffCommand);
remote.PressButton();