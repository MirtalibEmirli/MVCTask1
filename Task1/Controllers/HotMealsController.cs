using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Task1.Entities;

namespace Task1.Controllers
{
    public class HotMealsController : Controller
    {
        static string link = "https://simple-veganista.com/wp-content/uploads/2012/09/healthy-chopped-vegetable-salad-recipe-4.jpg";


        List<Meal> meals = new List<Meal> { new Meal
    {
        Id = 1,
        Name = "Burger",
        Description = "A classic beef burger with lettuce, tomato, and cheese.",
        Price = 8,
        Img =link
    },
    new Meal
    {
        Id = 2,
        Name = "Pizza",
        Description = "A delicious pizza topped with pepperoni and mozzarella.",
        Price = 12,
        Img = link
    },
    new Meal
    {
        Id = 3,
        Name = "Pasta",
        Description = "Spaghetti served with a rich marinara sauce.",
        Price = 10,
        Img = link
    },
    new Meal
    {
        Id = 4,
        Name = "Sushi",
        Description = "Assorted sushi rolls with fresh fish and vegetables.",
        Price = 15,
        Img = link
    },
    new Meal
    {
        Id = 5,
        Name = "Fried Chicken",
        Description = "Crispy fried chicken pieces served with a side of coleslaw.",
        Price = 9,
        Img = link
    },
    new Meal
    {
        Id = 6,
        Name = "Steak",
        Description = "Grilled steak cooked to your preference, served with mashed potatoes.",
        Price = 20,
        Img = link
    },
    new Meal
    {
        Id = 7,
        Name = "Salad",
        Description = "A fresh mix of greens, tomatoes, cucumbers, and a light vinaigrette.",
        Price = 7,
        Img = link
    },
    new Meal
    {
        Id = 8,
        Name = "Tacos",
        Description = "Soft corn tortillas filled with seasoned beef, lettuce, and cheese.",
        Price = 6,
        Img = "https://www.example.com/images/tacos.jpg"
    },
    new Meal
    {
        Id = 9,
        Name = "Ice Cream",
        Description = "Creamy vanilla ice cream topped with chocolate syrup.",
        Price = 5,
        Img = "https://www.example.com/images/ice_cream.jpg"
    },
    new Meal
    {
        Id = 10,
        Name = "Fish and Chips",
        Description = "Battered fish fillets served with crispy fries.",
        Price = 11,
        Img = "https://www.example.com/images/fish_and_chips.jpg"
    },
    new Meal
    {
        Id = 11,
        Name = "Grilled Cheese",
        Description = "Toasted bread with melted cheddar cheese.",
        Price = 4,
        Img = "https://www.example.com/images/grilled_cheese.jpg"
    },
    new Meal
    {
        Id = 12,
        Name = "Pancakes",
        Description = "Fluffy pancakes served with maple syrup.",
        Price = 8,
        Img = "https://www.example.com/images/pancakes.jpg"
    },
    new Meal
    {
        Id = 13,
        Name = "Ramen",
        Description = "Japanese noodle soup with broth, noodles, and toppings.",
        Price = 12,
        Img = "https://www.example.com/images/ramen.jpg"
    },
    new Meal
    {
        Id = 14,
        Name = "Vegetable Curry",
        Description = "A spicy curry made with mixed vegetables and served with rice.",
        Price = 10,
        Img = "https://www.example.com/images/vegetable_curry.jpg"
    },
    new Meal
    {
        Id = 15,
        Name = "Sandwich",
        Description = "A hearty sandwich with turkey, lettuce, and tomato.",
        Price = 6,
        Img = "https://www.example.com/images/sandwich.jpg"
    } };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllMeals()
        {
            return Json(meals);
        }

        public IActionResult FindMeal(string name, int id = -1)
        {
            if (id==-1)
            {
                var meal = meals.Where(meal=> meal?.Name.ToLower() == name );   


                return Json(meal);

            }
            else {
                var meal = meals.Where(meal => meal?.Name.ToLower() == name||meal.Id==id);
                return Json(meal); }
        }
        //queryparamda  url bitdi FindMeal yeni bu ? qoyuruq ve verilen yeni actionda isdenilen seyi yazriqi ki name=salad id varsa name=salad&id=2 mesleen 

    }
}
