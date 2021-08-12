using Facade.Facade;
using System;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => ShopFacade.getInstance().buyProductByCashWithFreeShipping("contact@gpcoder.com"),
                () => ShopFacade.getInstance().buyProductByPaypalWithStandardShipping("gpcodervn@gmail.com", "0988.999.999")
                );
            //ShopFacade.getInstance().buyProductByCashWithFreeShipping("contact@gpcoder.com");
            //ShopFacade.getInstance().buyProductByPaypalWithStandardShipping("gpcodervn@gmail.com", "0988.999.999");
            Console.ReadLine();
        }
    }
}
