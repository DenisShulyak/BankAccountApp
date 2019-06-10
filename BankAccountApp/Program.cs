using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {


            /*var threads = new Thread[20];
            BankAccount bankAccount = new BankAccount();
            for (int i = 0; i < threads.Length; i++)
            {
                var thread = new Thread(bankAccount.WithdrawalAndAccrual);
                thread.Name = $"Поток номер {thread.ManagedThreadId}";
                threads[i] = thread;
            }

          
            for(int i = 0; i < threads.Length;i++)
            {
                threads[i].Start();
            }
            */
        BankAccount bankAccount = new BankAccount();
            var timeMinute = DateTime.Now.Minute + 1;
            var timeSecond = DateTime.Now.Second;
           

            while (DateTime.Now.TimeOfDay.Minutes != timeMinute || DateTime.Now.Second != timeSecond)
            {
            var thread = new Thread(bankAccount.WithdrawalAndAccrual);
            thread.Name = $"Поток номер {thread.ManagedThreadId}";
            thread.Start();
            }

            Console.WriteLine(1);
            Console.ReadLine();
            
        }
            
  


        /*
         var threads = new Thread[20];
            var printer = new Printer();
            for(int i = 0;i < threads.Length;i++)
            {
                var thread = new Thread(printer.Print);
                thread.Name = $"Поток номер {thread.ManagedThreadId}";
                threads[i] = thread;
            }

            foreach(var thread in threads)
            {
                thread.Start();
            }

            Console.ReadLine();
            */
    }
}
