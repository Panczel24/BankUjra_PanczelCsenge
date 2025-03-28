using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
	internal sealed class Owner //azért kell a sealed, mert ez egy banki alkalmazás, és hogy biztonságos legyen, hogy el legyen szigetelve minden osztálytól
	{
		//string Nev;
		public string Name { get; set; } 
	}
}
