using System;

namespace DastFood.Classes.Types
{
    public class Ingredient
    {
        public long id { get; set; }
        public string name { get; set; }
        public string scale { get; set; }
        public double quantity { get; set; }
        public DateTime expireDate { get; set; }
    }
}