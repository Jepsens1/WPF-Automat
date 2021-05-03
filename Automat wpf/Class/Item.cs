using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class Item
    {
        public string Name { get; set; }

        public int Price { get; set; }
        public string Catagory { get; set; }

        public string ImageSource { get; set; }
        public int Amount { get; set; } = 0;
        //public int ItemsRemaining { get; set; }

        public Item(string productName, int price)
        {
            Name = productName;
            Price = price;
            
            
            //ItemsRemaining = itemsRemaining;
        }
    }
        
}
