using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Automat_wpf;

namespace Automat_wpf.Class
{
    class User
    {
        public List<Item> Items { get; set; }
        public int Money { get; set; }
        public User()
        {

        }
        public User(int _money)
        {
            Money = _money;
            Items = new List<Item>();
        }
        public void Deposit(Machine machine, int depositamount)
        {
            if (Money >= depositamount)
            {
                machine.CurrentMoney += depositamount;
                Money -= depositamount;
                ((MainWindow)System.Windows.Application.Current.MainWindow).TotalMoney.Content = $"You have {machine.CurrentMoney} dollars to spend";
                ((MainWindow)System.Windows.Application.Current.MainWindow).MoneyDeposit.Content = $"You have deposited {depositamount}";

            }
            else
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).MoneyDeposit.Content = "You dont have enough money";
            }
        }
        public bool BuyItem(Machine machine, string CatagoryOfItem)
        {
            
            ItemManager manager = new ItemManager();
            Item item = machine.GetItem(CatagoryOfItem);
            if (item == null)
            {
                return false;
            }
            else
            {
                Items.Add(item);
                
                //manager.InsertData(item);
                return true;
            }

        }
    }
}
