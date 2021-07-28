using System;
using System.Diagnostics;

namespace Box_Unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            // Boxing
            int i = 4356;
            object ob = i;
            
            sw.Stop();
            Console.WriteLine($"Операция заняла {sw.Elapsed} ms");
            sw.Start();
            //unboxing

            int j = (int)ob;
            sw.Stop();
            Console.WriteLine($"Операция заняла {sw.Elapsed} ms");

        }
    }
}
