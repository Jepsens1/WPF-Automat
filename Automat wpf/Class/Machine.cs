using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automat_wpf.Class
{
    class Machine
    {
        public List<Item> Items { get; set; }
        public int CurrentMoney { get; set; }


        public Machine()
        {
            Items = new List<Item>();
        }
        public void ReturnMoney(User user)
        {
            user.Money += CurrentMoney;
            CurrentMoney = 0;
        }
        public void AddItems()
        { 
            Items.Add(new Soda("Fanta", 5, Flavour.Original));
            Items.Add(new Nut("Cashew", 7, NutTypes.Cashew));
            Items.Add(new Candy("Matador Mix", 5, CandyTypes.MatadorMix));
            Items.Add(new Chip("Doritos", 10));
            Items.Add(new Gum("Bubblegum", 3));
        }
        public Item GetItem(string ButtonValue)
        {
            Item item = FindItem(ButtonValue);
            if (item == null)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).PurchaceLabel.Content = "Sorry out of stock";
                return null;
            }
            if (CurrentMoney >= item.Price)
            {
                CurrentMoney -= item.Price;
                Items.Remove(item);
                return item;
            }
            else
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).PurchaceLabel.Content = "You dont have the money to buy";
            }
            return null;
        }
        public Item FindItem(string ButtonValue)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Catagory == ButtonValue)
                {
                    return Items[i];
                }
            }
            return null;
        }

    }
}


