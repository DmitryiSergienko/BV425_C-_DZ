using BV425_C__DZ.Iterator.Classes;
using BV425_C__DZ.State.Classes;
using BV425_C__DZ.TemplateMethod.Classes;
using BV425_C__DZ.Mediator.Classes;

//Паттерн "Шаблонный метод" (Template Method)
//Пример: Процесс приготовления напитка
Console.WriteLine("Готовлю чай:");
var teaMaker = new TeaMaker();
teaMaker.PrepareBeverage();

Console.WriteLine("\nГотовлю кофе:");
var coffeeMaker = new CoffeeMaker();
coffeeMaker.PrepareBeverage();

///////////////////////////////////////////////////////////////////////////////////

//Паттерн "Состояние" (State)
//Пример: Контекст с изменением состояния
var vendingMachine = new VendingMachine();

Console.WriteLine("\nТекущее состояние: Без монеты");
vendingMachine.InsertCoin(); // Вставка монеты
vendingMachine.SelectDrink(); // Выбор напитка
vendingMachine.Dispense(); // Выдача напитка

Console.WriteLine("\nПовторная попытка:");
vendingMachine.InsertCoin(); // Вставка монеты
vendingMachine.EjectCoin(); // Возврат монеты

///////////////////////////////////////////////////////////////////////////////////

//Паттерн "Итератор" (Iterator)
//Пример: Итерация по списку книг
// Создаем коллекцию книг
var books = new[] { "Война и мир", "Преступление и наказание", "Мастер и Маргарита" };
var library = new BookLibrary(books);

// Получаем итератор
var iterator = library.CreateIterator();

// Перебираем книги
Console.WriteLine("\nСписок книг:");
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}
Console.WriteLine();

///////////////////////////////////////////////////////////////////////////////////

//Паттерн "Посредник" (Mediator)
//Пример: Чат-комната
// Создаем посредника (чат-комнату)
var chatRoom = new ChatRoom();

// Создаем участников чата
var user1 = new ChatUser(chatRoom, "Алиса");
var user2 = new ChatUser(chatRoom, "Боб");
var user3 = new ChatUser(chatRoom, "Чарли");

// Добавляем участников в чат
chatRoom.AddColleague(user1);
chatRoom.AddColleague(user2);
chatRoom.AddColleague(user3);

// Участники отправляют сообщения
user1.SendMessage("Привет всем!");
user2.SendMessage("Как дела?");
user3.SendMessage("Всем привет!");