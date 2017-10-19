//Jeffery Hill
// Inheritance Lab 2
//Oct. 18, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassApp
{
    public class Savings : Account
    {
        private decimal interest;
        private decimal depositAmt;
        private decimal depositBal;
        private decimal withdrawalBal;
        private decimal withdrawalAmt;
        private decimal quInterest;
        

        //Default constructor
        public Savings() : base()
        {

        }

        public Savings(string name, int number, decimal balance, decimal inter) : base(name, number, balance)
        {
            interest = inter;
        }

        public decimal Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public virtual decimal Deposit()
        {
            depositBal = depositAmt + acctBalance;

            return depositBal;
        }

        public virtual decimal Withdrawal()
        {
            withdrawalBal = withdrawalAmt + acctBalance;

            return withdrawalBal;
        }

        public virtual decimal QuartInterest()
        {
            return quInterest;
        }
    }
}
