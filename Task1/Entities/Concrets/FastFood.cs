using System.Collections.Generic;
using Task1.Entities.Abstracts;

namespace Task1.Entities.Concrets
{
    public class FastFood : BaseItem
    {

        public List<string> Allergens { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Carbohydrates { get; set; }
        public float EnergyValue { get; set; }
    }
}
