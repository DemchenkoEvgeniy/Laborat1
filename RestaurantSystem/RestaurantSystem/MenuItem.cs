using RestaurantSystem;

namespace RestaurantSystem
{
    public abstract class MenuItem : IPriced
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string Category { get; protected set; }

        protected MenuItem(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public abstract string GetDescription();

        public override string ToString()
        {
            return $"{Name} ({Category}) - {Price} грн";
        }
    }
}
