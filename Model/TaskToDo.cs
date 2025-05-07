namespace BV425_C__DZ.Model;

public class TaskToDo
{
    public static int Size { get; private set; } = 1;
    public int ID { get; private set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsComplete { get; private set; }
    public TaskToDo()
    {
        ID = Size;
        Size++;
    }

    public void ChangeComplete()
    {
        IsComplete = !IsComplete;
    }

    public override string ToString()
    {
        return $"Номер: {ID}, Название: {Title}, Описание: {Description}, Статус: {GetTextComplete()}";
    }

    private string GetTextComplete()
    {
        if (IsComplete)
        {
            return "Завершена";
        }

        return "Активна";
    }
}