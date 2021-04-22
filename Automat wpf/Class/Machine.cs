using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automat_wpf.Class
{
    class Machine
    {

        public List<Item> Items { get; set; }
        public int Money { get; set; }


        public Machine()
        {

        }

        public string ReturnMoney(User human)
        {
            string temp = "";
            if (Money != 0)
            {
                human.Money += Money;
                temp = $"You get {Money} back in return";
            }
            else
            {
                temp = "You get no money back in return";
            }
            return temp;
        }
        public void DepositMoney(User human)
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Money += 5;
                    human.Money -= 5;
                    Console.WriteLine("You have succesfully deposited 5$");
                    break;
                case "2":
                    Money += 10;
                    human.Money -= 10;
                    Console.WriteLine("You have succesfully deposted 10$");
                    break;
                case "3":
                    Money += 15;
                    human.Money -= 15;
                    Console.WriteLine("You have succesfully deposited 15$");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        public void MakeSelection(User user, string selection)
        {

            switch (selection)
            {
                case "a":
                    if (Money >= 5)
                    {
                        Console.WriteLine("Thank you for choosing Fanta");
                        Console.WriteLine("Which flavour would you like?");
                        Console.WriteLine("1. Cherry    2. Strawberry   3. Original   4. SugarFree");
                        string userinput = Console.ReadLine();
                        if (userinput == "1")
                        {
                            Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Cherry));
                            Console.WriteLine(ReturnMoney(user));
                            Thread.Sleep(2000);
                        }
                        else if (userinput == "2")
                        {
                            user.Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Strawberry));
                            Console.WriteLine(ReturnMoney(user));
                            Thread.Sleep(2000);
                        }
                        else if (userinput == "3")
                        {
                            Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.Original));
                            Console.WriteLine(ReturnMoney(user));
                            Thread.Sleep(2000);
                        }
                        else if (userinput == "4")
                        {
                            Money -= 5;
                            user.Items.Add(new Soda("Fanta", 5, Flavour.SugarFree));
                            Console.WriteLine(ReturnMoney(user));
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "b":
                    if (Money >= 8)
                    {

                        Console.WriteLine("Thank you for choosing Nuts");
                        Console.WriteLine("Which type of nuts would you like?");
                        Console.WriteLine("1. Cashew    2. Almonds   3. ChiliNuts   4. Peanuts");
                        string userinput = Console.ReadLine();
                        if (userinput == "1")
                        {
                            Money -= 8;
                            user.Items.Add(new Nut("Cashew", 8, NutTypes.Cashew));
                        }
                        else if (userinput == "2")
                        {
                            Money -= 8;
                            user.Items.Add(new Nut("Almonds", 8, NutTypes.Almonds));
                        }
                        else if (userinput == "3")
                        {
                            Money -= 8;
                            user.Items.Add(new Nut("Chili nuts", 8, NutTypes.ChiliNuts));
                        }
                        else if (userinput == "4")
                        {
                            Money -= 8;
                            user.Items.Add(new Nut("Peanuts", 8, NutTypes.Peanuts));
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                    }
                    break;
                case "c":
                    if (Money >= 3)
                    {
                        Console.WriteLine("Thank you for choosing Bubblegum");
                        Money -= 3;
                        user.Items.Add(new Gum("Bubblegum", 3));
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "d":
                    if (Money >= 8)
                    {
                        Console.WriteLine("Thank you for choosing Candy");
                        Console.WriteLine("Which type of candy would you like?");
                        Console.WriteLine("1. Matadormix   2. Clickmix    3. Dragula");
                        string userinput = Console.ReadLine();
                        if (userinput == "1")
                        {
                            Money -= 8;
                            user.Items.Add(new Candy("Matador mix", 8, CandyTypes.MatadorMix));
                        }
                        else if (userinput == "2")
                        {
                            Money -= 8;
                            user.Items.Add(new Candy("ClickMix", 8, CandyTypes.ClickMix));
                        }
                        else if (userinput == "3")
                        {
                            Money -= 8;
                            user.Items.Add(new Candy("Dragula", 8, CandyTypes.Dragula));
                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;
                case "e":
                    if (user.Money >= 5)
                    {
                        Console.WriteLine("Thank you for choosing Doritos");
                        Money -= 5;
                        user.Items.Add(new Chip("Doritos", 5));

                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough money");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}


