namespace BankAccounts
{
    class SettlementAccount : BankAccount
    {
        private readonly double _serviceFee;

        public SettlementAccount(int id, int ownerId, double amount, double serviceFee)
        {
            Id = id;
            OwnerId = ownerId;
            Amount = amount;
            _serviceFee = serviceFee;
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

        public bool DrawDownServiceFee()
        {
            if (_serviceFee > Amount || IsClosed) return false;

            Amount -= _serviceFee;

            return true;
        }
    }
}