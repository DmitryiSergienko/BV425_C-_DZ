var stack = new Stack<string>();
stack.Push("Раз");
stack.Push("Два");
stack.Push("Три");

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

try
{
    Console.WriteLine(stack.Pop()); // Попытка извлечь из пустого стека
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message); // "Стек пуст"
}

try
{
    Console.WriteLine(stack.Peek()); // Попытка отобразить из пустого стека
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message); // "Стек пуст"
}