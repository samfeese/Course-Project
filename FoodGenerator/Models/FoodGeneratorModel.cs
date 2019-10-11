using System;
using Microsoft.EntityFrameworkCore;

namespace FoodGenerator.Model
{
    public class FoodGeneratorModel : DbContext
    {
        public DbSet<FoodDetails> FoodDetails { get; set; }
        public DbSet<RecipeDetails> RecipeDetails { get; set; }
        public DbSet<MealCategories> MealCategories { get; set; }
        public DbSet<BreakfastMeals> BreakfastMeals { get; set; }
        public DbSet<LunchMeals> LunchMeals { get; set; }
        public DbSet<DinnerMeals> DinnerMeals { get; set; }
        public DbSet<Allergies> Allerigies { get; set; }
        public DbSet<FamilyData> Family { get; set; }
        public DbSet<Calander> Calender { get; set; }
        public DbSet<Utility> Utilities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Food-Database;Trusted_Connection=True;");
        }
    }

    public class Utility
    {
        public int UtilityId { get; set; }
    }

    public class Calander
    {
        public int CalanderId { get; set; }
        
    }

    public class FamilyData
    {
        public int FamilyDataId { get; set; }
        public string FamilyName { get; set; }

        public int FamilyMeals { get; set; }
    }

    public class Allergies
    {
        public int AllergiesId { get; set; }
        public string AllergyName { get; set; }

    }

    public class DinnerMeals
    {
        public int DinnerMealsId { get; set; }

        public string DinnerMealName { get; set; }


        public Utility Utilities { get; set; }
        public int UtilityId { get; set; }


        public MealCategories Meal { get; set; }
        public int MealCategoriesId { get; set; }

    }

    public class LunchMeals
    {
        public int LunchMealsId { get; set; }

        public string LunchMealName { get; set; }


        public Utility Utilities { get; set; }
        public int UtilityId { get; set; }


        public MealCategories Meal { get; set; }
        public int MealCategoriesId { get; set; }


    }

    public class MealCategories
    {
        public int MealCategoriesId { get; set; }
        public string MealName { get; set; }
        public string MealCategory { get; set; }

        public int RecipeId { get; set; }
        public RecipeDetails RecipeDetails { get; set; }

    }

    public class RecipeDetails
    {
        public int RecipeDetailsId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeURL { get; set; }

        public int FoodId { get; set; }
        public FoodDetails FoodDetails { get; set; }
    }

    public class FoodDetails
    {
        public int FoodDetailsId { get; set; }
        public string FoodName { get; set; }
        public bool DryStorage { get; set; }

        public int AllergyID { get; set; }
        public Allergies Allergies { get; set; }
    }
}

