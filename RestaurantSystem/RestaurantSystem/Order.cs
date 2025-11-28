using RestaurantSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Order
    {
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public OrderStatus Status { get; private set; }

        private readonly List<MenuItem> _items = new();
        public IReadOnlyList<MenuItem> Items => _items;

        public Order(int id, int tableNumber)
        {
            Id = id;
            TableNumber = tableNumber;
            Status = OrderStatus.New;
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Додано у замовлення: {item.Name}");
        }

        public decimal GetTotalPrice() => _items.Sum(i => i.Price);

        public void ChangeStatus(OrderStatus newStatus)
        {
            Console.WriteLine($"> Статус змiнено на: {newStatus}");
            Status = newStatus;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Стiл: {TableNumber} | Статус: {Status} | Сума: {GetTotalPrice()} грн";
        }
    }
}
