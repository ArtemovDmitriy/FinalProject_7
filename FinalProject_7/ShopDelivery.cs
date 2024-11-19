using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class ShopDelivery : Delivery
    {
        private string nameDelivery = "Самовывоз из магазина";
        private string adress = "Москва, ул.Театральная, д.1";
        private int daysForDelivery = 1;

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
