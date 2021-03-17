using System;

namespace oop_hw
{
    class Program
    {
        
        static void work()
        {
            OSCompatibleApplication appW = new OSCompatibleApplication();
            appW.SaveReceipt(appW.SubmitOrder("julia"));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            work();
            Console.ReadLine();
        }
    }
}
