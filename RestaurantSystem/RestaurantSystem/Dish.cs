using RestaurantSystem;
using System.Xml.Linq;

namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public bool IsVegetarian { get; private set; }

        public Dish(int id, string name, decimal price, string category, bool isVegetarian)
            : base(id, name, price, category)
        {
            IsVegetarian = isVegetarian;
        }

        public override string GetDescription()
        {
            return $"{Name} ({Category}, {(IsVegetarian ? "вегетарiанська" : "звичайна")}) - {Price} грн";
        }
    }
}
