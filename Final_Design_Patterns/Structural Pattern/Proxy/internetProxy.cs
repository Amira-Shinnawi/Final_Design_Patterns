using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Proxy
{
    class internetProxy : internetServiceProvider
    {
        List<string> blockedSite = new List<string>() {"Twitter","Facebook","Youtube"};
        public string ServeSite(string url)
        {
            
            if (blockedSite.Contains(url))
            {
                return url+" is blocked";
            }
            return new Zain().ServeSite(url);
        }
       
    }
}
