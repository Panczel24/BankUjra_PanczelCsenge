using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
    internal class Bank
    {
        BankAccounts[] accounts;

        public Bank(int maxAcc)
        {
            accounts = new BankAccounts[maxAcc];
        }

        public BankAccounts NewAccount(Owner owner, double creditlimit)
        {
            if (creditlimit == 0)
            {
                return new SavingsAccount(owner);
            }
            else 
            { 
                return new CreditAccount(owner, creditlimit);
            }
        }

        double totalBalance(Owner owner)
        {
            double osszeg = 0;
            foreach (var account in accounts)
            {
                osszeg += account.Balance;
            }
            return osszeg;
        }

        public BankAccounts maximalBalanceAccount(Owner owner)
        {
            BankAccounts maxBankAccount = accounts[0];

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].Balance > maxBankAccount.Balance)
                {
                    maxBankAccount = accounts[i];
                }
            }
            return maxBankAccount;
        }

        public double TotalCreditLimit()
        {
            double osszeg = 0;
            foreach (var account in accounts)
            {
                if (account is CreditAccount)
                {
                    osszeg += (account as CreditAccount).CreditLimit;
                }
            }
            return osszeg;
        }
    }
}
