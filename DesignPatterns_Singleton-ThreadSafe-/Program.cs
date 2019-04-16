using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns_Singleton_ThreadSafe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Singleton[] arr = { s1, s2};

            //s1.AddOneToCounter();
            //s1.AddOneToCounter();
            //s2.AddOneToCounter();
            //s1.AddOneToCounter();
            //s2.AddOneToCounter();
            //s1.AddOneToCounter();

            //Console.WriteLine(s1.GetCounter());
            //Console.WriteLine(s2.GetCounter());
            //Console.ReadKey();

            Parallel.ForEach(arr, (s) =>
            {
                for (int i = 0; i < 5; i++)
                {
                    s.AddOneToCounter();
                }
            });
            Console.WriteLine(s1.GetCounter());
            Console.WriteLine(s2.GetCounter());
            Console.ReadKey();
        }
    }
}
