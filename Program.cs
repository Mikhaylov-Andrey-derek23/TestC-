using System;
using System.Threading;

namespace lessson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name?");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Your name {name}");
            Console.WriteLine("Click Enter for exit");
            Console.Read();
            Thread.Sleep(10000);
            Console.WriteLine("By By By");
        }
    }
}
