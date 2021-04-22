using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    enum Flavour
    {
        Cherry,
        Strawberry,
        Original,
        SugarFree
    }
    class Soda : Item
    {
        public Flavour Flavour { get; set; }
        public Soda(string productName, int price, Flavour _flavour): base(productName, price)
        {
            Flavour = _flavour;
        }
    }
}
