namespace BV425_C__DZ.Cooking
{
    public static class Extension
    {
        public static Dictionary<int, List<Recipe>> GroupByYear(this RecipeCollection recipes)
        {
            if (recipes == null)
            {
                throw new NullReferenceException("Коллекция рецептов пуста");
            }

            var groupByYear = new Dictionary<int, List<Recipe>>();

            foreach (Recipe recipe in recipes.Recipes)
            {
                var year = recipe.Year;

                if (!groupByYear.ContainsKey(year))
                {
                    groupByYear[year] = new List<Recipe>();
                }

                groupByYear[year].Add(recipe);
            }

            return groupByYear;
        }
        public static void ShowDictionary<T>(this RecipeCollection recipes, Dictionary<T, List<Recipe>> groupByYear)
        {
            foreach (var groupByYearKey in groupByYear.OrderBy(groupByYearKey => groupByYearKey.Key))
            {
                Console.WriteLine($">-----------Ключ: {groupByYearKey.Key}--------<");
                foreach (var recipe in groupByYearKey.Value)
                {
                    Console.WriteLine($"{recipe}");
                }
            }
        }
    }
}