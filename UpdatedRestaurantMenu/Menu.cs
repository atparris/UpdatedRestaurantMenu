using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }

        public Menu()
        {
            LastUpdated = DateTime.Now;
            MenuItems = new List<MenuItem>
            {
                new MenuItem(10.00M, "pizza", Category.MainCourse, false),
                new MenuItem(8.00M, "cheesecake", Category.Dessert, true),
                new MenuItem(4.00M, "fries", Category.Appetizer, false),
                new MenuItem(2.00M, "shake" , Category.Dessert, true)
            };
        }

        public Menu(DateTime lastUpdated, List<MenuItem> menuItems)
        {
            LastUpdated = lastUpdated;
            MenuItems = menuItems;
        }
        
        public void AddItem(MenuItem anItem)
        {
            MenuItems.Add(anItem);
        }

        public void RemoveItem(MenuItem anItem)
        {
            int indexToBeRemoved = -1;
            for(int i = 0; i < MenuItems.Count; i++)
            {
                
                if (this.Equals(anItem))
                {
                    indexToBeRemoved = i;
                    break;
                }
            }

            MenuItems.RemoveAt(indexToBeRemoved);
        }
    }
}
