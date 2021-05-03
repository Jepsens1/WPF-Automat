using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class ItemManager
    {
        Dalmanager dalmanager = new Dalmanager();

        public void InsertData(Item item)
        {
           dalmanager.Insert(item);
        }
        public List<Item> Refill()
        {
            return dalmanager.Refill();
        }
       
        
    }
}
