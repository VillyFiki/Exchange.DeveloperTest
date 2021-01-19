﻿using ClearBank.DeveloperTest.Data;
using Exchange.DeveloperTest.Types;

namespace Exchange.DeveloperTest.Data
{
    public class AccountDataStore : IAccountDataStore
    {
        public override string DataStoreType => null;
        public override Account GetAccount(string accountNumber)
        {
            // Access database to retrieve account, code removed for brevity 

            //Предположим, что это вывод из БД. В задаче не написано его делать. А чтобы проверить оно нужно. 
            return new Account
            {
                Balance = 5000,
                AccountNumber = "11111",
                Status = AccountStatus.Live,
                AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs

            };
        }

        public override void UpdateAccount(Account account)
        {
            // Update account in database, code removed for brevity
        }
    }
}
