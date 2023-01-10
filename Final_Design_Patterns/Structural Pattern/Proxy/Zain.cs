using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Proxy
{
    class Zain : internetServiceProvider
    {
        private int browseSpeed=10;
        public string ServeSite(string url)
        {
            return string.Format(url+" is requested",url);
        }
        public int getBrowseSpeed()
        {
            return browseSpeed;
        }
    }
}
