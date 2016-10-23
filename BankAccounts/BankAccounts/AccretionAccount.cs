namespace BankAccounts
{
    class AccretionAccount : BankAccount
    {
        private readonly double _initialPayment;
        private readonly double _interestRate;

        public AccretionAccount(int id, int ownerId, double amount, double interestRate)
        {
            Id = id;
            OwnerId = ownerId;
            Amount = amount;
            _initialPayment = amount;
            _interestRate = interestRate;
            IsClosed = false;
        }

        public bool TakeMoney(double amountMoney)
        {
            if (amountMoney < _initialPayment || Amount > amountMoney || IsClosed) return false;

            Amount -= amountMoney;

            return true;
        }

        public bool Refill(double amountMoney)
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
