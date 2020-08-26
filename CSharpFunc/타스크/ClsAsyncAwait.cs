using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFunc.타스크
{
    class ClsAsyncAwait
    {
        static async void TaskSleep()
        {
            Console.WriteLine("1: " + Thread.CurrentThread.ManagedThreadId + " : " + DateTime.Now.ToString());
            Thread.Sleep(1000);
            Console.WriteLine("2: " + Thread.CurrentThread.ManagedThreadId + " : " + DateTime.Now.ToString());
            await Task.Delay(1000);
            Console.WriteLine("3: " + Thread.CurrentThread.ManagedThreadId + " : " + DateTime.Now.ToString());   
        }

        static void Main(string[] args)
        {
            Task.Run(async delegate
            {
                TaskSleep();
                Console.WriteLine("4?? : " + DateTime.Now.ToString());
            });

            while (true)
                Thread.Sleep(5000);
        
        }
    }
}
