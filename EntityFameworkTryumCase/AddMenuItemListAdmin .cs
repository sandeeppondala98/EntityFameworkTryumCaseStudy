using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFameworkTryumCase
{
    public class AddMenuItemListAdmin
    {
        public void AddMenuItem(string name,string category,double price,Boolean isActive,DateTime dateOfLaunch,Boolean freeDelivery)
        {

            truYumContext context = new truYumContext();
            MenuItem menuItem = new MenuItem();
            menuItem.Name = name;
            menuItem.freeDelivery = freeDelivery;
            menuItem.Price = price;
            menuItem.Active = isActive;
            menuItem.dateOfLaunch = dateOfLaunch;
           
            int categoryId = context.Categories.Where(iter =>iter.Name.Equals(category,StringComparison.OrdinalIgnoreCase)).Select(iter =>iter.Id).FirstOrDefault();
            menuItem.CategoryId = categoryId;
            context.MenuItems.Add(menuItem);
            context.SaveChanges();
        }
    }
}
