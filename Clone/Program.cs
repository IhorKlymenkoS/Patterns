using System;

namespace Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new ConcretePrototype1(1, "white", "Dolly sheep");
            Prototype clone = prototype.Clone();
            Console.WriteLine(clone.Id + " " + clone.Name + " " + clone.Color);
            prototype = new ConcretePrototype2(2, "black", "Molly sheep");
            clone = prototype.Clone();
            Console.WriteLine(clone.Id + " " + clone.Name + " " + clone.Color);
        }
    }
}
