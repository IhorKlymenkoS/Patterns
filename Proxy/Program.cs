using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount to be sent");
            Bank bank = new OneHundredPercentReliability();
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have received");
            Console.WriteLine(bank.TransferMoney(money));
        }
    }
}
