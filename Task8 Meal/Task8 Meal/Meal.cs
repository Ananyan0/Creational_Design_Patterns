namespace _Meal
{
    class Meal
    {
        private string _drink;
        private string _dessert;
        private string _dish;
        private string _bread;

        public string Drink
        {
            get => _drink;
            set => _drink = value;
        }
        public string Dessert
        {
            get => _dessert;
            set => _dessert = value;
        }
        public string Dish
        {
            get => _dish;
            set => _dish = value;
        }
        public string Bread
        {
            get => _bread;
            set => _bread = value;
        }
    }
}
