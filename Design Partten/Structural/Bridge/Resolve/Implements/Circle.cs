using Resolve.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resolve.Implements
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Circle ");
            _color.Draw();
        }
    }
}
