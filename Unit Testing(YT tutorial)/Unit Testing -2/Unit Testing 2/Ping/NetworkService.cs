using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_2.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            //SearchDNS();
            //BuildPacket();
            return "Success: Ping sent!";
        }

        public int PingTimeOut(int a,int b)
        {
            return a + b;
        }
    }
}
    