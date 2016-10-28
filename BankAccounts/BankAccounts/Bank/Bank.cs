namespace BankAccounts.Bank
{
    public class Bank
    {
       public bool TrancferMoneyFromAccountToAccount(BankAccount senderAccount, BankAccount recipientAccount, double ammountMoney)
        {
            if (ammountMoney > senderAccount.AmountMoney) return false;

            senderAccount.TakeMoney(ammountMoney);
            recipientAccount.Refill(ammountMoney);

            return true;
        }
    }
}
