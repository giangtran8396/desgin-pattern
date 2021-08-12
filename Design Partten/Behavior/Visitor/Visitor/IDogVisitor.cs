using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IDogVisitor 
    {
        void Visit(Dog dog);
    }
}
