using FactoryMethod.Factories;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IBank VietcomBank = BankFactory.getBank(BankEnum.AgriBank);
            VietcomBank.getNameBank();
            Console.ReadLine();
        }
    }
}
