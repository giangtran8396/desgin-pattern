using AbstractFactory.Intefaces;
using System;

namespace AbstractFactory.Implements
{
    class PlasticTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("this is plastic table");
        }
    }
}
