using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface ICatVisitor
    {
        void Visit(Cat dog);
    }
}
