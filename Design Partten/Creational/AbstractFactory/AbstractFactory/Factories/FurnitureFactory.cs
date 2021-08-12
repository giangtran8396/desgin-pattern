using AbstractFactory.AbstractFactories;

namespace AbstractFactory.Factories
{
    public static class FurnitureFactory
    {
        public static FurnitureAbstractFactory getFactory(EnumFactory enumFactory)
        {
            FurnitureAbstractFactory furnitureAbstractFactory = null;
            switch (enumFactory)
            {
                case EnumFactory.Plastic:
                    furnitureAbstractFactory = new PlasticFactory();
                    break;
                case EnumFactory.Wood:
                    furnitureAbstractFactory = new WoodFactory();
                    break;
            }
            return furnitureAbstractFactory;
        }
    }
}
