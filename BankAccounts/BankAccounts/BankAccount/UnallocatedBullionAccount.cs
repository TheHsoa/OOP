using System;

namespace BankAccounts
{
    class UnallocatedBullionAccount : BankAccount
    {
        private readonly int _metalType;
        private double ExchangeRate { get; set; }

        public new double AmountMoney { get { return Amount * ExchangeRate; } }

        public UnallocatedBullionAccount(int ownerId, double amount, int metalType, double exchangeRate) : base(ownerId, amount)
        { 
            _metalType = metalType;
            ExchangeRate = exchangeRate;
            Amount /= ExchangeRate;
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

        public override bool Refill(double amountMoney)
        {
            if (IsClosed) return false;

            Amount += amountMoney / ExchangeRate;

            return true;
        }

        public override bool TakeMoney(double amountMoney)
        {
            double amountGramm = amountMoney / ExchangeRate;
            if (amountGramm <= Amount || !IsClosed)
            {
                Amount -= amountGramm;
                return true;
            }

            return false;
        }
    }
}