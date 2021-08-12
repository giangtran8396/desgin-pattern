using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Dog : IAnimal
    {
        public void Appect(IVisitor v)
        {
            ((IDogVisitor)v).Visit(this);
        }

        public void Say()
        {
            Console.WriteLine("Dog Dog");
        }
    }
}
