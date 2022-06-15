using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public static class Factory
    {
        public static BankAccount MakeAcct(BankAccountType acctType, int acctNum, int routing, double balance)
        {
            return new BankAccount(acctType, acctNum, routing, balance);
        }
    }
}
