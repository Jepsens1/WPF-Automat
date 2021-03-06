using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Automat_wpf.Class;

namespace Automat_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User(200);
        Machine machine = new Machine();
        BitmapImage image = new BitmapImage();

        public MainWindow()
        {
            InitializeComponent();
            machine.AddItems();
           
        }

        private void BuyItem(object sender, RoutedEventArgs e)

        {

            Button b = (Button)sender;
            if (user.BuyItem(machine, b.Tag.ToString()))
            {    
                PurchaceLabel.Content = "Purchace complete";
                TotalMoney.Content = $"You have {machine.CurrentMoney} dollars to spend";
                Userlist.Content += $"{user.Items[user.Items.Count - 1].Name}\n";
                ItemImage.Source = GetImage(user.Items[user.Items.Count - 1]);  
            }
            
        }

        private void Deposit_Money(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Content)
            {
                case "5$":
                    user.Deposit(machine, 5);
                    break;
                case "10$":
                    user.Deposit(machine, 10);
                    break;
                case "20$":
                    user.Deposit(machine, 20);
                    break;
                default:

                    break;
            }
        }
        private void ReturnMoney(object sender, RoutedEventArgs e)
        {
            TotalMoney.Content = $"You have returned {machine.CurrentMoney}$";
            machine.ReturnMoney(user);
        }
        private BitmapImage GetImage(Item iteme)
        {
            Uri uri = new Uri(iteme.ImageSource);
            BitmapImage image = new BitmapImage(uri);
            return image;
        }

        private void RefillBtn_Click(object sender, RoutedEventArgs e)
        {
            machine.Refill();
        }
    }
}

