using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.Implements
{
    public class EximBank : IBank
    {
        public void getNameBank()
        {
            Console.WriteLine("this is Eximbank");
        }
    }
}
