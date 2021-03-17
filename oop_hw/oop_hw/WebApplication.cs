using System;
using System.Collections.Generic;
using System.Text;

namespace oop_hw
{
    class WebApplication:Application
    {
        public override string SaveReceipt(int orderId)
        {
            return "Receipt for "+orderId.ToString()+ " has been sent to email";
        }
    }
}
