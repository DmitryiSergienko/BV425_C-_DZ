namespace C__Praktika4.Classes;
class Student
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public List<int> Grades { get; set; } = new List<int>();

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Grades: {string.Join(", ", Grades)}";
    }
}