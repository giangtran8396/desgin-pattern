using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var plasticFactory = FurnitureFactory.getFactory(EnumFactory.Plastic);
            var plastictable =  plasticFactory.CreateTable();
            plastictable.Create();
            var plasticchair = plasticFactory.CreateChair();
            plasticchair.Create();

            var woodFactory = FurnitureFactory.getFactory(EnumFactory.Wood);
            var woodtable = woodFactory.CreateTable();
            woodtable.Create();
            var woodchair = woodFactory.CreateChair();
            woodchair.Create();
            Console.ReadLine();
        }
    }
}
