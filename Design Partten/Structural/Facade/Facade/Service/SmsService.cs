using System;

namespace Facade.Service
{
    public class SmsService
    {
        public void sendSMS(String mobilePhone)
        {
            Console.WriteLine("Sending an mesage to " + mobilePhone);
        }
    }
}
