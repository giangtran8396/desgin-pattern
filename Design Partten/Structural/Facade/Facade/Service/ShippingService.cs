using System;

namespace Facade.Service
{
    public class ShippingService
    {
        public void freeShipping()
        {
            Console.WriteLine("Free Shipping");
        }

        public void standardShipping()
        {
            Console.WriteLine("Standard Shipping");
        }

        public void expressShipping()
        {
            Console.WriteLine("Express Shipping");
        }
    }
}
