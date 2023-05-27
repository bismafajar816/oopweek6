using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;
using Challenge1.UI;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop shop = new CoffeeShop("Tesha");
            int option;
            do
            {
                option = Display.menu();
                Display.ClearDisplay();
                if (option == 1)
                {
                    MenuItem input = MenuItemUI.AddItem();
                    shop.AddItemToMenuList(input);
                    Display.ClearDisplay();
                }
                else if (option == 2)
                {
                    MenuItem input = shop.CheapestItem();
                    MenuItemUI.ShowCheapest(input);
                    Display.ClearDisplay();
                }
                else if (option == 3)
                {
                    List<MenuItem> category = new List<MenuItem>();
                    category = shop.CategorizedList("Drink");
                    MenuItemUI.ShowMenuList(category);
                    Display.ClearDisplay();
                }
                else if (option == 4)
                {
                    List<MenuItem> category = new List<MenuItem>();
                    category = shop.CategorizedList("Food");
                    MenuItemUI.ShowMenuList(category);
                    Display.ClearDisplay();
                }
                else if (option == 5)
                {
                    string name = CoffeShopUi.OrderItem();
                    MenuItem m = shop.menu.Find(s => s.name == name);
                    if (m != null)
                    {
                        shop.AddItemToOrderList(name);
                        CoffeShopUi.DisplayOrderMessage();
                        Display.ClearDisplay();
                    }
                    else
                    {
                        CoffeShopUi.WrongInput();
                    }


                }
                else if (option == 6)
                {
                    int index = 0;
                    shop.FulfillItem(index);
                    index++;
                    Display.ClearDisplay();
                }
                else if (option == 7)
                {
                    CoffeShopUi.ShowOrdersList(shop.orders);
                    Display.ClearDisplay();
                }
                else if (option == 8)
                {
                    int total = shop.GetTotalPrice();
                    MenuItemUI.DisplayPrice(total);
                    Display.ClearDisplay();
                }
                else if (option >= 9)
                {
                    Display.DisplayWrongOption();
                }

            }
            while (option != 9);
            Display.ClearDisplay();
        }
    }
}
