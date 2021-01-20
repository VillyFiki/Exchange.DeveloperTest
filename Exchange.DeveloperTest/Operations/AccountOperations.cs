using Exchange.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.Operations
{
    class AccountOperations
    {
        private Account Account { get; set; }
        private AccountOperations() { }
        public AccountOperations(Account account)
        {
            if (account != null)
            {
                Account = account;
            }

        }
    }
}
