using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            

            

            Console.WriteLine("Welcome to Bank of TrueCoders!  What can we help you with today?");

            Found:
            Console.WriteLine("Please enter 1 for Deposits, 2 for withdrawals, 3 for your current balance, 4 to exit your account: ");
            int mode = Convert.ToInt32(Console.ReadLine());

            if (mode == 1)
            {
                Console.WriteLine("How much would you like to deposit today?");                
                double deposit = Convert.ToDouble(Console.ReadLine());
                account1.Deposit(+deposit);
                Console.WriteLine($"Ok we will deposit ${deposit} into your account");
                goto Found;
            }
            else if (mode == 2) 
            {
                Console.WriteLine("How much would you like to withdrawal today?");
                double withdrawal = Convert.ToDouble(Console.ReadLine());
                account1.Withdrawal(-withdrawal);
                Console.WriteLine($"Ok we will withdrawal ${withdrawal} from your account");
                goto Found;
            }
            else if (mode == 3) 
            {   double balance = account1.GetBalance();                
                Console.WriteLine($"Your current balance is ${balance}.");
                
                goto Found;
            }
            else 
            {
                Console.WriteLine("Have a great day!");
                Console.ReadLine();
                Environment.Exit(0); ;
            }

            


            
            
        }
    }
}
