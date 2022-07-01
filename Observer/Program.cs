using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observer = new Observer();
            Console.WriteLine(observer.WinLottery());
        }
    }
}
