using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    public class BankAccount
    {
        public string accHolder;
        public int amount;
        public BankAccount(string accHolder, int amount)
        {
            this.accHolder = accHolder;
            this.amount = amount;
        }
    }
}
