using ClearBank.DeveloperTest.Data;
using Exchange.DeveloperTest.Data;
using Exchange.DeveloperTest.Types;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Exchange.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        private Account account;
        private List<IAccountDataStore> accountDataStores;
        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            accountDataStores = AccountDataStores.Get();
            var accountDataStore = accountDataStores.FirstOrDefault(x => x.CheckAccountType(ConfigurationManager.AppSettings["DataStoreType"]));
            account = accountDataStore.GetAccount(request.DebtorAccountNumber);

            var result = new MakePaymentResult();

            result.Success = account.CheckAbilityToPay(request.PaymentScheme);

            if (result.Success)
            {
                if (account.Decrease(request.Amount)) 
                {
                    result.Success = false;
                    accountDataStore.UpdateAccount(account);
                }
            }
            
            return result;
        }
    }
}
