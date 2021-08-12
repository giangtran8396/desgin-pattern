using FactoryMethod.Implements;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public static class BankFactory
    {
        public static IBank getBank(BankEnum bankEnum)
        {
            IBank bank = null;
            switch (bankEnum)
            {
                case BankEnum.AgriBank:
                    bank = new AgriBank();
                    break;
                case BankEnum.EximBank:
                    bank = new EximBank();
                    break;
                case BankEnum.VietcomBank:
                    bank = new VietcomBank();
                    break;
            }
            return bank;
        }
    }
}
