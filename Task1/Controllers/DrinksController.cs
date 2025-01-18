using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using Task1.Entities;
using Task1.Entities.Concrets;
using Task1.Models;

namespace Task1.Controllers
{
    public class DrinksController : Controller
    {



        List<Drink> hotDrinks = new List<Drink>()
{


    new Drink
    {
        Id = 1,
        Type = "Hot",
        Price = 10,
        Liter = 0.3f,
        Name = "Espresso",
        Description = "A strong and concentrated black coffee brewed by forcing steam through finely-ground coffee beans.",
        Img = "https://modeoncoffee.com/cdn/shop/articles/espresso_pic_1200x1200.png?v=1681035229"
    },
    new Drink
    {
        Id = 2,
        Price = 12,
        Liter = 0.35f,
        Type = "Hot",
        Name = "Cappuccino",
        Description = "A coffee-based drink made with espresso, steamed milk, and milk foam.",
        Img = "https://cafefabrique.com/cdn/shop/articles/Cappuccino.jpg?v=1716500365"
    },
    new Drink
    {
        Id = 3,
        Price = 15,
        Type = "Hot",
        Liter = 0.25f,
        Name = "Latte",
        Description = "A hot drink made with espresso and steamed milk, usually topped with a thin layer of foam.",
        Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Caffe_Latte_cup.jpg/640px-Caffe_Latte_cup.jpg"
    },
    new Drink
    {
        Id = 4,
        Price = 18,
        Liter = 0.35f,
        Type = "Hot",
        Name = "Hot Chocolate",
        Description = "A rich, creamy beverage made with milk and chocolate, served hot.",
        Img = "https://lizzylovesfood.com/wp-content/uploads/2021/09/Delysia-Hot-Chocolate-Recipe-8.jpg.webp"
    },
    new Drink
    {
        Id = 5,
        Price = 20,
        Liter = 0.4f,
        Type = "Hot",
        Name = "Chai Latte",
        Description = "A spiced tea with milk, combining a blend of tea, cinnamon, and other spices.",
        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQqzSDiwnnh0KK_3_Rn95l_VXFcTJsbJrF0kQ&s"
    },


    new Drink
    {
        Id = 6,
        Type = "Hot",
        Price = 70,
        Liter = 0.3f,
        Name = "Espresso",
        Description = "A strong and concentrated black coffee brewed by forcing steam through finely-ground coffee beans.",
        Img = "https://modeoncoffee.com/cdn/shop/articles/espresso_pic_1200x1200.png?v=1681035229"
    },
    new Drink
    {
        Id = 7,
        Price = 17,
        Liter = 0.35f,
        Type = "Hot",
        Name = "Cappuccino",
        Description = "A coffee-based drink made with espresso, steamed milk, and milk foam.",
        Img = "https://cafefabrique.com/cdn/shop/articles/Cappuccino.jpg?v=1716500365"
    },
    new Drink
    {
        Id = 8,
        Price = 18,
        Type = "Hot",
        Liter = 0.25f,
        Name = "Latte",
        Description = "A hot drink made with espresso and steamed milk, usually topped with a thin layer of foam.",
        Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Caffe_Latte_cup.jpg/640px-Caffe_Latte_cup.jpg"
    },
    new Drink
    {
        Id = 9,
        Price = 18,
        Liter = 0.35f,
        Type = "Hot",
        Name = "Hot Chocolate",
        Description = "A rich, creamy beverage made with milk and chocolate, served hot.",
        Img = "https://lizzylovesfood.com/wp-content/uploads/2021/09/Delysia-Hot-Chocolate-Recipe-8.jpg.webp"
    },
    new Drink
    {
        Id = 10,
        Price = 20,
        Liter = 0.4f,
        Type = "Hot",
        Name = "Chai Latte",
        Description = "A spiced tea with milk, combining a blend of tea, cinnamon, and other spices.",
        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQqzSDiwnnh0KK_3_Rn95l_VXFcTJsbJrF0kQ&s"
    },

};


