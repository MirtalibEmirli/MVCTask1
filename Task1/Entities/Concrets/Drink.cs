using Task1.Entities.Abstracts;

namespace Task1.Entities.Concrets
{
    public class Drink : BaseItem
    {
        public float Liter { get; set; }
        public string Type { get; set; }
    }
}
