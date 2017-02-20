using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace P3D.Legacy.Launcher
{
    internal class WebsiteChecker
    {
        private string Host { get; }
        private bool WebsiteIsUp { get; set; }
        private DateTime LastCheck { get; set; }

        public WebsiteChecker(string host)
        {
            Host = host;
            NetworkChange.NetworkAddressChanged += (s, e) => Check(5000, true);
        }

        public bool Check(int timeout = 2000, bool force = false)
        {
            if (!force && DateTime.UtcNow - LastCheck > TimeSpan.FromSeconds(30))
            {
                LastCheck = DateTime.UtcNow;
                try { return WebsiteIsUp = new TcpClient().ConnectAsync(Host, 80).Wait(timeout); }
                catch (SocketException) { return WebsiteIsUp = false; }
            }
            else
                return WebsiteIsUp;
        }
    }
}