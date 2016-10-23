using System.Collections.Generic;
using System.Linq;

namespace BankAccounts
{
    class Client
    {
        protected readonly int Id;
        protected string FullName;
        protected List<BankAccount> BankAccounts = new List<BankAccount>();

        public int Identifier => Id;

        public Client(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public bool AddNewBankAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
            return true;
        }

        public double GetAllAmountOfMoneyInBankAccounts()
        {
            return BankAccounts.Select(x => x.AmountMoney).Sum();
        }


    }
}