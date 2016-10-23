namespace BankAccounts.Bank
{
    class Bank
    {
        private static Bank _bank;
        private Bank() { }

        public static Bank GetBank()
        {
            return _bank ?? (_bank = new Bank());
        }

        public bool TrancferMoneyFromAccountToAccount(BankAccount senderAccount, BankAccount recipientAccount, double ammountMoney)
        {
            if (ammountMoney > senderAccount.AmountMoney) return false;

            senderAccount.TakeMoney(ammountMoney);
            recipientAccount.Refill(ammountMoney);

            return true;
        }

    }
}
