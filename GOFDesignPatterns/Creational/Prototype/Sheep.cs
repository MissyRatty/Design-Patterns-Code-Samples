using System;

namespace GOFDesignPatterns.Creational.Prototype
{
    public class Sheep : IAnimalPrototype
    {
        public string Name { get; set; }

        public Sheep(string name)
        {
            Console.WriteLine("Sheep is Made");
            Name = name;
        }

        public IAnimalPrototype MakeCopy()
        {
            Console.WriteLine("A Copy of Sheep is being made");

            return MemberwiseClone() as IAnimalPrototype;
        }
    }
}
