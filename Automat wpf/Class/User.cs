using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class User
    {
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        public int Money { get; set; }
        public User()
        {

        }
        public User(int _money)
        {
            Money = _money;
            Items = new List<Item>();
        }
    }
}
