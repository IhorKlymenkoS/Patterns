using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Observer
    {
        public int WinLottery()
        {
            Lottery lottery = new Lottery();
            Money money = new Money();
            money.Value = 100;
            int count = 0;
            int number = 0;
            while (number != 77 && money.Value > 0)
            {
                number = lottery.GoLottery();
                count++;
                money.Value -= 1;
            }

            if (money.Value <= 0)
            {
                count = -1;
            }

            return count;
        }
    }

    class Lottery
    {
        public int GoLottery()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
    }

    class Money
    {
        public int Value { get; set; }
    }
}
