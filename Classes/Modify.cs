namespace BV425_C__DZ.Classes;
public static class Modify
{
    public static List<int> ModifyList(this List<int> list, Func<int, int> func)
    {
        var newList = new List<int>();
        foreach (var item in list)
        {
            newList.Add(func.Invoke(item));
        }
        return newList;
    }
}