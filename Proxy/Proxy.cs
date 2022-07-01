using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
        abstract class Bank
        {
            public abstract int TransferMoney(int money);
        }

         class RealVasya : Bank
        {
            public override int TransferMoney(int money)
            {
                if (money < 100)
                {
                    return money;
                }

                return 0;
            }
        }

         class OneHundredPercentReliability : Bank
        {
            RealVasya RealVasya;
            public override int TransferMoney(int money)
            {
                if (RealVasya == null)
                {
                    RealVasya = new RealVasya();
                }

                return RealVasya.TransferMoney(money);
            }
        }
    }
