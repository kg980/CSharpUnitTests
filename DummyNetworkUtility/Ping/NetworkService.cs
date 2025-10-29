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

        public DateTime LastPingDateTime()
        {
            return DateTime.Now;
        }

        // using a built in object for unit testing an object type
        public Uri GetPingUri()
        {
            var builder = new UriBuilder
            {
                Scheme = Uri.UriSchemeHttps,
                Host = "www.example.com"
            };

            return builder.Uri;
        }

    }
}
