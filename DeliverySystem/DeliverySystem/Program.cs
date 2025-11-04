using System;
using System.Runtime.ConstrainedExecution;
namespace DeliverySystem
{
    public class Program
    {
        public static void Main()
        {
            Vehicle scooter = new Scooter("Honda", 2018, 1200, 30);
            Vehicle car = new Car("BMW", 2011, 34000, 4);
            Vehicle van = new Van("Ford", 2020, 56000, 5, 1000);

            Console.WriteLine(scooter.GetInfo());
            Console.WriteLine($"Max speed: {scooter.GetMaxSpeed()} km/h");
            scooter.Move(20);
            ((Scooter)scooter).Charge();

            Console.WriteLine(car.GetInfo());
            Console.WriteLine($"Max speed: {car.GetMaxSpeed()} km/h");
            car.Move(50);

            Console.WriteLine(van.GetInfo());
            Console.WriteLine($"Max speed: {van.GetMaxSpeed()} km/h");
            ((Van)van).LoadCargo(800);
            Console.WriteLine(van.GetInfo());
            ((Van)van).LoadCargo(300);
            ((Van)van).UnloadCargo();
        }
    }
}