namespace BankAccounts
{
    class UnallocatedBullionAccount : BankAccount
    {
        private readonly int _metalType;
        private double ExchangeRate { get; set; }

        public UnallocatedBullionAccount(int id, int ownerId, double amount, int metalType, double exchangeRate)
        {
            Id = id;
            OwnerId = ownerId;
            Amount = amount;
            _metalType = metalType;
            ExchangeRate = exchangeRate;
            Amount = amount / ExchangeRate;
            IsClosed = false;
        }

        public bool TakeMoney(double amountGramm, out double amount)
        {
            if (amountGramm <= Amount || !IsClosed)
            {
                Amount -= amountGramm;
                amount = amountGramm * ExchangeRate;
                return true;
            }

            amount = 0;

            return false;
        }

        public bool Refill(double amountMoney)
        {
            if (IsClosed) return false;

            Amount += amountMoney / ExchangeRate;

            return true;
        }

    }
}
