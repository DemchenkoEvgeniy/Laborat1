using RestaurantSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Restaurant
    {
        private readonly List<MenuItem> _menu = new();
        private readonly List<Order> _orders = new();

        public IReadOnlyList<MenuItem> Menu => _menu;
        public IReadOnlyList<Order> Orders => _orders;

        public void AddMenuItem(MenuItem item) => _menu.Add(item);

        public void PrintMenu()
        {
            Console.WriteLine("--- МЕНЮ ЗАКЛАДУ ---");
            int i = 1;
            foreach (var item in _menu)
                Console.WriteLine($"{i++}. {item.GetDescription()}");
            Console.WriteLine("---------------------");
        }

        public Order CreateOrder(int id, int table)
        {
            var order = new Order(id, table);
            _orders.Add(order);
            Console.WriteLine($"Створено замовлення №{id} для столика №{table}");
            return order;
        }

        public MenuItem? FindByName(string name) =>
            _menu.FirstOrDefault(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

        public void PrintOrders()
        {
            Console.WriteLine("--- СПИСОК ЗАМОВЛЕНЬ ---");
            foreach (var o in _orders)
                Console.WriteLine(o);
            Console.WriteLine("------------------------");
        }
    }
}
