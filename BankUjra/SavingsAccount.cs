using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
	internal class SavingsAccount : BankAccounts
	{
		//a static mező arrra jó, hogy ha tudjuk hogy annak fix értéke lesz, és soha nem változtatjuk meg

		static double baseInerest = 0.1;
		public double interest {  get; set; }

		public SavingsAccount(Owner owner) : base(owner)
		{
			interest = baseInerest;
		}

		public override bool Withdraw(double amount)
		{
			if(Balance - amount >= 0)
			{
				Balance -= amount;
				return true;
			}return false;
		}

		public void addInterest()
		{
			Balance += Balance * interest;
            Console.WriteLine("ennyi pénzed lett a kamattal együtt: "+ Balance );
		}
	}
}
