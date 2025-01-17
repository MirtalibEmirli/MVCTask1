using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task1.Entities.Concrets;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {

        static string link = "https://simple-veganista.com/wp-content/uploads/2012/09/healthy-chopped-vegetable-salad-recipe-4.jpg";
        static string steak = "https://t3.ftcdn.net/jpg/06/47/55/54/360_F_647555498_3ijmZWT1geR9afLVKPciM9RcSeTFdkKN.jpg";
        private List<Meal> meals = new List<Meal> { new Meal
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
        Img = steak
    },
    new Meal
    {
        Id = 9,
        Name = "Ice Cream",
        Description = "Creamy vanilla ice cream topped with chocolate syrup.",
        Price = 5,
        Img = steak
    },
    new Meal
    {
        Id = 10,
        Name = "Fish and Chips",
        Description = "Battered fish fillets served with crispy fries.",
        Price = 11,
        Img = steak
    },
    new Meal
    {
        Id = 11,
        Name = "Grilled Cheese",
        Description = "Toasted bread with melted cheddar cheese.",
        Price = 4,
        Img =steak
    },
    new Meal
    {
        Id = 12,
        Name = "Pancakes",
        Description = "Fluffy pancakes served with maple syrup.",
        Price = 8,
        Img = steak
    },
    new Meal
    {
        Id = 13,
        Name = "Ramen",
        Description = "Japanese noodle soup with broth, noodles, and toppings.",
        Price = 12,
        Img = steak
    },
    new Meal
    {
        Id = 14,
        Name = "Vegetable Curry",
        Description = "A spicy curry made with mixed vegetables and served with rice.",
        Price = 10,
        Img = steak
    },
    new Meal
    {
        Id = 15,
        Name = "Sandwich",
        Description = "A hearty sandwich with turkey, lettuce, and tomato.",
        Price = 6,
        Img = steak
    } };
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
        HomeViewModel ViewModel { get; set; }
       
        public IActionResult Index()
        {
            ViewModel = new HomeViewModel { 
            ColdDrinks =  coldDrinks,
            HotDrinks = hotDrinks,
            HotMeals= meals,
                FastFoods= fastFoods,

            };
            return View(ViewModel);
        }
         
    }
}
