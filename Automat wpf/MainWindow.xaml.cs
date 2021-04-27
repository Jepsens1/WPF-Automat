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
        ItemManager manager = new ItemManager();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BuyItem(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Content)
            {
                case "Soda 5$":
                    if (machine.Money >= 5)
                    {
                        Soda soda = new Soda("Fanta", 5, Flavour.Original);
                        user.Items.Add(soda);
                        machine.Money -= 5;
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                        PurchaceLabel.Content = $"You have now bought a Fanta";
                        manager.InsertData(soda);
                    }
                    else
                    {
                        PurchaceLabel.Content = "You dont have the money to buy";
                    }
                    break;
                case "Candy 5$":
                    if (machine.Money >= 5)
                    {
                        Candy candy = new Candy("MatadorMix", 5, CandyTypes.MatadorMix);
                        user.Items.Add(candy);
                        machine.Money -= 5;
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                        PurchaceLabel.Content = "You have now bought MatadorMix";
                        manager.InsertData(candy);
                    }
                    else
                    {
                        PurchaceLabel.Content = "You dont have the money to buy";
                    }
                    break;
                case "Nuts 7$":
                    if (machine.Money >= 7)
                    {
                        Nut nut = new Nut("Cashew", 7, NutTypes.Cashew);
                        user.Items.Add(nut);
                        machine.Money -= 7;
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                        PurchaceLabel.Content = "You have now bought Cashew Nuts";
                        manager.InsertData(nut);
                    }
                    else
                    {
                        PurchaceLabel.Content = "You dont have the money to buy";
                    }
                    break;
                case "Chips 10$":
                    if (machine.Money >= 10)
                    {
                        Chip chip = new Chip("Doritos", 10);
                        user.Items.Add(chip);
                        machine.Money -= 10;
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                        PurchaceLabel.Content = "You have now bought Doritos";
                        manager.InsertData(chip);
                    }
                    else
                    {
                        PurchaceLabel.Content = "You dont have the money to buy";
                    }
                    break;
                case "BubbleGum 3$":
                    if (machine.Money >= 3)
                    {
                        Gum gum = new Gum("Bubblegum", 3);
                        user.Items.Add(gum);
                        machine.Money -= 3;
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                        PurchaceLabel.Content = "You have now bought Bubblegum";
                        manager.InsertData(gum);
                    }
                    else
                    {
                        PurchaceLabel.Content = "You dont have the money to buy";
                    }
                    break;
                default:
                    break;
            }
        }

        private void Deposit_Money(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Content)
            {
                case "5$":
                    if (user.Money >= 5)
                    {
                        user.Money -= 5;
                        machine.Money += 5;
                        MoneyDeposit.Content = "You have deposited 5$";
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";

                    }
                    else
                    {
                        MoneyDeposit.Content = "You dont have enough money";
                    }
                    break;
                case "10$":
                    if (user.Money >= 10)
                    {
                        user.Money -= 10;
                        machine.Money += 10;
                        MoneyDeposit.Content = "You have deposited 10$";
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                    }
                    else
                    {
                        MoneyDeposit.Content = "You dont have enough money";
                    }
                    break;
                case "20$":
                    if (user.Money >= 20)
                    {
                        user.Money -= 20;
                        machine.Money += 20;
                        MoneyDeposit.Content = "You have deposited 20$";
                        TotalMoney.Content = $"You have {machine.Money} dollars to spend";
                    }
                    else
                    {
                        MoneyDeposit.Content = "You dont have enough money";
                    }
                    break;
                default:
                    break;
            }
        }
        private void ReturnMoney(object sender, RoutedEventArgs e)
        {
            user.Money += machine.Money;
            TotalMoney.Content = $"You have returned {machine.Money}$";
            machine.Money = 0;
        }
    }
}

