using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
                BankAccount customer1 = new BankAccount("John" ,500, 21);
            
            try
            {
                customer1.Withdraw(2000);
            }

            catch (NotSufficentAmountException ex )
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(customer1);
            Console.Read();
        }
    }
}
