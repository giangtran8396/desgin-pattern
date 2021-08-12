using Resolve.Abstract;
using System;

namespace Resolve.Implements
{
    public class Red : IColor
    {
        public void Draw()
        {
            Console.WriteLine("Drawing red color");
        }
    }
}
