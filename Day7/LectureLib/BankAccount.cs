using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    //
    // DATA: account #, routing #, balance, pin, type of account
    // BEHAVIOR: Withdraw(), Deposit(), Close(), Transfer()
    //
    public class BankAccount
    {
        #region Fields (data)
        //camelCasingNamingConvention
        // m_iAccountNumber, m_AccountNumber, _accountNumber

        //ACCESS MODIFIERS:
        //default: private if not specified
        //private: ONLY this class can see it
        //public: EVERYONE can see it
        //protected: my class and every class in my class hierarchy
        //
        private int _accountNumber = 123456789, _routingNumber = 987654321;
        private double _balance = 0;

        #endregion

        #region Properties
        //a FULL property. has a backing field (_accountNumber) that I created.
        public int AccountNumber
        {
            //ACCESSOR
            //same as writing: public int GetAccountNumber() {return _accountNumber;}
            get { return _accountNumber; }

            //MUTATOR
            //same as writing: public void SetAccountNumber(int value) {_accountNumber = value;}
            private set { 
                if(value > 0)
                    _accountNumber = value; 
            }
        }

        //an auto property. compiler will create the backing field for me
        public BankAccountType AccountType { get; private set; } = BankAccountType.Checking;
        #endregion

        #region Constructor
        //public BankAccount()//default construtor (no parameters)
        //{

        //}
        public BankAccount(BankAccountType acctType, int acctNum, int routing, double balance)
        {
            AccountType = acctType;
            AccountNumber = acctNum;
            _routingNumber = routing;
            _balance = balance;

            //balance = _balance;//BACKWARDS and WRONG!!
        }
        #endregion
    }
}
