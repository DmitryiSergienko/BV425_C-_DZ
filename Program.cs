using System.Numerics;
using System.Text;

string mainCatalog = "D:\\Testing";
string subCatalog1 = mainCatalog + "\\Folder1";
string subCatalog2 = mainCatalog + "\\Folder2";
try
{
    if (!Directory.Exists(mainCatalog))                                 // Задание 1.2
    {
        Directory.CreateDirectory(mainCatalog);                         // Задание 1.1
        Console.WriteLine($"Основной каталог {mainCatalog} создан!");
    }
    Console.WriteLine("Задание 1.2 - Пройдена проверка на существование каталога!\n");

    Directory.CreateDirectory(subCatalog1);                             // Задание 1.1
    Console.WriteLine($"Подкаталог {subCatalog1} создан!");
    Directory.CreateDirectory(subCatalog2);                             // Задание 1.1
    Console.WriteLine($"Подкаталог {subCatalog2} создан!");
    Console.WriteLine("Задание 1.1 - Каталоги добавлены!\n");

    DeleteCatalog(mainCatalog);                                         // Задание 1.3
    void DeleteCatalog(string catalogName)
    {
        Directory.Delete(catalogName, true);
    }
    Console.WriteLine("Задание 1.3 - Принудительно удалена папка с содержимым!\n");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ошибка: Каталог не найден. Подробности: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Ошибка: Нет прав доступа. Подробности: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
}

////////////////////////////////////////////////////////////////////////////////////////
string file = subCatalog1 + "\\Test.txt";
try
{
    Directory.CreateDirectory(subCatalog1);
    File.WriteAllText(file, "Hello\nworld!");      // Задание 2.1

    Console.WriteLine(File.ReadAllText(file));
    Console.WriteLine("Задание 2.1 - Вывод всего текста целиком!\n");

    int iter = 1;
    foreach (var catalog in File.ReadLines(file))    // Задание 2.2
    {
        Console.WriteLine("Строка: " + iter + " " + catalog);
        iter++;
    }
    Console.WriteLine("Задание 2.2 - Вывод текста построчно!\n");

    Directory.CreateDirectory(subCatalog2);    // Задание 2.3
    string copyFile = subCatalog2 + "\\Test(copy).txt";
    string moveFile = subCatalog2 + "\\Test(move).txt";

    File.Copy(file, copyFile);
    File.Move(file, moveFile);

    Console.WriteLine("Задание 2.3 - Файл скопирован и перемещен!\n");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ошибка: Файл не найден. Подробности: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Ошибка: Нет прав доступа. Подробности: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
}

////////////////////////////////////////////////////////////////////////////////////////
try
{
    using (FileStream fileStream = new FileStream(file, FileMode.Create, FileAccess.Write))    // Задание 3.1
    {
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine("1 строка текста");
            writer.WriteLine("2 строка текста");
            writer.WriteLine("3 строка текста");

            Console.WriteLine("Задание 3.1 - Текст добавлен в файл!\n");
        }
    }

    using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))    // Задание 3.2
    {
        using (StreamReader reader = new StreamReader(fileStream))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Задание 3.2 - Текст отображен в консоль построчно!\n");
        }
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ошибка: Файл не найден. Подробности: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Ошибка: Нет прав доступа. Подробности: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
}

////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("\n\n\tНажмите 'Enter' для продолжения...");
Console.ReadLine();
Console.Clear();
Menu();
Directory.Delete(mainCatalog, true);
void Menu()
{
    string menuPath = ".\\menu.txt";
    var menu = ReadTextFromFile(menuPath);
    int position = 0;
    int oldPosition = 0;
    char icon = '~';
    char iconPoint = '*';
    bool closeProgramm = false;
    while (true)
    {
        menu[4 + position] = ChangeIcon(icon, menu[4 + position]);
        if (oldPosition != position)
        {
            menu[4 + oldPosition] = ChangeIcon(iconPoint, menu[4 + oldPosition]);
            oldPosition = position;
        }
        Console.Clear();
        ShowList(menu);

        var key = Console.ReadKey(intercept: true);
        if (key.Key == ConsoleKey.Enter)
        {
            ChangeFunc(position, ref closeProgramm);
        }
        else
        {
            position = ChangeMenuItem(position, key);
        }
        if (closeProgramm)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\tХорошего дня!\n\n\n");
            break;
        }
    }
}
void WriteTextInFile(string path)
{
    Console.WriteLine("Введите текст (для завершения ввода оставьте строку пустой):");
    List<string> text = new List<string>();

    while (true)
    {
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line))
        {
            break;
        }
        text.Add(line);
    }

    File.AppendAllLines(path, text);
}
List<string> ReadTextFromFile(string path)
{
    List<string> strings = [.. File.ReadAllLines(path)]; // Упрощенная запись из файла в список с инициализацией
    return strings;
}
void ShowList<T>(List<T> list)
{
    foreach (var row in list)
    {
        Console.WriteLine(row);
    }
}
int ChangeMenuItem(int position, ConsoleKeyInfo key)
{
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            {
                if (position > 0)
                {
                    return --position;
                }
                else
                {
                    return position;
                }
            }
        case ConsoleKey.DownArrow:
            {
                if (position < 3)
                {
                    return ++position;
                }
                else
                {
                    return position;
                }
            }
        default:
            {
                return position;
            }
    }
}
string ChangeIcon(char icon, string line)
{
    StringBuilder sb = new StringBuilder(line);
    sb[8] = icon;
    return line = sb.ToString();
}
void ChangeFunc(int position, ref bool closeProgramm)
{
    switch (position)
    {
        case (int)Func.WriteTextInFile:
            {
                ItemWriteText();
                break;
            }
        case (int)Func.ReadTextFromFile:
            {
                ItemReadText();
                break;
            }
        case (int)Func.RemoveTextInFile:
            {
                ItemRemoveText();
                break;
            }
        case (int)Func.CloseProgramm:
            {
                closeProgramm = true;
                break;
            }
        default:
            {
                break;
            }
    }
}
void ItemWriteText()
{
    try
    {
        Console.Write("Введите полный путь к файлу: ");
        var path = Console.ReadLine();
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        WriteTextInFile(path);
        Console.Clear();
        Console.WriteLine($"Текст успешно записан в файл: {path}");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.ReadKey();
    }
}
void ItemReadText()
{
    try
    {
        Console.Write("Введите полный путь к файлу: ");
        var path = Console.ReadLine();
        var file = ReadTextFromFile(path);
        if (file != null)
        {
            Console.Clear();
            foreach (var item in file)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.ReadKey();
    }
}
void ItemRemoveText()
{
    try
    {
        Console.Write("Введите полный путь к файлу: ");
        var path = Console.ReadLine();
        File.Delete(path);
        Console.Clear();
        Console.WriteLine($"Успешно удален файл: {path}");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.ReadKey();
    }
}

enum Func
{
    WriteTextInFile,
    ReadTextFromFile,
    RemoveTextInFile,
    CloseProgramm
}