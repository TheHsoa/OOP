using System;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(1, "Василий Иванович Шмидт");

            client.AddNewBankAccount(new SavingAccount(1, client.Identifier, 14823.1));
            client.AddNewBankAccount(new SettlementAccount(2, client.Identifier, 5123.3, 100));

            Console.WriteLine(client.GetAllAmountOfMoneyInBankAccounts());

            Console.ReadKey();

        }
    }
}