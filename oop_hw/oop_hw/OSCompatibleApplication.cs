using System;
using System.Collections.Generic;
using System.Text;

namespace oop_hw
{
    class OSCompatibleApplication:DesktopApplication
    {
        public override string OSCompatibility()
        {
            return "Windows 64";
        }
    }
}
