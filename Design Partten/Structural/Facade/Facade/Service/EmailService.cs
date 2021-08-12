using System;

namespace Facade.Service
{
    public class EmailService
    {
        public void sendMail(String mailTo)
        {
            Console.WriteLine("Sending an email to " + mailTo);
        }
    }
}
