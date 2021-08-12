using AbstractFactory.Intefaces;
using System;

namespace AbstractFactory.Implements
{
    class PlasticChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("this is plastic chair");
        }
    }
}
