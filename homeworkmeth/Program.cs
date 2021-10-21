using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmeth
{
    enum AccountType { Current, Savings }
    class Account
    {
        private static int TotalAccountCountInBank = 0;
        public Account(double balans, AccountType type)
        {
            Balans = balans;
            Type = type;
        }
        private readonly int currentAccountNumber;
        public Account()
        {
            TotalAccountCountInBank += 1;
            currentAccountNumber = TotalAccountCountInBank;
        }
        private double Balans { get { return Balans; } set { Balans = value; } }
        private AccountType Type { get { return Type; } set { Type = value; } }
        public override string ToString()
        {
            return base.ToString();
        }
        public void WithdrawFromTheAccount(double summa)
        {
            if (summa <= Balans)
            {
                double Nomoney = Balans - summa;
                Console.WriteLine(Nomoney);
            }
            else { Console.WriteLine("So there is no money, we are crying"); }
        }
    }
    class Program
    {
        static void Main()
        {
            AccountType accounttype = AccountType.Current;
            double summa = Convert.ToDouble(Console.ReadLine());
            Account bank = new Account( 140_000, AccountType.Savings);
            Console.WriteLine("{0} {1}", accounttype, bank);
        }
    }
}