        List<Drink> coldDrinks = new List<Drink>()
            {
                  new Drink
            {
                Id = 1,
                Type ="Cold",
                Price = 15,
                Liter = 1.5f,
                Name = "Sheridian",
                Description = "Refreshing cola drink with a bold flavor.",
                Img = "https://www.tasteatlas.com/images/ingredients/5235e7503bef46d58f0552da57cb37a5.jpg"  //  ,
               
            },
            new Drink
            {
                Id = 2,
                Price = 10,
                Liter = 2.0f,                Type ="Cold",

                Name = "Mr Black",
                Description = "Crisp and refreshing lemon-lime soda.",
                Img = "https://carlbusch.com/wp-content/uploads/2024/03/Mr-Black-Coffee-Liquor-Side-View.jpg"  //  
            },
            new Drink
            {
                Id = 3,
                Price = 12,                Type ="Cold",

                Liter = 1.0f,
                Name = "Latte",
                Description = "Minty and lime-infused refreshing cocktail.",
                Img = "https://i0.wp.com/worldcoffeebeans.com/wp-content/uploads/2019/07/raf_coffee_1.jpg?fit=1500%2C1000&ssl=1"  // vazgecilmez raFFFF 
            },
            new Drink
            {
                Id = 4,
                Price = 18,
                Liter = 1.0f,                Type ="Cold",

                Name = "Mojito",
                Description = "Freshly squeezed orange juice, packed with vitamins.",
                Img = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/mojito-cocktails-150961e.jpg?quality=90&resize=430,390"  // mojito  
            },
            new Drink
            {
                Id = 5,
                Price = 20,
                Liter = 1.2f,                Type ="Cold",

                Name = "Cola",
                Description = "A spicy and sweet carbonated drink with ginger flavor.",
                Img = "https://www.coca-cola.com/content/dam/onexp/ie/en/offerings-2024/best-coke-ever/cczs_best_coke_ever_desktop.png"  // colaa
            },  new Drink
            {
                Id = 6,
                Type ="Cold",
                Price = 15,
                Liter = 1.5f,
                Name = "Sheridian",
                Description = "Refreshing cola drink with a bold flavor.",
                Img = "https://www.tasteatlas.com/images/ingredients/5235e7503bef46d58f0552da57cb37a5.jpg"  //  ,
               
            },
            new Drink
            {
                Id = 7,
                Price = 10,
                Liter = 2.0f,                Type ="Cold",

                Name = "MrBlack",
                Description = "Crisp and refreshing lemon-lime soda.",
                Img = "https://carlbusch.com/wp-content/uploads/2024/03/Mr-Black-Coffee-Liquor-Side-View.jpg"  //  
            },
            new Drink
            {
                Id = 8,
                Price = 12,                Type ="Cold",

                Liter = 1.0f,
                Name = "Latte",
                Description = "Minty and lime-infused refreshing cocktail.",
                Img = "https://i0.wp.com/worldcoffeebeans.com/wp-content/uploads/2019/07/raf_coffee_1.jpg?fit=1500%2C1000&ssl=1"  // vazgecilmez raFFFF 
            },
            new Drink
            {
                Id = 9,
                Price = 18,
                Liter = 1.0f,                Type ="Cold",

                Name = "Mojito",
                Description = "Freshly squeezed orange juice, packed with vitamins.",
                Img = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/mojito-cocktails-150961e.jpg?quality=90&resize=430,390"  // mojito  
            },
            new Drink
            {
                Id = 10,
                Price = 20,
                Liter = 1.2f,                Type ="Cold",

                Name = "Cola",
                Description = "A spicy and sweet carbonated drink with ginger flavor.",
                Img = "https://www.coca-cola.com/content/dam/onexp/ie/en/offerings-2024/best-coke-ever/cczs_best_coke_ever_desktop.png"  // colaa
            }
            };

        public IActionResult Index()
        {
            var drinksViewModel = new DrinksViewModel
            {
                HotDrinks = hotDrinks,
                ColdDrinks = coldDrinks,
            };
            return View(drinksViewModel);
        }

        public IActionResult ColdDrinks()
        {

            return View(coldDrinks);

        }
        public IActionResult Alchol() { return BadRequest(); }
        public IActionResult HotDrinks()
        {
            return View(hotDrinks);
        }
        public IActionResult Drink()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Colds()
        {
            return Redirect("Drinks/ColdDrinks");
        }

        public IActionResult Hots()
        {
            return Redirect("/Drinks/HotDrinks");
        }
        //queryparam
        public IActionResult SearchColds(string key)
        {

            if (key != null)
            {
                var drinks = coldDrinks.Where(drink => drink.Name.Contains(key));
                return Json(drinks);
            }
            else { return Json(coldDrinks); } 
        }


        public IActionResult SearchHots(string key)
        {
            if (key != null)
            {
                var drinks = hotDrinks.Where(drink => drink.Name.Contains(key));
                return Json(drinks);

            }
            else
            {
                return Json(hotDrinks);
            }
        }

        //rootParam
        public IActionResult CDrinkId(int id = -1)
        {
            if (id == -1)
            {
                return Json(coldDrinks);
            }

            else
            {
                var drink = coldDrinks.FirstOrDefault(drink => drink.Id == id);
                return Json(drink);
            }
        }

        //RouteValueDictionary

        public IActionResult Meal() //if user search for a meal then this link will redirect to My Meals controller :)Handled 
        {
            var routeValue = new RouteValueDictionary(new { action = "Index", Controller = "HotMeals" });
            return RedirectToRoute(routeValue);

        }
        //her ikisi dogrudur ve eyni isi ferqli  deyerlere gore gorurler
        public IActionResult HotMeal()
        {
            return Redirect("/hotmeals/index");
        }
        public IActionResult Hots2()
        {
            var routeValue = new RouteValueDictionary(new { action = "Hots", Controller = "Drinks" });
            return RedirectToRoute(routeValue);

        }
    }
}
