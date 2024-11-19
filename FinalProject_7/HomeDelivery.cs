using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class HomeDelivery: Delivery
    {
        private string nameDelivery = "Доставка на адрес клиента";
        private string adress = YourAccount.yourAdress;
        private int daysForDelivery = 2;
        public override DateTime DeliveryDate
        {
            get
            {
                return DateTime.Now.AddDays(daysForDelivery);
            }
            protected set
            {

            }
        }
        public override string ShowAdress()
        {
            return adress;
        }
        public override string ShowNameDelivery()
        {
            return nameDelivery;
        }
    }
}
