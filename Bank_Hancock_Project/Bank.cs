namespace Bank_Hancock
{
    internal class Bank
    {
        private decimal balance;

        public Bank(decimal Change)
        {
            Balance = Change;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    balance = 0;  
                }
                else
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal MoneyIn)
        {
            balance += MoneyIn;
        }

        public void Withdrawal(decimal MoneyOut)
        {
            MoneyOut *= -1m;
            if (MoneyOut < -500m)
            {
                MoneyOut = -500m;
            }
            balance += MoneyOut;
        }
    }
}