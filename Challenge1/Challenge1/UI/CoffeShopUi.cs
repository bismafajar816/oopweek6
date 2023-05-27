using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;
namespace Challenge1.UI
{
    class CoffeShopUi
    {
        public static string OrderItem()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            return name;
        }
        static public void DisplayOrderMessage()
        {
            Console.WriteLine("Your Order is Added");
        }
        static public void WrongInput()
        {
            Console.WriteLine("Not Available...");
            Console.WriteLine("Wrong Input...");

        }
        public static void ShowOrdersList(List<string> M)
        {
            foreach (var items in M)
            {
                Console.WriteLine(items.PadRight(15));
            }
        }
    }
}
