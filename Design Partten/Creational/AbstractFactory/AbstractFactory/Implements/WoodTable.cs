using AbstractFactory.Intefaces;
using System;

namespace AbstractFactory.Implements
{
    class WoodTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("this is wood table");
        }
    }
}
