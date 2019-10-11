using FoodGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodGenerator.Models.Breakfast
{
    public interface IBreakfastMealRepository
    {
        IQueryable<BreakfastMeals> breakfastMeals { get; }
    }
}
