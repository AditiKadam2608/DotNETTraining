using System;
using System.Net;
using System.Net.Sockets;

class getip
{
    static void Main()
    {
        string hostName = Dns.GetHostName();
        Console.WriteLine("Host Name: " + hostName);

        IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

        foreach (IPAddress ipAddress in ipAddresses)
        {
            // Filter out IPv6 addresses if you are only interested in IPv4 addresses
            if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
            {
                Console.WriteLine("IP Address: " + ipAddress.ToString());
            }
        }
    }
}
