﻿using System;

namespace Facade.Service
{
    public class AccountService
    {
        public void getAccount(String email)
        {
            Console.WriteLine("Getting the account of " + email);
        }
    }
}
