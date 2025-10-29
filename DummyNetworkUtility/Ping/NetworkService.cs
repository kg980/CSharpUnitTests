using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyNetworkUtility.Ping
{
    public class NetworkService
    {
        /// <summary>
        /// Dummy methods to simulate network ping functionality for unit testing purposes of varied return types. 
        /// </summary>

        public string SendPing()
        {
            return "Success: Ping client";
        }
    
        public int PingTimeout(int x, int y)
        {
            return x + y;
        }
        
    }
}
