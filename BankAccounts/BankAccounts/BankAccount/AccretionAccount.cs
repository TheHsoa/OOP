namespace BankAccounts
{
    class AccretionAccount : BankAccount
    {
        private readonly double _initialPayment;
        private readonly double _interestRate;

        public AccretionAccount(int ownerId, double amount, double interestRate) : base(ownerId, amount)
        {
            _initialPayment = amount;
            _interestRate = interestRate;
            IsClosed = false;
        }

        public override bool TakeMoney(double amountMoney)
        {
            if (amountMoney < _initialPayment || Amount > amountMoney || IsClosed) return false;

            Amount -= amountMoney;

            return true;
        }

        public override bool Refill(double amountMoney)
        {
            if (amountMoney < _initialPayment || IsClosed) return false;

            Amount += amountMoney;

            return true;
        }

        public bool CapitalizingInterestPerMonth()
        {
            if (IsClosed) return false;

            Amount = Amount * _interestRate / 12;

            return true;
        }

    }
}