using System;
using System.Collections.Generic;
using System.Text;

namespace Automat_wpf.Class
{
    class GUI
    {
        Machine machine = new Machine();
        User human = new User(20);


        public void StartMenu()
        {
            Console.WriteLine("Please select a item you would like");
            Console.WriteLine("*********************");
            Console.WriteLine("* A - Fanta");
            Console.WriteLine("* B - Nuts");
            Console.WriteLine("* C - Gum");
            Console.WriteLine("* D - Candy");
            Console.WriteLine("* E - Doritos");
            Console.WriteLine("*********************");
        }
        public void MainMenu()
        {
            Console.WriteLine("How much would you like to deposit?");
            Console.WriteLine("1. 5$    2. 10$   3. 15$");
            machine.DepositMoney(human);
            StartMenu();
            string userinput = Console.ReadLine();
            machine.MakeSelection(human, userinput);
        }
    }
}
