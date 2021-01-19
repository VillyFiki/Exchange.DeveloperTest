using ClearBank.DeveloperTest.Data;
using Exchange.DeveloperTest.Data;
using Exchange.DeveloperTest.Types;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;

namespace Exchange.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        private Account account;
        private List<IAccountDataStore> accountDataStores;
        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            var result = new MakePaymentResult();
            result.Success = false;

            accountDataStores = AccountDataStores.Get();
            var accountDataStore = accountDataStores.FirstOrDefault(x => x.CheckAccountType(ConfigurationManager.AppSettings["DataStoreType"]));

            if (accountDataStore == null)
                return result; 

            account = accountDataStore.GetAccount(request.DebtorAccountNumber);

            if (account == null)
                return result;

            if (account.CheckAbilityToPay(request.PaymentScheme))
            {
                if (account.Decrease(request.Amount)) 
                {
                    result.Success = true;
                    accountDataStore.UpdateAccount(account);
                }
            }
            
            return result;
        }
    }
}
