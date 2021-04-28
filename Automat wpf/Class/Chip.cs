using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class Chip : Item
    {
        public Chip(string productName, int price) : base(productName, price)
        {
            Catagory = "Chips";
            ImageSource = @"C:\Users\PhillipPC\Source\Repos\WPF-Automat\Automat wpf\Images\Chips.png";
        }
    }
}
