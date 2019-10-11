using FoodGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodGenerator.Models.Breakfast
{
    public class TestBreakfastMealRepository : IBreakfastMealRepository
    {
        public IQueryable<BreakfastMeals> breakfastMeals => new List<BreakfastMeals>
        {
            new BreakfastMeals { BreakfastMealName = "Denver Omlette", MealDesciption = "temp" },
            new BreakfastMeals { BreakfastMealName = "Eggs Benidict", MealDesciption = "temp" },
            new BreakfastMeals { BreakfastMealName = "French Toast", MealDesciption = "temp" }
        }.AsQueryable();
    }
}
