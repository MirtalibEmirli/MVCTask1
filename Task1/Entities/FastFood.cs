using System.Collections.Generic;

namespace Task1.Entities
{
    public class FastFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public List<string> Allergens  { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbohydrates { get; set; }
        public float EnergyValue { get; set; }
    }
}
