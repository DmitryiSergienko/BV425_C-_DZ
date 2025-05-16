namespace BV425_C__DZ.Classes;

public class Content
{
    public static List<string> StringsList { get; set; } = new();
    public static Dictionary<string, List<string>> StringsDictionary { get; set; } = new();

    public Content(string strings)
    {
        var stringsInArray = strings.Split('\n');
        foreach (var stringIter in stringsInArray)
        {
            var str = stringIter.Trim();

            if (!string.IsNullOrWhiteSpace(str))
            {
                StringsList.Add(str);
                AddStringInDictionary(str);
            }
        }
    }

    public void Show()
    {
        foreach (var stringIter in StringsList)
        {
            Console.WriteLine(stringIter);
        }

        foreach (var stringIter in StringsDictionary)
        {
            foreach (var iter in stringIter.Value)
            {
                Console.WriteLine(stringIter.Key + " " + iter);
            }
        }
    }

    private void AddStringInDictionary(string str)
    {
        var word = str.Split(' ');
        var strWithoutFirstWord = str.Replace(word[0] + " ", "");
        if (StringsDictionary.TryGetValue(word[0], out List<string>? value))
        {
            value.Add(strWithoutFirstWord);
        }
        else
        {
            value = new();
            value.Add(strWithoutFirstWord);
            StringsDictionary.Add(word[0], value);
        }
    }
}