using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Bank2
    {
        public string bankName;
        public List<Customer> customers = new List<Customer>();

        public Bank2(string Name)
        {
            bankName = Name;
        }

        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));

        }

        public void AddAccount(string customerName, string accountNumber, int initialBalance)
        {
            Customer customer = customers.Find(c => c.name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, initialBalance);
                Console.WriteLine($"Account {accountNumber} is added to the customer: {customerName}");

            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }


        //display customer details
        public void DisplayAllCustomers()
        {
            foreach (Customer item in customers)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Customer Name: {item.name}");
                item.DisplayAccounts();
            }
        }

        public void DisplayCustomer(string customerName)
        {
            Customer result = customers.Find(c => c.name == customerName);
            Console.WriteLine("-----------------------");
            Console.WriteLine(result.name);
            result.DisplayAccounts();

        }

       

        public class Customer
        {
            public string name;
            public List<Accounts> accounts = new List<Accounts>();

            public Customer(string Name)
            {
                name = Name;
                
            }

            public void AddAccount(string accountNumber, int initialBalance)
            {
                
                accounts.Add(new Accounts(accountNumber, initialBalance));                
            }

            public void DisplayAccounts()
            {
                foreach(Accounts account in accounts)
                {
                    Console.WriteLine($"Account Number: {account.accountNumber}  Balance: {account.Balance}");
                }
            }


            public class Accounts
            {
                public string accountNumber;
                private int balance;
                public int Balance { get { return balance; }
                    set
                    {
                        if(value >= 0)
                        {
                            balance = value;
                        }
                        else
                        {
                            throw new ArgumentException("Balance cannot be negative");
                        }
                    }
                }

                public Accounts(string AccountNumber, int initialBalance)
                {
                    accountNumber = AccountNumber;
                    Balance = initialBalance;
                }

                
            }
        }
    }
}
