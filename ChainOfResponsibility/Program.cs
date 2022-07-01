using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Console.WriteLine("What do you want to buy? sword, axe, amulet?");
            string product = Console.ReadLine();
            Console.WriteLine("It won't be cheap! Don't spare money. (enter amount of money)");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(shop.GetTheJobDone(money, product));
        }
    }
}
