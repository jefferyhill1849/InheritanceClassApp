//Jeffery Hill
//Inheritance Lab 
//Oct. 17, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassApp
{
    public class Account
    {
        private string customerName;
        private decimal activity;
        protected int accountNumber;
        protected DateTime acctOpen;
        protected decimal acctBalance;
        string openAccount;

        //Constructors
        public Account()
        {
            acctOpen = DateTime.Now;
        }
        // I am chaining to refer back to the previous constructor.
        public Account(string name, int number, decimal balance) 
        {
            CustomerName = name;
            acctOpen = DateTime.Now;
        }
        // Properties
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value;}
        }
        // Read Only Properties
        public int AccountNumber
        {
            get { return accountNumber; }
        }
       
        public DateTime AcctOpen
        {
            get { return acctOpen; }
        }
        public decimal AcctBalance
        {
            get { return acctBalance; }
        }
        //Operation Methods
        public virtual string OpenAccount()
        {
            //HouseKeeping when a new account is opened.
            return openAccount;
        }
        public override string ToString()
        {
            return  "Customer Name: " + CustomerName
                        + "\nAccount Number:" + AccountNumber
                        + "\nAccount Balance" + AcctBalance;
        }
    }
}
