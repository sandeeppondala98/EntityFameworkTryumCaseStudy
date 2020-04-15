using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFameworkTryumCase
{
    public class RemoveItemfromCart
    {
        public void RemoveFromCart(string menuItemName)
        {
            truYumContext context = new truYumContext();
            var Query = from cart in context.Carts.Include(m=>m.MenuItem)
                        where cart.MenuItem.Name == menuItemName
                        select cart;
            if (Query == null)
            {
                Console.WriteLine("No item in cart for the user");
                return;
            }
            foreach (var item in Query.ToList())
            {
                if (item.MenuItem.Name == menuItemName)
                {
                    context.Carts.Remove(item);
                    context.SaveChanges();
                    Console.WriteLine("Menu item removed from cart successfully");
                }


            }
        }
    }
}
