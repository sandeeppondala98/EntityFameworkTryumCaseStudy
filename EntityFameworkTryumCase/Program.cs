using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkTryumCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Admin and 2 for Customer");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                while (true)
                {
                    Console.WriteLine("Enter operations");
                    Console.WriteLine("1.View");
                    Console.WriteLine("2.Add");
                    Console.WriteLine("3.Edit");
                    int operationNumber = int.Parse(Console.ReadLine());
                    if (operationNumber == 1)
                    {
                        Console.WriteLine("1.View");
                        ViewMenuItemListAdmin viewobj = new ViewMenuItemListAdmin();
                        viewobj.ViewMenuItemAdmin();
                    }
                    else if (operationNumber == 2)
                    {
                        Console.WriteLine("2.Add");
                        AddMenuItemListAdmin addObj = new AddMenuItemListAdmin();
                        Console.WriteLine("add name");
                        string name = Console.ReadLine();
                        Console.WriteLine("add category");
                        string category = Console.ReadLine();
                        Console.WriteLine("add price");
                        double price =  double.Parse(Console.ReadLine());
                        Console.WriteLine("add isActive");
                        Boolean isActive =Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("add dateOfLaunch");
                        DateTime dateOfLaunch =DateTime.Parse( Console.ReadLine());
                        Console.WriteLine("add freeDelivery");
                        Boolean freeDelivery = Boolean.Parse( Console.ReadLine());

                        addObj.AddMenuItem(name, category, price, isActive, dateOfLaunch, freeDelivery);
                    }
                    else
                    {
                        Console.WriteLine("3.Edit");
                        Console.WriteLine("Enter any menuitem Name");
                        string name=Console.ReadLine();
                        EditMenuItemAdmin editobj = new EditMenuItemAdmin();
                        editobj.EditMenuItem(name);
                    }


                }

            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Enter operations");
                    Console.WriteLine("1.View Cart Item");
                    Console.WriteLine("2.Add menu item");
                    Console.WriteLine("3.Remove item from cart");
                    Console.WriteLine("4.view Menu item List");

                    int operationNumber = int.Parse(Console.ReadLine());
                    if (operationNumber == 1)
                    {
                        Console.WriteLine("1.View Cart Item");
                        ViewCart v = new ViewCart();
                        v.ViewCartItems();
                    }
                    else if (operationNumber == 2)
                    {
                        Console.WriteLine("2.Add menu item");
                        AddaMenuItemtoCart a = new AddaMenuItemtoCart();
                        Console.WriteLine("2.Add menu itemname");
                        string itemName = Console.ReadLine();
                        a.AddToCart(itemName);
                    }
                    else if(operationNumber==3)
                    {
                        Console.WriteLine("3.Remove item from cart");
                        Console.WriteLine("enter the itemname to remove");
                        string removeitemName = Console.ReadLine();
                        RemoveItemfromCart rem = new RemoveItemfromCart();
                        rem.RemoveFromCart(removeitemName);
                    }
                    else
                    {
                        Console.WriteLine("ViewMenuItemCustomer");
                        ViewMenuItemListCustomer vm = new ViewMenuItemListCustomer();
                        vm.ViewMenuItemCustomer();

                    }

                }
            }
        }
    }
}
