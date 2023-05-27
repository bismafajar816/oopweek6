using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
namespace UAMS.UI
{
    class MenuUI
    {
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("^            UAMS                     ^");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public static void ClearScreen()
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static int menu()
        {
            Console.WriteLine("1. add student");
            Console.WriteLine("2. add degree");
            Console.WriteLine("3.generate Merit");
            Console.WriteLine("4.view Registered Students");
            Console.WriteLine("5.view Student for a Specific program");
            Console.WriteLine("6.Register Subjects for a Specific Student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            string option = Console.ReadLine();
            int opt = Intvalidation(option);
            return opt;

        }
        public static int Intvalidation(string number)
        {
            if (int.TryParse(number, out int result))
            {
                return result;
            }
            string num = "er";
            int res = 0;
            while (!int.TryParse(num.ToString(), out res))
            {
                Console.WriteLine("Enter integer number: ");
                num = Console.ReadLine();
            }
            return res;
        }

    }
}
