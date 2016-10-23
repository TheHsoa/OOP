using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class LLC : Client
    {
        private string Name;
        private int BankAccount;

        public new string ClientInfo => $"ООО {Name} имеет сумму заказа равную {OrderPrice}";

        public LLC(int id, int mainPhone, int orderPrice, string name, int bankAccount)
        {
            Id = id;
            MainPhone = mainPhone;
            OrderPrice = orderPrice;
            Name = name;
            BankAccount = bankAccount;
        }
    }
}
