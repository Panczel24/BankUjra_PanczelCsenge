using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
	internal class CreditAccount : BankAccounts
	{
		//azért kell publikus adattag, mert a privat változATA CSAK gettel, nem settel

		double creditlimit;
		public double CreditLimit { get =>creditlimit;}
		public CreditAccount(Owner owner, double creditlimit) : base(owner) //a base a bankaccountban lévő construktor
		//azért nem kell a kreditlimitet átadni a base-be, mert ...
		{
			this.creditlimit = creditlimit;
		}

		public override bool Withdraw(double amount)
		{
			if (Balance - amount >= creditlimit)
			{
				Balance -= amount;
				return true;
			}
			return false;
		}
	}
}
