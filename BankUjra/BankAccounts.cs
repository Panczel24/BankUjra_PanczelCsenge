using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
	internal abstract class BankAccounts : BankingService
	{
		double balance;
		public double Balance { get; protected set; }

		public BankAccounts(Owner owner) : base(owner)
		{
		}
		//azért kell külön metódus, hogy bármikor tudjunk hozzáadni balance-t
		public void Deposit(double amount)
		{
			balance += amount;
		}

		public abstract bool Withdraw(double amount); //azért abstract mert ha több osztály van és egy közös metódus kell, akkor az abstractot mindig kell majd implementálni
		

	}
}
