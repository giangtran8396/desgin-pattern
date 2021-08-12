
using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator
{
    public class ThemTrung : IMonAn
    {
        public ThemTrung()
        {
        }
        public float Tinhtien()
        {
            return 5000;
        }
    }
}
