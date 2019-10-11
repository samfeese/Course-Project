namespace FoodGenerator.Model
{
    public class BreakfastMeals
    {
        public int BreakfastMealsId { get; set; }

        public string BreakfastMealName { get; set; }

        public string MealDesciption { get; set; }

        public Utility Utilities { get; set; }
        public int UtilityId { get; set; }


        public MealCategories Meal { get; set; }
        public int MealCategoriesId { get; set; }

        

    }
}

