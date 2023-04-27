namespace Bank_Hancock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MenuSelection = string.Empty;
            Bank bank = new Bank(1000m);

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Menu();
                while (MenuSelection == "2" && bank.Balance == 0)
                {
                    Menu();
                }

                if (MenuSelection == "1" || MenuSelection == "2")
                {
                    Message(MenuSelection);
                }
            } while (MenuSelection != "3");

            void Menu()
            {
                do
                {
                    if (bank.Balance == 0)
                    {
                        Console.WriteLine("To deposit press 1, ENTER\nTo exit press 3, ENTER");
                    }
                    else
                    {
                        Console.WriteLine("To deposit press 1, ENTER\nTo withdrawal press 2, ENTER\nTo exit press 3, ENTER");
                    }
                    MenuSelection = Console.ReadLine();

                } while (MenuSelection != "1" && MenuSelection != "2" && MenuSelection != "3");
            }

            void Message(string option)
            {
                Console.Write("Enter amount:  ");
                decimal change = Decimal.Parse(Console.ReadLine());

                if (option == "1")
                {
                    change = bank.Deposit(change);
                }

                else if (option == "2")
                {
                    change = bank.Withdrawal(change);
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
                Console.WriteLine(change.ToString("C"));
                Console.WriteLine();
            }
        }
    }
}