using OnlineStore;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new YourAccount();

            //Логин/пароль
            do
            {
                myAccount.LogIn();
                if (YourAccount.isYourAccount == true)
                {
                    break;
                }
            }
            while (YourAccount.isYourAccount == false);

            //Заказ. Ассортимент
            Order order = new Order();
            Console.ReadLine();
            Console.Clear();

            //Заказ. Способ доставки
            order.ShowDelivery();
            order.GetDelivery();
            Console.ReadLine();
            Console.Clear();

            //Заказ. Информация об оформленном заказе
            Order.CompleteOrder(myAccount.ID);
        }
    }
}