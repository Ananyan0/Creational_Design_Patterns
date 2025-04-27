using _Meal;
using Meal_Builder;

class Program
{
    static void Main(string[] args)
    {
        Meal meal = new MealBuilder()
                    .GetDrink()
                    .GetBread()
                    .GetDessert()
                    .GetDish()
                    .Build();
    }
}