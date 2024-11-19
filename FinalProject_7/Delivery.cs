using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal abstract class Delivery
    {
        public abstract DateTime DeliveryDate { get; protected set; }
        public abstract string ShowAdress();
        public abstract string ShowNameDelivery();
    }
}
