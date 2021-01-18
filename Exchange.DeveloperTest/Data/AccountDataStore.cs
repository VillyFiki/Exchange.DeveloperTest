using ClearBank.DeveloperTest.Data;
using Exchange.DeveloperTest.Types;

namespace Exchange.DeveloperTest.Data
{
    public class AccountDataStore : IAccountDataStore
    {
        public override string DataStoreType => "ping";
        public override Account GetAccount(string accountNumber)
        {
            // Access database to retrieve account, code removed for brevity 
            return new Account();
        }

        public override void UpdateAccount(Account account)
        {
            // Update account in database, code removed for brevity
        }
    }
}
