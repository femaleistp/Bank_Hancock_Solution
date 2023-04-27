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
                return _balance;
            }
            set
            {
                    _balance = value;    
            }
        }

        public decimal Deposit(decimal MoneyIn)
        {
            return _balance += MoneyIn;
        }

        public decimal Withdrawal(decimal MoneyOut)
        {
            MoneyOut *= -1m;
            if (MoneyOut < -500m)
            {
                MoneyOut = -500m;
            }
            _balance += MoneyOut;
            if (_balance < 0)
            {
                _balance = 0;
            }
            return _balance;
        }
    }
}