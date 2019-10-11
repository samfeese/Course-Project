using FoodGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodGenerator.Models.ViewModels
{
    public class BreakfastMealViewModel
    {
        public IEnumerable<BreakfastMeals> BreakfastMeal { get; set; }
    }
}
