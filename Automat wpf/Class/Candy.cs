using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    enum CandyTypes
    {
        MatadorMix,
        ClickMix,
        Dragula
    }
    class Candy : Item
    {
        public CandyTypes TypeCandy { get; set; }
        public Candy(string productName, int price, CandyTypes type): base(productName, price)
        {
            TypeCandy = type;
            Catagory = "Candy";
            ImageSource = @"C:\Users\phil5714\Downloads\Candy.png";
        }
    }
}
