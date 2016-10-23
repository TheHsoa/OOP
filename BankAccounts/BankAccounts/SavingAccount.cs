namespace BankAccounts
{
    class SavingAccount : BankAccount
    {
        public SavingAccount(int id, int ownerId, double amount)
        {
            Id = id;
            OwnerId = ownerId;
            Amount = amount;
            IsClosed = false;
        }

        public bool TakeMoney(double amountMoney)
        {
            if (amountMoney > Amount || IsClosed) return false;

            Amount -= amountMoney;

            return true;
        }

        public bool Refill(double amountMoney)
        {
            if (IsClosed) return false;

            Amount += amountMoney;

            return true;
        }
    }
}
