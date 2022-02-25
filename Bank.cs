using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj1 = new BankAccount("Sanjay",1000);
            obj1.Deposit(500);
            obj1.Withdraw(400);
            Console.WriteLine("Total Ballance is = "+obj1.bal);
            Console.ReadLine();

        }
    }
    class BankAccount
    {
        string owner;
        int ballance;
        public BankAccount(string owner, int bal)
        {
            this.owner = owner;
            this.ballance = bal;
        }
        public void Deposit( int amount)
        {
            this.ballance += amount;
        }
        public void Withdraw(int amount)
        {
            this.ballance -= amount;
        }
        public int bal
        {
            get 
            { 
                return this.ballance; 
            }
        }
    }
}
