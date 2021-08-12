using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.Implements
{
    public class VietcomBank : IBank
    {
        public void getNameBank()
        {
            Console.WriteLine("this is Vietcombank");
        }
    }
}
