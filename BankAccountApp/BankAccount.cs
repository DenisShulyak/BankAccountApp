using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAccountApp
{
    [Synchronization]
    public class BankAccount  : ContextBoundObject
    {

        private int account = 500;
        private object lockObject = new object();
        public void WithdrawalAndAccrual()//Снятие и пополнение счета рандомным образом 
        {
           
                Random random = new Random();
                int randomNumber = random.Next(-1000, 1000);
               
                // DateTime.TimeOfDay time = DateTime.Now.TimeOfDay;

                if (randomNumber > 0)
                {
                    var currentThread = Thread.CurrentThread;
                    Console.WriteLine($"{currentThread.Name} начал свою работу");
                  
                    account += randomNumber;
                    Console.WriteLine($"На счет начисленно {randomNumber}. Текущий счет {account}. Начислел {currentThread.Name} поток");
                    Console.WriteLine($"{currentThread.Name} закончил свою работу");
                }
                else if (randomNumber < 0)
                {
                    var currentThread = Thread.CurrentThread;
                    Console.WriteLine($"{currentThread.Name} начал свою работу");
                  
                    account += randomNumber;
                    Console.WriteLine($"Со счета списано {-randomNumber}. Текущий счет {account}. Снял {currentThread.Name} поток");
                    Console.WriteLine($"{currentThread.Name} закончил свою работу");

                }
            
        }

    }
}
