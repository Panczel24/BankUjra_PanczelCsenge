using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
	internal abstract class BankingService // az abstract azért kell, hogy ne lehessen közvetlenül példányosítani
	{
		Owner owner;
		public Owner Owner { get;} //csak azért get, mert nem szabad módosítani
		protected BankingService(Owner owner)
		{
			this.owner = owner;
		}
	}
}
