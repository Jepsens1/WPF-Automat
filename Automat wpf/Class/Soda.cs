using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    enum Flavour
    {
        Cherry = 5,
        Strawberry,
        Original,
        SugarFree
    }
    class Soda : Item
    {
        public Soda(string productName, int price): base(productName, price)
        {
            
            Catagory = "Soda";
            ImageSource = @"C:\Users\phil5714\Downloads\Soda.png";
        }
    }
}
