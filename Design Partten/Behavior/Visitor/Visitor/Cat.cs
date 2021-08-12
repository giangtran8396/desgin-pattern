using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Cat : IAnimal
    {
        public void Appect(IVisitor v)
        {
            ((ICatVisitor)v).Visit(this);
        }

        public void Say()
        {
            Console.WriteLine("Cat Cat");
        }
    }
}
