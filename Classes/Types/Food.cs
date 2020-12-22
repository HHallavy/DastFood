namespace DastFood.Classes.Types
{
    public class Food
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string RecipeString { get; set; }
        public bool isSelfService { get; set; }
        public string Details { get; set; }
    }
}
