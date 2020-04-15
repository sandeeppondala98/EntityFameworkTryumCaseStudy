using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFameworkTryumCase
{
    class EditMenuItemAdmin
    {
        public void EditMenuItem(string menuItemName)
        {
            truYumContext context = new truYumContext();
            var Query = from mentItem in context.MenuItems.Include(m=>m.Category)
                        where mentItem.Name == menuItemName
                        select mentItem;
            if (Query == null)
            {
                Console.WriteLine("Incorrect menu item.Please check");
                return;
            }

            foreach (var item in Query.ToList())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Name, item.Price.ToString(),
                    item.dateOfLaunch.ToString(), item.Active.ToString(), item.freeDelivery.ToString());


                Boolean myparameter = true;
                while (myparameter)
                {
                    if (item.Name == null)
                    {
                        Console.WriteLine("Incorrect menu item.  Please check");
                    }
                    else
                    {
                        Console.WriteLine("Enter Price to Check");
                        double myprice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter categoryId to Check");
                        string categoryName = Console.ReadLine();
                        if ((item.Price == myprice) &&(item.Category.Name == categoryName))
                        {
                            Console.WriteLine("All data is correct");
                            Console.WriteLine("Enter price to Change");
                            double newprice = double.Parse(Console.ReadLine());
                            item.Price = newprice;
                            myparameter = false;
                            Console.WriteLine("Data is saved. Here is the updated data");
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect category. Please reenter data");
                        }
                    }


                }




            }

        }
    }
}
