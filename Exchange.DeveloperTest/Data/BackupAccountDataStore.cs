using ClearBank.DeveloperTest.Data;
using Exchange.DeveloperTest.Types;

namespace Exchange.DeveloperTest.Data
{
    public class BackupAccountDataStore : IAccountDataStore
    {
        public override string DataStoreType => "Backup";
        public override Account GetAccount(string accountNumber)
        {
            // Access backup data base to retrieve account, code removed for brevity 
            return new Account();
        }

        public override void UpdateAccount(Account account)
        {
            // Update account in backup database, code removed for brevity
        }
    }
}
