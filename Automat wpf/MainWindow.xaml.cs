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
        Button button = new Button();
        public MainWindow()
        {
            InitializeComponent();
            button.Click += BuyItem;
        }

        private void BuyItem(object sender, RoutedEventArgs e)
        {
            if (button.Name == "SodaButton")
            {
                Soda soda = new Soda("Fanta", 5, Flavour.Original);
                user.Items.Add(soda);
                machine.Money -= 5;
                TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                test.Content = "test";   
            }
            else
            {
                test.Content = "test1";
            }
        }

        private void Deposit5_Click(object sender, RoutedEventArgs e)
        {
            if (user.Money >= 5)
            {
                user.Money -= 5;
                machine.Money += 5;
                MoneyDeposit.Content = "You have deposited 5$";
                TotalMoney.Content = $"You have {machine.Money} dollars to spend";
            }
        }
        private void Deposit10_Click(object sender, RoutedEventArgs e)
        {
            if (user.Money >= 10)
            {
                user.Money -= 10;
                machine.Money += 10;
                MoneyDeposit.Content = "You have deposited 10$";
                TotalMoney.Content = $"You have {machine.Money} dollars to spend";
            }
        }
        private void Deposit20_Click(object sender, RoutedEventArgs e)
        {
            if (user.Money >= 20)
            {
                user.Money -= 20;
                machine.Money += 20;
                MoneyDeposit.Content = "You have deposited 20$";
                TotalMoney.Content = $"You have {machine.Money} dollars to spend";
            }
        }
        
    }
}

