namespace BV425_C__DZ.Classes;
public class LinkedList<T> : IEnumerable<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null!;
        }
    }

    private Node? _head;

    public void AddFirst(T value) // Добавить в начало
    {
        var newNode = new Node(value);
        newNode.Next = _head;
        _head = newNode;
    }

    public void AddLast(T value) // Добавить в конец
    {
        var newNode = new Node(value);

        if (_head == null)
        {
            _head = newNode;
            return;
        }

        var current = _head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public bool Contains(T value) // Проверка наличия значения
    {
        var current = _head;
        while (current != null)
        {
            if (Equals(current.Value, value))
            {  
                return true; 
            }
            current = current.Next;
        }
        return false;
    }
        
    public IEnumerator<T> GetEnumerator() // Поддержка foreach
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}