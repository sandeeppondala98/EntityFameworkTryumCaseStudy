using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkTryumCase
{
    public class ViewMenuItemListAdmin
    {
        public void ViewMenuItemAdmin()
        {
            truYumContext context = new truYumContext();
            var Query = from menuitem in context.MenuItems
                        select new
                        {
                            menuitem.Name,
                            menuitem.dateOfLaunch,
                            menuitem.Price,
                            menuitem.Category,
                            menuitem.Active,
                            menuitem.freeDelivery
                        };

            foreach (var item in Query.ToList())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",item.Name,item.Price.ToString(),
                    item.dateOfLaunch.ToString(), item.Active.ToString(), item.freeDelivery.ToString());
            }
        }
    }
}
