var list = new LinkedList<string>();
list.AddFirst("Один");
list.AddLast("Два");
list.AddLast("Три");
list.AddLast("Четыре");
list.AddLast("Пять");
list.AddFirst("Ноль");

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n" + list.Contains("Два"));
Console.WriteLine(list.Contains("Семь"));