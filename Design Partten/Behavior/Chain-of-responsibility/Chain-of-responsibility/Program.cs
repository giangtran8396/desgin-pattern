using Chain_of_responsibility.Implements;
using System;

namespace Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey
                .SetNext(squirrel)
                .SetNext(dog);

            Console.WriteLine(monkey.Handle("MeatBall"));

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            //Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            //Client.ClientCode(monkey);
            //Console.WriteLine();

            //Console.WriteLine("Subchain: Squirrel > Dog\n");
            //Client.ClientCode(squirrel);
            Console.ReadLine();
        }
    }
}
