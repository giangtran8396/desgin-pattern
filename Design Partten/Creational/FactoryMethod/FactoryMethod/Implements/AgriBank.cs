using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.Implements
{
    public class AgriBank : IBank
    {
        public void getNameBank()
        {
            Console.WriteLine("this is AgriBank");
        }
    }
}
