using AbstractFactory.Intefaces;
using System;

namespace AbstractFactory.Implements
{
    class WoodChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("this is wood chair");
        }
    }
}
