using Decorator.Component;
using Decorator.ConcreteDecorator;
using Decorator.Extensions;
using Decorator.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonAn comsuon = new ComSuon();
            Console.WriteLine("Com Suon :" + comsuon.Tinhtien());

            IMonAn Moncuoi = comsuon.Them(new ThemCha());
            Console.WriteLine("com suon cha :" + Moncuoi.Tinhtien());


            Moncuoi.Them(new ThemTrung());
            Console.WriteLine("com suon cha trung:" + Moncuoi.Tinhtien());

            Moncuoi.Them(new ThemRau());
            Console.WriteLine("com suon cha trung rau:" + Moncuoi.Tinhtien());

            Console.ReadLine();
        }
    }
}
