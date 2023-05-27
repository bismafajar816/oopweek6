using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class CoffeeShop
    {
        public string name;
        public List<MenuItem> menu;
        public List<string> orders;
        public CoffeeShop(string name)
        {
            this.name = name;
            menu = new List<MenuItem>();
            orders = new List<string>();
        }
        public void AddItemToMenuList(MenuItem m)
        {
            menu.Add(m);
        }
        public void AddItemToOrderList(string s)
        {
            orders.Add(s);
        }
        public MenuItem CheapestItem()
        {
            List<MenuItem> sortedList = new List<MenuItem>();
            sortedList = menu.OrderBy(o => o.price).ToList();
            return sortedList[0];
            //here sorting is done the item with min price will appear at 0 index 
            // so we return 0 index of sorted list
        }
        public void FulfillItem(int index)
        {
            orders.RemoveAt(index);
        }
        public List<MenuItem> CategorizedList(string type)
        {
            List<MenuItem> food = new List<MenuItem>();
            foreach(var x in menu)
            {
                if(x.type == type)
                {
                    food.Add(x);
                }
            }
            return food;
        }
         public int GetPriceOfEachItem(string name)
        {
            int price = menu.Find(menu => menu.name == name).price;
            return price;
        }
        public int GetTotalPrice()
        {
            int total = 0;
            foreach(var x in orders)
            {
                total += GetPriceOfEachItem(x);
            }
            return total;
        }
    }
}
