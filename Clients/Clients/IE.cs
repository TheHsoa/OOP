using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class IE : Client
    {
        private string FullName;
        private DateTime BirthDate;

        public new string ClientInfo => $"ИП {FullName} имеет сумму заказа равную {OrderPrice}";

        public IE(int id, int mainPhone, int orderPrice, string fullName, DateTime birthDate)
        {
            Id = id;
            MainPhone = mainPhone;
            OrderPrice = orderPrice;
            FullName = fullName;
            BirthDate = birthDate;
        }
    }
}
