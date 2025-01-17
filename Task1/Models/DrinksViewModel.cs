﻿using System.Collections.Generic;
using Task1.Entities.Concrets;

namespace Task1.Models
{
    public class DrinksViewModel
    {
        public List<Drink> ColdDrinks { get; set; }
        public List<Drink> HotDrinks { get; set; }
    }
}
