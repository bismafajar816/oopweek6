using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    class Display
    {
        public static int menu()
        {
            Console.WriteLine("Welcome to Tesha’s Coffee Shop");
            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest Item in the menu");
            Console.WriteLine("3. View the Drink’s Menu");
            Console.WriteLine("4. View the Food’s Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill the Order");
            Console.WriteLine("7. View the Orders’s List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void ClearDisplay()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*     Welcome to Tesha's Shop        *");
            Console.WriteLine("**************************************");

        }
        public static void DisplayWrongOption()
        {
            Console.WriteLine("Option Not Available");
        }
        
    }
}
