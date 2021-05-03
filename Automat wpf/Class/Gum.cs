using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class Gum : Item
    {
        public Gum(string productName, int price) : base(productName, price)
        {
            Catagory = "Gum";
            ImageSource = @"C:\Users\phil5714\Downloads\Gum.png";
        }
    }
}