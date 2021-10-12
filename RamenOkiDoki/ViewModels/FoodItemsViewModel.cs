﻿using System.Collections.Generic;
using RamenOkiDoki.Models;

namespace RamenOkiDoki.ViewModels
{
    public class FoodItemsViewModel
    {
        public List<Food> Foods { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }
}