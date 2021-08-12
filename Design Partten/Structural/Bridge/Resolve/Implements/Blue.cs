using Resolve.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resolve.Implements
{
    public class Blue : IColor
    {
        public void Draw()
        {
            Console.WriteLine("Drawing blue color");
        }
    }
}
