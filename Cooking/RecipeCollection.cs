namespace BV425_C__DZ.Cooking
{
    public class RecipeCollection
    {
        public List<Recipe> Recipes { get; }
        public RecipeCollection() 
        {
            Recipes = [];
        }

        public Recipe this[int index]
        {
            set
            {
                Recipes[index] = value;
            }
            get
            {
                return Recipes[index];
            }
        }
        public int Count => Recipes.Count;
        public void AddRecipe(Recipe recipe)
        {
            if (recipe != null)
            {
                Recipes.Add(recipe);
            }
        }
        public void RemoveRecipe(string title, int year)
        {
            if (Recipes != null)
            {
                Recipes.RemoveAll(x => x.Title == title && x.Year == year);
            }
        }
        public List<Recipe>? FindRecipesByAuthor(string author)
        {
            var list = new List<Recipe>();

            if (Recipes != null)
            {
                foreach (var item in Recipes)
                {
                    if (item.Author == author)
                    {
                        list.Add(item);
                    }
                }
            }
            if (list.Count == 0)
            {
                throw new ArgumentNullException(nameof(Recipes));
            }
            return list;
        }
        public List<Recipe>? GetRecipesByCuisine(string cuisine)
        {
            var list = new List<Recipe>();
            if (Recipes != null)
            {
                foreach (var item in Recipes)
                {
                    if (item.Cuisine == cuisine)
                    {
                        list.Add(item);
                    }
                }
            }
            if (list.Count == 0)
            {
                throw new RecipeNotFoundException("Рецепт не найден.");
            }
            return list;
        }
    }
}