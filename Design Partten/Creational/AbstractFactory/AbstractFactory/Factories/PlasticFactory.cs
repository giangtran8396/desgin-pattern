using AbstractFactory.AbstractFactories;
using AbstractFactory.Implements;
using AbstractFactory.Intefaces;

namespace AbstractFactory.Factories
{
    public class PlasticFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new PlasticChair();
        }

        public override ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}
