using AbstractFactory.AbstractFactories;
using AbstractFactory.Implements;
using AbstractFactory.Intefaces;

namespace AbstractFactory.Factories
{
    class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new WoodChair();
        }

        public override ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}
