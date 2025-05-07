namespace BV425_C__DZ.Classes;
public class Stack<T>
{
    private List<T> list = new();
    public void Push(T item)
    {
        list.Add(item);
    }
    public T Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        int lastIndex = list.Count - 1;
        T item = list[lastIndex];
        list.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        return list[list.Count - 1];
    }
}