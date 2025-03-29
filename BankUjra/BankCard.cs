using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUjra
{
    internal class BankCard : BankingService
    {
        double szamla;
        int kartyaSzam;
        public BankCard(Owner owner, double szamla, int kartyaSzam) : base(owner)
        {
            this.szamla = szamla;
            this.kartyaSzam = kartyaSzam;
        }

        public double Szamla { get => szamla;}
        public int KartyaSzam { get => kartyaSzam; }

        public bool Purchase(double osszeg)
        {
            if (szamla - osszeg >= 0)
            {
                szamla -= osszeg;
                return true;
            }
            return false;
        }
    }
}
