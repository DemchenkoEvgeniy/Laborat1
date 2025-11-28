using RestaurantSystem;
using System.Xml.Linq;

namespace RestaurantSystem
{
    public class Drink : MenuItem
    {
        public int VolumeMl { get; private set; }
        public bool IsAlcoholic { get; private set; }

        public Drink(int id, string name, decimal price, string category, int volumeMl, bool isAlcoholic)
            : base(id, name, price, category)
        {
            VolumeMl = volumeMl;
            IsAlcoholic = isAlcoholic;
        }

        public override string GetDescription()
        {
            string alcohol = IsAlcoholic ? "з алкоголем" : "без алкоголю";
            return $"{Name} ({Category}, {VolumeMl} мл, {alcohol}) - {Price} грн";
        }
    }
}
