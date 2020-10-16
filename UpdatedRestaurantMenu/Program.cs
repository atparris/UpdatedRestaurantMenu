using System;
using System.Data;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            Console.WriteLine($"Welcome to My Menu! It was last updated: {menu.LastUpdated}\n");

            foreach (var item in menu.MenuItems)
            {
                Console.WriteLine($"Item: {item.Description}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Is New: {item.IsNew}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("Thanks for visiting!");
        }
    }
}