namespace BV425_C__DZ.Classes;
public class Student
{
    public string Name {  get; set; }
    public int Score {  get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\t\tAge:{Score}";
    }
}