using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;
namespace Challenge1.UI
{
    class MenuItemUI
    {
        public static MenuItem AddItem()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Price: ");
            int price = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name, type, price);
            return item;
        }
        public static void ShowMenuList(List<MenuItem> menu)
        {
            Console.WriteLine("Name" + "\t\t\t" + "Type" + "\t\t" + "Price");
            foreach(var x in menu)
            {
                Console.WriteLine(x.name + "\t\t\t" + x.type + "\t\t" + x.price);
            }
        }
        public static void DisplayPrice(int p)
        {
            Console.WriteLine("Total payable price" + "\t\t" + p);
        }
        public static void ShowCheapest(MenuItem x)
        {
            Console.WriteLine("Name" + "\t\t\t" + "Type" + "\t\t" + "Price");
           
                Console.WriteLine(x.name + "\t\t\t" + x.type + "\t\t" + x.price);
           
        }
    }
}
