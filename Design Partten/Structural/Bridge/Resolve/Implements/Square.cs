using Resolve.Abstract;
using System;

namespace Resolve.Implements
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Square ");
            _color.Draw();
        }
    }
}
