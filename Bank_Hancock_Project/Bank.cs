namespace Bank_Hancock
{
    internal class Bank
    {
        private decimal _balance;
        public Bank(decimal Change)
        {
            Balance = Change;
        }

        public decimal Balance
        {
            get
            {
                if (_balance > 0)
                {
                    return _balance;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0;
                }
            }
        }

        public void Deposit(decimal MoneyIn)
        {
            _balance += MoneyIn;
        }

        public void Withdrawal(decimal MoneyOut)
        {
            MoneyOut *= -1m;
            if (MoneyOut < -500m)
            {
                MoneyOut = -500m;
            }
            _balance += MoneyOut;
        }
    }
}