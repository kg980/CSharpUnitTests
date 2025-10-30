using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyNetworkUtility.DNS;

/// <summary>
/// Dummy methods to simulate network ping functionality for unit testing purposes of varied return types. 
/// </summary>
/// 

namespace DummyNetworkUtility.Ping
{
    public class NetworkService
    {
        private readonly IDNS _dns;

        // bringing in an abstraction
        public NetworkService(IDNS dns )
        {
            _dns = dns;
        }

        public string SendPing()
        {
            var dnsSucessful = _dns.SendDNS();
            if (dnsSucessful)
            {
                return "Success: Ping client";
            }
            else
            {
                return "Failure: DNS failed";
            }
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


        public IEnumerable<Uri> GetRecentPingUris()
        {
            IEnumerable<Uri> uris = new []
            {
                new Uri("https://www.example1.com"),
                new Uri("https://www.example2.com"),
                new Uri("https://www.example3.com")
            };
            return uris;
        }

    }
}
