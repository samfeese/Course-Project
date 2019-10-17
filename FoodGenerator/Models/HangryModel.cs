using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodGenerator.Models
{
    public class HangryModel : DbContext
    {
        public HangryModel(DbContextOptions<HangryModel> options)
            : base(options)
        { }
        public DbSet<BreakfastMeal> BreakfastMeals {get;set;}
    }
    
    public class LunchMeals
    {
        //Primary Key
        public int LunchMealId { get; set; }

        //Table items
        public string Name { get; set; }
        public string Discription { get; set; }
    }
    public class DinnerMeals
    {
        //Primary Key
        public int DinnerMealId { get; set; }

        //Table items
        public string Name { get; set; }
        public string Discription { get; set; }
    }
}
