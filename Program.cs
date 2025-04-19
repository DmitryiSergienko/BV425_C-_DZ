using BV425_C__DZ.Cooking;

var recipes = new RecipeCollection();
recipes.AddRecipe(new Recipe("Яичница", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Харчо", "Майк Тайсон", "Грузинская", 1500));
recipes.AddRecipe(new Recipe("Борщ", "Иван Иванович", "Русская", 517));
recipes.AddRecipe(new Recipe("Пельмени", "Джеки Чан", "Китайская", 1000));
recipes.AddRecipe(new Recipe("Оливье", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Блины", "Иван Иванович", "Русская", 517));

Console.WriteLine("Отображение всех рецептов:");
try
{
    for (int i = 0; i < recipes.Count; i++)
    {
        Console.WriteLine(recipes[i].ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

Console.WriteLine("Удалили \"Пельмени\" из списка:");
recipes.RemoveRecipe("Пельмени", 517);
try
{
    for (int i = 0; i < recipes.Count; i++)
    {
        Console.WriteLine(recipes[i].ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

Console.WriteLine("Поиск рецептов по автору \"Иван Иванович\":");
try
{
    var authorSearch = recipes.FindRecipesByAuthor("Иван Иванович");
    for (int i = 0; i < authorSearch.Count(); i++)
    {
        Console.WriteLine(authorSearch[i].ToString());
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString() );
}

Console.WriteLine("Поиск рецептов по кухне \"Французская\":");
try
{
    var сuisineSearch = recipes.GetRecipesByCuisine("Французская");
    for (int i = 0; i < сuisineSearch.Count(); i++)
    {
        Console.WriteLine(сuisineSearch[i].ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

///////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Демонстрация стандартного исключения выхода за границу массива,\n" +
    "обаботка исключения \"IndexOutOfRangeException\": ");
try
{
    Console.WriteLine(recipes[recipes.Count].ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

Console.WriteLine("Демонстрация стандартного исключения с проверкой на \"null\",\n" +
    "обаботка исключения \"ArgumentNullException\": ");
try
{
    var authorSearch = recipes.FindRecipesByAuthor("ФФФ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

Console.WriteLine("Демонстрация пользовательского исключения с отсутсвием рецепта,\n" +
    "обаботка исключения \"RecipeNotFoundException\": ");
try
{
    var сuisineSearch = recipes.GetRecipesByCuisine("ААА");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

///////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Группировка рецептов по году:");
try
{
    var groupByYear = recipes.GroupByYear();
    Extension.ShowDictionary(recipes, groupByYear);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString() + "\n");
}

Console.WriteLine("Xранение рецептов по авторам:");
var groupByAuthor = new Dictionary<string, List<Recipe>>();
foreach (Recipe recipe in recipes.Recipes)
{
    if (groupByAuthor.ContainsKey(recipe.Author))
    {
        groupByAuthor[recipe.Author].Add(recipe);
    }
    else
    {
        var tempRecipe = new List<Recipe> { recipe };
        groupByAuthor.Add(recipe.Author, tempRecipe);
    }
}
Extension.ShowDictionary(recipes, groupByAuthor);

recipes.AddRecipe(new Recipe("Яичница", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Яичница", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Харчо", "Майк Тайсон", "Грузинская", 1500));
recipes.AddRecipe(new Recipe("Харчо", "Майк Тайсон", "Грузинская", 1500));
recipes.AddRecipe(new Recipe("Борщ", "Иван Иванович", "Русская", 517));
recipes.AddRecipe(new Recipe("Борщ", "Иван Иванович", "Русская", 517));
recipes.AddRecipe(new Recipe("Пельмени", "Джеки Чан", "Китайская", 1000));
recipes.AddRecipe(new Recipe("Пельмени", "Джеки Чан", "Китайская", 1000));
recipes.AddRecipe(new Recipe("Оливье", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Оливье", "Жан Пьер", "Французская", 1854));
recipes.AddRecipe(new Recipe("Блины", "Иван Иванович", "Русская", 517));
recipes.AddRecipe(new Recipe("Блины", "Иван Иванович", "Русская", 517));

Console.WriteLine("Xранение уникальных рецептов:");
var uniqueRecipe = new HashSet<string>();
foreach (var recipe in recipes.Recipes)
{
    uniqueRecipe.Add(recipe.ToString());
}
foreach (var item in uniqueRecipe)
{
    Console.WriteLine(item.ToString());
}