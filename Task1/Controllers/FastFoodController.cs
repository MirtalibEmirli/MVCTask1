using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using Task1.Entities.Concrets;

namespace Task1.Controllers
{
    public class FastFoodController : Controller
    {
        public List<FastFood> fastFoods = new List<FastFood>{

               new FastFood {
                    Id = 1,
                    Name = "Big Mac",
                    Description = "A classic McDonald's burger with two all-beef patties, lettuce, cheese, pickles, onions, and special sauce.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard", "Sesame seeds" },
                    Protein = 25f,
                    Fat = 28f,
                    Carbohydrates = 40f,
                    EnergyValue = 550f
                },
                new FastFood
                {
                    Id = 2,
                    Name = "Cheeseburger",
                    Description = "A simple cheeseburger with beef patty, cheese, ketchup, mustard, and pickles.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard" },
                    Protein = 15f,
                    Fat = 12f,
                    Carbohydrates = 26f,
                    EnergyValue = 300f
                },
                new FastFood
                {
                    Id = 3,
                    Name = "McChicken",
                    Description = "A crispy chicken patty with lettuce and mayonnaise in a soft bun.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard" },
                    Protein = 20f,
                    Fat = 16f,
                    Carbohydrates = 28f,
                    EnergyValue = 400f
                },
                new FastFood
                {
                    Id = 4,
                    Name = "Quarter Pounder",
                    Description = "A quarter pound of beef with cheese, onions, pickles, ketchup, and mustard.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard", "Sesame seeds" },
                    Protein = 30f,
                    Fat = 25f,
                    Carbohydrates = 45f,
                    EnergyValue = 600f
                },
                new FastFood
                {
                    Id = 5,
                    Name = "Chicken Nugget 6pc",
                    Description = "6 pieces of crispy, golden chicken nuggets with your choice of dipping sauce.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Soy" },
                    Protein = 15f,
                    Fat = 14f,
                    Carbohydrates = 20f,
                    EnergyValue = 280f
                },
                new FastFood
                {
                    Id = 6,
                    Name = "Filet-O-Fish",
                    Description = "A tender fish fillet with tartar sauce and pickles.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Fish", "Eggs", "Mustard" },
                    Protein = 15f,
                    Fat = 20f,
                    Carbohydrates = 30f,
                    EnergyValue = 400f
                },
                new FastFood
                {
                    Id = 7,
                    Name = "McDouble",
                    Description = "Two beef patties, American cheese, pickles, onions, and ketchup.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard" },
                    Protein = 23f,
                    Fat = 18f,
                    Carbohydrates = 32f,
                    EnergyValue = 450f
                },
                new FastFood
                {
                    Id = 8,
                    Name = "Double Cheeseburger",
                    Description = "Two all-beef patties with two slices of melted cheese, ketchup, mustard, and pickles.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard" },
                    Protein = 28f,
                    Fat = 25f,
                    Carbohydrates = 35f,
                    EnergyValue = 500f
                },
                new FastFood
                {
                    Id = 9,
                    Name = "Spicy McChicken",
                    Description = "A spicy chicken patty with lettuce and mayonnaise.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard" },
                    Protein = 21f,
                    Fat = 18f,
                    Carbohydrates = 30f,
                    EnergyValue = 450f
                },
                new FastFood
                {
                    Id = 10,
                    Name = "Bacon McDouble",
                    Description = "Two beef patties, crispy bacon, cheese, pickles, onions, ketchup, and mustard.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs", "Mustard", "Bacon" },
                    Protein = 30f,
                    Fat = 32f,
                    Carbohydrates = 36f,
                    EnergyValue = 600f
                },
                new FastFood
                {
                    Id = 11,
                    Name = "Egg McMuffin",
                    Description = "A freshly cracked egg, Canadian bacon, and cheese on a toasted English muffin.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs" },
                    Protein = 17f,
                    Fat = 14f,
                    Carbohydrates = 30f,
                    EnergyValue = 300f
                },
                new FastFood
                {
                    Id = 12,
                    Name = "Sausage McMuffin",
                    Description = "A savory sausage patty, American cheese, and a freshly cracked egg on an English muffin.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs" },
                    Protein = 20f,
                    Fat = 24f,
                    Carbohydrates = 28f,
                    EnergyValue = 400f
                },
                new FastFood
                {
                    Id = 13,
                    Name = "Hotcakes",
                    Description = "Three fluffy hotcakes served with syrup and butter.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs" },
                    Protein = 9f,
                    Fat = 10f,
                    Carbohydrates = 56f,
                    EnergyValue = 350f
                },
                new FastFood
                {
                    Id = 14,
                    Name = "McFlurry",
                    Description = "Vanilla soft-serve ice cream blended with your choice of delicious toppings.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Dairy", "Gluten", "Soy" },
                    Protein = 5f,
                    Fat = 15f,
                    Carbohydrates = 60f,
                    EnergyValue = 300f
                },
                new FastFood
                {
                    Id = 15,
                    Name = "Apple Pie",
                    Description = "A warm, crispy pastry filled with sweet apple filling.",
                    Img = "https://mcdonalds.az/images/21a29d5d8d422d969e85b2c83e6ead97.png",
                    Allergens = new List<string> { "Gluten", "Dairy", "Eggs" },
                    Protein = 2f,
                    Fat = 10f,
                    Carbohydrates = 40f,
                    EnergyValue = 220f
                }

};
    
        public IActionResult Index()
        {
            return View(fastFoods);
        }

        public IActionResult Drink()
        {
            return Redirect("/drinks/index");
        }

        public IActionResult HotMeal()
        {
            return Redirect("/hotmeals/index");
        }

        //rootparam
        public IActionResult Find(int id = -1)
        {
            if (id == -1)
            {
                return Json(fastFoods);

            }

            else { var fastFood = fastFoods.FirstOrDefault(f => f.Id == id); return Json(fastFood); }

        }

        //queryparam
        public IActionResult FindFast(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Json(fastFoods);
            }
            else
            {
                var food = fastFoods.FirstOrDefault(f => f.Name.ToLower() == name);
                return Json(food);
            }
        }

        public IActionResult Search(string key)
        {
            if (string.IsNullOrEmpty(key)) { return Json(fastFoods); }
            else
            {
                var foods = fastFoods.Where(food => food.Name.Contains(key));
                return Json(foods);
            }
        }

        public IActionResult Alchol() { return BadRequest(); }
        public IActionResult Fasts() { var routeValue = new RouteValueDictionary(new {action="Index",Controller="FastFood"});
            return RedirectToRoute(routeValue);
        }
    }
}
