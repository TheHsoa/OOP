namespace BankAccounts
{
    class SettlementAccount : BankAccount
    {
        private readonly double _serviceFee;

        public SettlementAccount(int ownerId, double amount, double serviceFee) : base(ownerId, amount)
        {
            _serviceFee = serviceFee;
        }

        public override bool TakeMoney(double amountMoney)
        {
            if (amountMoney > Amount || IsClosed) return false;

            Amount -= amountMoney;

            return true;
        }

        public override bool Refill(double amountMoney)
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