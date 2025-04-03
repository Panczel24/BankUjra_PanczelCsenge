namespace BankUjra
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Owner owner = new Owner("Lili");
            Console.WriteLine(owner);

			Bank bank = new(10000);
            Console.WriteLine(bank);
                
            Owner owner2 = new Owner("John Doe");

            Console.WriteLine(bank.TotalCreditLimit());      
            
            //nem értem hogy kell, őszintén, teljesen el vagyok veszve ＞﹏＜    ( T﹏T )    o(TヘTo)
            
            
        }
    }
	
}
