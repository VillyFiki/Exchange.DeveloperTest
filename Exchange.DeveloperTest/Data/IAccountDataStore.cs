using Exchange.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.Data
{
    public abstract class IAccountDataStore
    {
        public abstract string DataStoreType { get;}
        public abstract Account GetAccount(string accountNumber);

        public abstract void UpdateAccount(Account account);
        public bool CheckAccountType(string type) 
        {
            if (type == DataStoreType)
            {
                return true;
            }
            return false;
        }
    }
}
