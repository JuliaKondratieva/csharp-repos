using System;
using System.Collections.Generic;
using System.Text;

namespace oop_hw
{
    abstract class Application
    {
        private string authorizedCustomer;
        private Random rnd = new Random();

        public int SubmitOrder(string customer)
        {
            Console.WriteLine( "Order by " +customer+ " has been submitted");
            return rnd.Next(52);
        } 

        public virtual string SaveReceipt(int orderId)
        {
            return "Receipt of order " +orderId.ToString() + " has been saved";
        }
    }
}
