namespace BankAccounts.Client
{
    class VipClient : ClientBase
    {
        public new bool AddNewBankAccount(BankAccount bankAccount)
        {
            if (BankAccounts.Count >= 10) return false;

            base.AddNewBankAccount(bankAccount);

            return true;
        }

        public VipClient(string fullName) : base(fullName) { }
    }
}
