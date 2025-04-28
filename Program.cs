using BV425_C__DZ.Classes;
using System.Diagnostics;
using System.Xml.Linq;

// Задача #1
Console.WriteLine("Задача #1:\n");
List<Student> students = new()
{
    new()
    {
        Name = "Alice",
        Score = 90
    },
    new()
    {
        Name = "Bob",
        Score = 80
    },
    new()
    {
        Name = "Charlie",
        Score = 88
    },
    new()
    {
        Name = "David",
        Score = 82
    },
};

Console.WriteLine("LINQ method:\n");
var methodStudent = students.Where(x => x.Score > 85).OrderBy(x => x.Score);
foreach (var student in methodStudent)
{
    Console.WriteLine(student.ToString());
}

Console.WriteLine("\nLINQ query:\n");
var queryStudent = from student in students
            where student.Score > 85
            orderby student.Score
            select student;
foreach (var student in queryStudent)
{
    Console.WriteLine(student.ToString());
}

// Задача #2
Console.WriteLine("\nЗадача #2:\n");
List<Book> books = new()
{
    new Book { Title = "1984" },
    new Book { Title = "To Kill a Mockingbird" },
    new Book { Title = "The Great Gatsby" }
};

Console.WriteLine("LINQ method:\n");
var methodBooks = books.OrderBy(x => x.Title);
foreach (var book in methodBooks)
{
    Console.WriteLine(book.Title);
}

Console.WriteLine("\nLINQ query:\n");
var queryBooks = from book in books
                 orderby book.Title
                 select book;
foreach (var book in queryBooks)
{
    Console.WriteLine(book.Title);
}

// Задача #3
Console.WriteLine("\nЗадача #3:\n");
var products = new List<Product>
{
 new Product { Name = "Apple", Category = "Fruits" },
 new Product { Name = "Carrot", Category = "Vegetables" },
 new Product { Name = "Banana", Category = "Fruits" },
 new Product { Name = "Broccoli", Category = "Vegetables" }
};

Console.WriteLine("LINQ method:\n");
var productsMethod = products.GroupBy(x => x.Category).Select(group => new
{
    Category = group.Key,
    Name = group.ToList()
});
foreach (var category in productsMethod)
{
    Console.WriteLine($"Category: {category.Category}");

    foreach (var product in category.Name)
    {
        Console.WriteLine($"  - {product.Name}");
    }
}

Console.WriteLine("\nLINQ query:\n");
var productsQuery = from product in products
                    group product by product.Category into categoryGroup
                    select new {
                    Category = categoryGroup.Key,
                    Name = categoryGroup.ToList()
};
foreach (var category in productsMethod)
{
    Console.WriteLine($"Category: {category.Category}");

    foreach (var product in category.Name)
    {
        Console.WriteLine($"  - {product.Name}");
    }
}

// Задача #4
Console.WriteLine("\nЗадача #4:\n");
var schoolkids = new List<Schoolkid>
{
 new Schoolkid { Id = 1, Name = "Alice" },
 new Schoolkid { Id = 2, Name = "Bob" }
};
var grades = new List<Grade>
{
 new Grade { SchoolkidId = 1, Subject = "Math", LetterGrade = 'A' },
 new Grade { SchoolkidId = 2, Subject = "Math", LetterGrade = 'B' },
 new Grade { SchoolkidId = 1, Subject = "Science", LetterGrade = 'A' }
};

Console.WriteLine("LINQ method:\n");
var methodSchoolkidsAndGrades = schoolkids.Join
    (
        grades,
        schoolkid => schoolkid.Id,      // Ключ для студентов
        grade => grade.SchoolkidId,     // Ключ для оценок
        (schoolkid, grade) => new       // Результат объединения
        {
            schoolkidName = schoolkid.Name,
            letterGrade = grade.LetterGrade,
            subject = grade.Subject
        }
    );
foreach( var schoolkid in methodSchoolkidsAndGrades)
{
    Console.WriteLine(schoolkid);
}

Console.WriteLine("\nLINQ query:\n");
var querySchoolkidsAndGrades = from schoolkid in schoolkids
                               join grade in grades
                               on schoolkid.Id equals grade.SchoolkidId into schoolkidGradeGroup
                               from grade in schoolkidGradeGroup.DefaultIfEmpty()
                               select new
                               {
                                   sschoolkidName = schoolkid.Name,
                                   letterGrade = grade.LetterGrade,
                                   subject = grade.Subject
                               };
foreach (var schoolkid in querySchoolkidsAndGrades)
{
    Console.WriteLine(schoolkid);
}

// Задача #5
Console.WriteLine("\nЗадача #5:\n");
var orders = new List<Order>
{
    new Order { Amount = 150.00m },
    new Order { Amount = 200.00m },
    new Order { Amount = 75.00m }
};

Console.WriteLine("LINQ method:\n");
var methodSumOrders = orders.Sum(o => o.Amount);
Console.WriteLine(methodSumOrders);

Console.WriteLine("\nLINQ query:\n");
var querySumOrders = (from order in orders
                      select order.Amount).Sum();
Console.WriteLine(querySumOrders);