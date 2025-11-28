using RestaurantSystem;
using System;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Restaurant();

            restaurant.AddMenuItem(new Dish(1, "Пiцца Маргарита", 150, "Пiца", false));
            restaurant.AddMenuItem(new Dish(2, "Суп-лапша", 95, "Перше", false));
            restaurant.AddMenuItem(new Drink(3, "Капучино", 70, "Напiй", 250, false));
            restaurant.AddMenuItem(new Drink(4, "Чай зелений", 55, "Напiй", 300, false));

            restaurant.PrintMenu();

            var order = restaurant.CreateOrder(202, 12);

            var pizza = restaurant.FindByName("Пiцца");
            var cappuccino = restaurant.FindByName("Капучино");

            order.AddItem(pizza);
            order.AddItem(cappuccino);

            Console.WriteLine($"Поточна сума замовлення: {order.GetTotalPrice()} грн\n");

            Console.WriteLine($"Статус замовлення: {order.Status}");
            order.ChangeStatus(OrderStatus.InProgress);
            order.ChangeStatus(OrderStatus.Ready);
            order.ChangeStatus(OrderStatus.Paid);

            Console.WriteLine();
            restaurant.PrintOrders();

            Console.WriteLine("\nНатиснiть клавiшу для виходу...");
            Console.ReadKey();
        }
    }
}
