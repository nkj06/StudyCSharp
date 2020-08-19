using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace EddyHomePage.Helpers
{
    public class Commons
    {
        public static string GetIPAddress()
        {
            string strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addrs = ipEntry.AddressList;

            return addrs[1].ToString();
        }
    }
}