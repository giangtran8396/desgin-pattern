using Builder.Component;
using Builder.ConcreteDecorator;
using Builder.Core;
using Builder.Extensions;
using Builder.Interfaces;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonAn Moncuoi = new MonAnBuilder()
                .CreateComSuon()
                .Using(new ThemCha())
                .Using(new ThemRau())
                .Using(new ThemTrung())
                .Build();

            Console.WriteLine("Mon Cuoi :" + Moncuoi.Tinhtien());
            Console.ReadLine();
        }
    }
}
