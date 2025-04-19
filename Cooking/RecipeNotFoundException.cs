namespace BV425_C__DZ.Cooking
{
    [Serializable]
    internal class RecipeNotFoundException : Exception
    {
        public RecipeNotFoundException() {}
        public RecipeNotFoundException(string? message) : base(message) {}
        public RecipeNotFoundException(string? message, Exception? innerException) : base(message, innerException) {}
    }
}