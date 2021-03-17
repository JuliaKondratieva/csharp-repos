using System;
using System.Collections.Generic;
using System.Text;

namespace oop_hw
{
    class DesktopApplication:Application
    {
        public virtual string OSCompatibility()
        {
            return "Unknown";
        }
        public override string SaveReceipt(int orderId)
        {
            return "Receipt for " + orderId.ToString() + " has been downloaded to your " +OSCompatibility()+ " computer";
        }
    }
}
