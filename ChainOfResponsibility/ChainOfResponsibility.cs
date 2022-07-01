using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class Company
    {
        public abstract string GetTheJobDone(int money, string product);
    }

    class Shop : Company
    {
        public override string GetTheJobDone(int money, string product)
        {
            if (money < 100)
            {
                return "Get out the bastard!";
            }

            Forge forge = new Forge();
            money /= 2;

            return forge.GetTheJobDone(money, product);
        }
    }

    class Forge : Company
    {
        public override string GetTheJobDone(int money, string product)
        {
            Tax tax = new Tax();
            money -= 20;
            switch (product)
            {
                case "sword":
                    product = "You get the sword.";
                    break;
                case "axe":
                    product = "You get the axe.";
                    break;
                case "amulet":
                    break;
                default:
                    product = "We failed to create what you asked.";
                    break;
            }

            return tax.GetTheJobDone(money, product);
        }
    }

    class Tax : Company
    {
        public override string GetTheJobDone(int money, string product)
        {
            money -= 5;
            Inquisition inquisition = new Inquisition();

            return inquisition.GetTheJobDone(money, product);
        }
    }

    class Inquisition : Company
    {
        public override string GetTheJobDone(int money, string product)
        {
            if (product != "amulet")
            {
                money -= 5;
                product = product + " Your cashback " + money.ToString();
            }
            else
            {
                product = "Уou go to the bonfire";
            }

            return product;
        }
    }
}
