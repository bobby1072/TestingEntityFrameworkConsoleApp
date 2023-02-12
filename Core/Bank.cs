using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Bank
    {
        public static Account Deposit(Account user, float amount)
        {
            user.Balance += amount;
            return user;
        }
        public static Account Withdraw(Account user, float amount)
        {
            user.Balance -= amount;
            return user;
        }
    }
}
