using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Product
    {
        private string[] assortiment = { "Телефон", "Телевизар", "Смарт часы", "Чайник", "Стиральная машинка", "Утюг" };
        public void ShowAssortiment()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список товаров");
            for(int i = 0; i < assortiment.Length; i++)
            {
                Console.WriteLine($"{i+1} - {assortiment[i]}");
            }
            Console.ForegroundColor= ConsoleColor.White;
        }
        public int ShowAssortimentCount()
        {
            return assortiment.Length;
        }
        public string ChooseProduct(int chooseItem)
        {
            return assortiment [chooseItem - 1];
        }
    }
}
