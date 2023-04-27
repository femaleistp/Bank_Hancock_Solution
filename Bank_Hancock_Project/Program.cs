﻿namespace Bank_Hancock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MenuSelection = string.Empty;
            Bank bank = new Bank(1000m);

            for(; ;)
            {
                Menu();
                MenuSelection = Console.ReadLine();
                Message(MenuSelection);
            }

            void Menu()
            {
                if (bank.Balance == 0)
                {
                    Console.WriteLine("To deposit press 1, ENTER\nTo exit press 3, ENTER");
                }
                else
                {
                    Console.WriteLine("To deposit press 1, ENTER\nTo withdrawal press 2, ENTER\nTo exit press 3, ENTER");
                }
            }

            void Message(string option)
            {
                if (option == "3")
                {
                    Environment.Exit(0);
                }

                Console.Write("Enter amount:  ");
                decimal change = Decimal.Parse(Console.ReadLine());

                if (option == "1")
                {
                    bank.Deposit(change);
                }

                else if (option == "2")
                {
                    bank.Withdrawal(change);
                }

                Console.Write("Balance:  ");
                if (bank.Balance == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(bank.FormatBalance);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}