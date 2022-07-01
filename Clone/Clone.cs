using System;
using System.Collections.Generic;
using System.Text;

namespace Clone
{
    abstract class Prototype
    {
        public int Id { get; private set; }
        public string Color { get; private set; }
        public string Name { get; private set; }

        public Prototype(int id, string color, string name)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id, string color, string name)
            : base(id, color, name)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id, Color, Name);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id, string color, string name)
            : base(id, color, name)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id, Color, Name);
        }
    }
}
