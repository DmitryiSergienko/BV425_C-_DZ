namespace BV425_C__DZ.Cooking
{
    public class Recipe
    {
        public Recipe() { }
        public Recipe(string title, string author, string cuisine, int year)
        {
            Title = title;
            Author = author;
            Cuisine = cuisine;
            Year = year;
        }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Cuisine { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return
                $"Название: {Title}\n" +
                $"Автор: {Author}\n" +
                $"Кухня: {Cuisine}\n" +
                $"Год: {Year}\n";
        }
        public bool Equals(Recipe? recipe)
        {
            if(recipe is null) return false;
            if(ReferenceEquals(this,recipe)) return true;
            return Title == recipe.Title && Year == recipe.Year;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Recipe recipe)
            {
                return Equals(recipe);
            }
            return false;
        }
        public static bool operator ==(Recipe? lhs, Recipe? rhs)
        {
            if (ReferenceEquals(lhs, rhs)) return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) return false;
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Recipe? lhs, Recipe? rhs)
        {
            return !(lhs==rhs);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Year);
        }
    }
}