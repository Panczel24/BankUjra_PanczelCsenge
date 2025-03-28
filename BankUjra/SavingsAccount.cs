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

		public SavingsAccount(Owner owner) : base(owner)
		{
		}

		public override bool Withdraw(double amount)
		{
			throw new NotImplementedException();
		}
	}
}
