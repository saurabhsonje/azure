using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
       static int id=1;
       static string name;
       static Account acc;

        static void Main(string[] args)
        {
            
            int amount,choice=0;
            while (choice!=5) {
                Console.WriteLine($"Please enter your choice :{name} 1.Create Account 2.Check Balance 3.Credit 4.Debit 5.Exit");
                 choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Enter your name");
                        name = Console.ReadLine();
                        acc = new Account(id,name, 0);
                        id++;
                        break;

                    case 2: acc.checkBalance();
                        break;

                    case 3: Console.WriteLine("Enter the amount to credit");
                        amount = Convert.ToInt16(Console.ReadLine());
                        acc.credit(amount);
                        break;

                    case 4: Console.WriteLine("Enter the amount to debit");
                        amount = Convert.ToInt16(Console.ReadLine());
                        acc.debit(amount);
                        break;

                }
            } 


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
           // Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}