using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.Say();
            dog.Appect(new RunVisitor());
            IAnimal cat = new Cat();
            cat.Say();
            cat.Appect(new RunVisitor());
            Console.ReadLine();
        }
    }
}
