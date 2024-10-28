using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Account
    {
        public string accountNumber;
        public string accountHolderName;
        
        private int accountBalance;
        public int AccountBalance
        {
            get { return accountBalance; }
            set
            {
                if (value >= 0)
                {
                    accountBalance = value;
                }
                else
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
            }
        }

        public Account(string AccountNumber, string AccountHolderName)
        {
            accountNumber = AccountNumber;
            accountHolderName = AccountHolderName;
            
        }

        public void Withdrawal(int amount)
        {
            if (amount < accountBalance && amount >= 0)
            {
            accountBalance -= amount;
                Console.WriteLine(amount + " withdrawn from " + accountNumber);
            }
            else if(amount < 0)
            {
                throw new ArgumentException("Enter a positive number to withdraw");
            }
            else
            {
                throw new ArgumentException("Insufficient Balance");
            }
        }

        public void Deposit(int amount)
        {
            accountBalance += amount;
            Console.WriteLine(amount + " deposited in " + accountNumber);
        }
    }

    public class Bank
    {
        public List<Account> accounts = new List<Account>();

        //create account
        public void CreateAccount(Account account)
        {
            accounts.Add(account);
            Console.WriteLine("Account Created: "+ account.accountNumber);
        }

        //delete account
        public void DeleteAccount(Account account)
        {
            accounts.Remove(account);
            Console.WriteLine(account.accountNumber + " Removed");
        }

        //show all accounts
        public void DisplayAccounts()
        {
            foreach(Account account in accounts)
            {
                Console.WriteLine("Account Number : "+ account.accountNumber+
                    " Account Holder Name : "+ account.accountHolderName + 
                    " Balance : " +account.AccountBalance);
            }
        }
    }


}
