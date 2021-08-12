using AbstractFactory.Intefaces;

namespace AbstractFactory.AbstractFactories
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChair CreateChair();

        public abstract ITable CreateTable();
    }
}
