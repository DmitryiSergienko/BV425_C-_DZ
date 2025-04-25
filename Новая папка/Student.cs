namespace BV425_C__DZ.Новая_папка;
class Student
{
    public string Name {  get; set; }
    public int Age {  get; set; }
    public double GPA {  get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\t\tAge:{Age}\t\tGPA:{GPA}";
    }
}