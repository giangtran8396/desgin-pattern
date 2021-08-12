using Resolve.Abstract;
using Resolve.Implements;
using System;

namespace Resolve
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape hinhtron = new Circle(new Red());
            hinhtron.Draw();
            Shape hinhvuong = new Square(new Blue());
            hinhvuong.Draw();
            Console.ReadLine();
        }
    }
}
