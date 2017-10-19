//Jeffery Hill
//Inheritance Lab 2
// Oct 18, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassApp
{
    public class Checking : Account
    {
        private decimal checkFee;
        private decimal depositBal;
        private decimal depositAmt;
        private decimal withdrawalAmt;
        private decimal withdrawalBal;
        private decimal monthlyFee;

        //Default Constructor
        public Checking() : base()
        {

        }

        public Checking(string name, int number, decimal balance, decimal fee) : base(name, number, balance)
        {
            CheckFee = fee;
        }

        public decimal CheckFee
        {
            get { return checkFee; }
            set { checkFee = value; }
        }

        public virtual decimal Deposit()
        {
            depositBal = acctBalance + depositAmt;

            return depositBal;
        }

        public virtual decimal Withdrawal()
        {
            withdrawalBal = withdrawalAmt + acctBalance;

            return withdrawalBal;
        }

        public virtual decimal MonthlyFee()
        {
            return monthlyFee;
        }
    }
}
