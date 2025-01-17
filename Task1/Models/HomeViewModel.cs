using System.Collections.Generic;
using Task1.Entities.Concrets;

namespace Task1.Models
{
    public class HomeViewModel
    {

        public List<Meal> HotMeals { get; set; }
        public List<Drink> ColdDrinks { get; set; }
        public List<Drink> HotDrinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
    }
}
