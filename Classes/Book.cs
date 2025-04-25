namespace C__Praktika4.Classes;
class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime PublishedDate { get; set; } = DateTime.Now;

    public override string ToString()
    {
        return $"Title: {Title}, Author{Author}, PublishedDate:{PublishedDate}";
    }
}