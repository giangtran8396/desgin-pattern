using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class RunVisitor : IVisitor, ICatVisitor , IDogVisitor
    {
        public void Visit(Dog dog)
        {
            Console.WriteLine("Dog run");
        }

        public void Visit(Cat cat)
        {
            Console.WriteLine("Cat run");
        }
    }
}
