using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IAnimal
    {
        void Say();
        //void Run(); cá thì không run được
        void Appect(IVisitor v);
    }
}
