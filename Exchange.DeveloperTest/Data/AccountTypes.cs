using Exchange.DeveloperTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.Data
{
    class AccountDataStores
    {
        public static List<IAccountDataStore> Get()
        {
            List<IAccountDataStore> types = new List<IAccountDataStore>
            {
                new AccountDataStore(),
                new BackupAccountDataStore()
            };

            return types;
        }
    }
}
