using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace OnlineStore
{
    internal class Order
    {
        private int chooseItem;
        private int chooseDelivery;
        private static string choosenProduct;
        private static string choosenDelivery;
        private static string choosenDeliveryAdress;
        private static DateTime choosenDeliveryDate;
        private static string OrderNumber;
        Product product;
        Delivery delivery;


        public Order()
        {
            product = new Product();
            product.ShowAssortiment();
            do
            {
                Console.Write("\n\nВыберите номер товара: ");
                if (int.TryParse(Console.ReadLine(), out chooseItem))
                {
                    if (chooseItem > 0 && chooseItem <= product.ShowAssortimentCount())
                    {
                        choosenProduct = product.ChooseProduct(chooseItem);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Товара не существует");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Товара не существует");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            while (string.IsNullOrEmpty(choosenProduct));
        }

        public void ShowDelivery()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Способы доставки:\n" +
                "1 - Самовывоз из магазина\n" +
                "2 - Доставка в пункт выдачи заказов (ПВЗ)\n" +
                "3 - Доставка на адрес клиента\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GetDelivery()
        {
            do
            {
                Console.Write("Выберите способ: ");
                if (int.TryParse(Console.ReadLine(), out chooseDelivery))
                {
                    if (chooseDelivery == 1)
                    {
                        {
                            delivery = new ShopDelivery();
                            choosenDeliveryAdress = delivery.ShowAdress();
                            choosenDeliveryDate = delivery.DeliveryDate;
                            choosenDelivery = delivery.ShowNameDelivery();
                        }
                    }
                    else if (chooseDelivery == 2)
                    {
                        delivery = new PickPointDelivery();
                        choosenDeliveryAdress = delivery.ShowAdress();
                        choosenDeliveryDate = delivery.DeliveryDate;
                        choosenDelivery = delivery.ShowNameDelivery();
                    }
                    else if (chooseDelivery == 3)
                    {
                        delivery = new HomeDelivery();
                        choosenDeliveryAdress = delivery.ShowAdress();
                        choosenDeliveryDate = delivery.DeliveryDate;
                        choosenDelivery = delivery.ShowNameDelivery();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Способ не найден");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Способ не найден");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            while (string.IsNullOrEmpty(choosenDelivery));
        }

        public static void CompleteOrder(string id)
        {
            OrderNumber = id + DateTime.Now.GetDateString();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tЗАКАЗ ОФОРМЛЕН\n");
            Console.ReadLine();
            Console.WriteLine($"\tНОМЕР ЗАКАЗА: {OrderNumber}");
            Console.Write($"ID: {id}\t\tДата заказа: {DateTime.Now.ToString("d")}\n\n");
            Console.WriteLine($"Товар: {choosenProduct}");
            Console.WriteLine($"Способ доставки: {choosenDelivery}\nАдрес: {choosenDeliveryAdress}");
            Console.WriteLine($"Дата доставки: {choosenDeliveryDate.ToString("d")}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
