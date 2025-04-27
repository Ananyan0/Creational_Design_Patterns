using _Meal;

namespace Meal_Builder
{
    class MealBuilder
    {
        private Meal _meal = new Meal();

        public MealBuilder GetDrink()
        {
            _meal.Drink = "Alcohol";
            System.Console.WriteLine(_meal.Drink);
            return this;
        }

        public MealBuilder GetDessert()
        {
            _meal.Dessert = "Cake";
            System.Console.WriteLine(_meal.Dessert);
            return this;
        }

        public MealBuilder GetDish()
        {
            _meal.Dish = "Some dishes";
            System.Console.WriteLine(_meal.Dish);
            return this;
        }

        public MealBuilder GetBread()
        {
            _meal.Bread = "Black bread";
            System.Console.WriteLine(_meal.Bread);
            return this;
        }

        public Meal Build()
        {
            return _meal;
        }
    }
}
