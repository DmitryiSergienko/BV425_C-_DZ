using BV425_C__DZ.Новая_папка;

List<Student> students = new()
{
    new()
    {
        Name = "Витька",
        Age = 18,
        GPA = 5.4
    },
    new()
    {
        Name = "Жорик",
        Age = 21,
        GPA = 4.5
    },
    new()
    {
        Name = "Борян",
        Age = 22,
        GPA = 5.0
    },
    new()
    {
        Name = "Ксюха",
        Age = 21,
        GPA = 3.6
    },
    new()
    {
        Name = "Лена",
        Age = 17,
        GPA = 5.2
    },
    new()
    {
        Name = "Маруся",
        Age = 20,
        GPA = 4.1
    },
    new()
    {
        Name = "Ярослав",
        Age = 23,
        GPA = 1.9
    },
    new()
    {
        Name = "Федя",
        Age = 19,
        GPA = 2.8
    },
    new()
    {
        Name = "Чича",
        Age = 21,
        GPA = 4.0
    },
    new()
    {
        Name = "Дося",
        Age = 28,
        GPA = 3.5
    }
};

Console.WriteLine("LINQ method:\n");
var method = students.Where(x => x.GPA > 3.5).OrderBy(x => x.GPA);
foreach (var student in method)
{
    Console.WriteLine(student.ToString());
}

Console.WriteLine("\nLINQ query:\n");
var query = from student in students
            where student.GPA > 3.5
            orderby student.GPA
            select student;
foreach (var student in query)
{
    Console.WriteLine(student.ToString());
}