using C__Praktika4.Classes;
using System.Diagnostics.SymbolStore;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

//  Задание 1 и 2
Console.WriteLine("Задание 1 и 2:");
Student student = new()
{
    Name = "Дмитрий",
    Age = 32,
    Grades = { 4, 5, 6, 7, 8, 9, 10, 11, 12 }
};

var jsonSerializerOptions = new JsonSerializerOptions
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
};

var jsonStudent = JsonSerializer.Serialize(student, jsonSerializerOptions);
Console.WriteLine("Сериализация объекта:\n" + jsonStudent);
string pathStudent = "D:\\Testing\\Students\\students.txt";
File.WriteAllText(pathStudent, jsonStudent);

var jsonStudentFromFile = File.ReadAllText(pathStudent);
var studentFromFile = JsonSerializer.Deserialize<Student>(jsonStudentFromFile);
Console.WriteLine("\nДесериализация объекта:\n" + jsonStudentFromFile);

Console.WriteLine("\nПросто ToString():\n" + student.ToString());

// Задание 3 и 4
Console.WriteLine("\nЗадание 3 и 4:");
Book book = new()
{
    Title = "Чек Пук",
    Author = "Витька Упоротов"
};

var jsonBook = JsonSerializer.Serialize(book, jsonSerializerOptions);
Console.WriteLine("Сериализация объекта:\n" + jsonBook);
string pathBook = "D:\\Testing\\Books\\book.txt";
File.WriteAllText(pathBook, jsonBook);

var jsonBookFromFile = File.ReadAllText(pathBook);
var bookFromFile = JsonSerializer.Deserialize<Book>(jsonBookFromFile);
Console.WriteLine("\nДесериализация объекта:\n" + jsonBookFromFile);

Console.WriteLine("\nПросто ToString():\n" + book.ToString());

List<Book> books = new()
{
    new()
    {
        Title = "Гамлет",
    Author = "Гомер Борисович"
    },
    new()
    {
        Title = "Титуник",
    Author = "Чич Апа"
    },
    new()
    {
        Title = "Кил Бил",
    Author = "Тарантино"
    }
};

var jsonBooks = JsonSerializer.Serialize(books, jsonSerializerOptions);
Console.WriteLine("\nСериализация объектов:\n" + jsonBooks);
string pathBooks = "D:\\Testing\\Books\\books.txt";
File.WriteAllText(pathBooks, jsonBooks);

Console.WriteLine("\nВывод на консоль содержимого из файла:\n" + File.ReadAllText(pathBooks));

var jsonBooksFromFile = File.ReadAllText(pathBooks);
var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonBooksFromFile);
Console.WriteLine("\nДесериализация объектов:\n" + jsonBooksFromFile);