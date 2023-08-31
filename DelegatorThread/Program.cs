using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatorThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(DoSomething);
            Thread threadB = new Thread(delegate () 
            { 
                for(int i=0; i<1000; i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        public static void DoSomething()
        {
            for (int i=0; i<1000; i++)
            {
                Console.Write("A");
            }
        }
    }
}
