using BV425_C__DZ.Adapter.Classes;
using BV425_C__DZ.Adapter.Interfaces;
using BV425_C__DZ.Composite.Classes;
using BV425_C__DZ.Decorator.Classes;
using BV425_C__DZ.Decorator.Interfaces;
using BV425_C__DZ.Facade.Classes;
using BV425_C__DZ.Memento.Classes;
using BV425_C__DZ.Proxy.Classes;
using BV425_C__DZ.Visitor.Classes;
using BV425_C__DZ.Visitor.Interfaces;
using File = BV425_C__DZ.Composite.Classes.File;

Console.WriteLine("Паттерн \"Хранитель\" (Memento)\n" +
    "Пример: Редактор текста с возможностью отмены изменений\n");

var editor = new TextEditor();
var history = new History();

// Вводим текст и сохраняем состояние
editor.Write("Привет, ");
history.Push(editor.Save());

editor.Write("мир!");
history.Push(editor.Save());

// Отменяем последние изменения
Console.WriteLine("\nОтмена изменений...");
editor.Restore(history.Pop());
editor.Restore(history.Pop());
Console.WriteLine();

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("===============================================================\n" +
    "Паттерн \"Посетитель\" (Visitor)\n" +
    "Пример: Вычисление стоимости товаров в магазине\n");

// Создаем список товаров
var items = new List<IItem>
        {
            new Book("Война и мир", 20),
            new Toy("Машинка", 15),
            new Electronics("Смартфон", 300)
        };

// Посетитель для расчёта стоимости
var priceCalculator = new PriceCalculator();
foreach (var item in items)
{
    item.Accept(priceCalculator);
}
Console.WriteLine($"Общая стоимость: {priceCalculator.GetTotalPrice()}");

Console.WriteLine();

// Посетитель для расчёта налогов
var taxCalculator = new TaxCalculator();
foreach (var item in items)
{
    item.Accept(taxCalculator);
}
Console.WriteLine($"Общий налог: {taxCalculator.GetTotalTax()}\n");

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("===============================================================\n" +
    "Паттерн \"Декоратор\" (Decorator)\n" +
    "Пример: Добавление дополнительных возможностей к текстовому редактору\n");

// Создаем базовый текстовый редактор
ITextEditor editors = new TextsEditor();

// Пишем текст
editors.Write("Привет, мир!");

// Добавляем логирование
editors = new LoggingDecorator(editors);

// Добавляем шифрование
editors = new EncryptionDecorator(editors);

// Добавляем логирование
editors = new LoggingDecorator(editors);

// Пишем текст
editors.Write("Привет, мир!");

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n===============================================================\n" +
    "Паттерн \"Адаптер\" (Adapter)\n" +
    "Пример: Адаптация старого API к новому\n");

var oldPrinter = new OldPrinter();
INewPrinter printer = new PrinterAdapter(oldPrinter);

printer.Print("Привет, мир!");

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n===============================================================\n" +
    "Паттерн \"Фасад\" (Facade)\n" +
    "Пример: Упрощение работы с подсистемой видеоплеера\n");

var player = new VideoPlayerFacade();

player.PlayMovie();
Console.WriteLine();
player.StopMovie();

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n===============================================================\n" +
    "Паттерн \"Компоновщик\" (Composite)\n" +
    "Пример: Организация файловой системы\n");

var root = new Folder("Root");

var file1 = new File("File1.txt");
var file2 = new File("File2.txt");

var folder1 = new Folder("Folder1");
var file3 = new File("File3.txt");

folder1.Add(file3);

root.Add(file1);
root.Add(file2);
root.Add(folder1);

root.Display(0);

//////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n===============================================================\n" +
    "Паттерн \"Прокси\" (Proxy)\n" +
    "Пример: Защита доступа к ресурсу\n");

var proxy = new ResourceProxy(isAuthorized: true);
proxy.Access();

var unauthorizedProxy = new ResourceProxy(isAuthorized: false);
unauthorizedProxy.Access();