using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    enum NutTypes
    {
        Cashew,
        Almonds,
        ChiliNuts,
        Peanuts
    }
    class Nut : Item
    {
        public NutTypes TypeNuts { get; set; }
        public Nut(string productName, int price, NutTypes nuts) : base(productName, price)
        {
            TypeNuts = nuts;
            Catagory = "Nuts";
            ImageSource = @"C:\Users\phil5714\Downloads\Nuts.png";
        }

    }
}
