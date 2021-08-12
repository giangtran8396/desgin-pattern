using Facade.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Facade
{
    public sealed class ShopFacade
    {
        private static int counter = 0;
        private static ShopFacade INSTANCE;
        private static readonly object InstanceLock = new object();
        private readonly AccountService accountService;
        private readonly PaymentService paymentService;
        private readonly ShippingService shippingService;
        private readonly EmailService emailService;
        private readonly SmsService smsService;
        private ShopFacade()
        {
            counter++;
            Console.WriteLine("counter : " + counter);
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
            smsService = new SmsService();
        }

        public static ShopFacade getInstance()
        {
            if (INSTANCE == null)
            {
                lock (InstanceLock)
                {
                    if (INSTANCE == null)
                        INSTANCE = new ShopFacade();
                    return INSTANCE;
                }
            }
            return INSTANCE;
        }

        public void buyProductByCashWithFreeShipping(String email)
        {
            accountService.getAccount(email);
            paymentService.paymentByCash();
            shippingService.freeShipping();
            emailService.sendMail(email);
            Console.WriteLine("Done");
        }

        public void buyProductByPaypalWithStandardShipping(String email, String mobilePhone)
        {
            accountService.getAccount(email);
            paymentService.paymentByPaypal();
            shippingService.standardShipping();
            emailService.sendMail(email);
            smsService.sendSMS(mobilePhone);
            Console.WriteLine("Done");
        }
    }
}
