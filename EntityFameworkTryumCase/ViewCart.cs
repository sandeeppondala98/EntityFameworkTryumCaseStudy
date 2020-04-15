using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFameworkTryumCase
{
    public class ViewCart
    {
        public void ViewCartItems()
        {
            truYumContext context = new truYumContext();
            var Query = from cart in context.Carts.Include(m=>m.MenuItem)
                        where cart.UserId == 1
                        select cart;
            if (Query == null)
            {
                Console.WriteLine("no items in cart");
                return;
            }
            foreach (var item in Query.ToList())
            {
                Console.WriteLine("{0} {1}", item.UserId,item.MenuItem.Name);
                //var Query = from mentItem in context.MenuItems
                   //         where mentItem.Id == item.MenuItemId
                       //     select mentItem;

            }

        }
    }
}
