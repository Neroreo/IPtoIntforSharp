using System;
using System.Net;

namespace IPtoInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "255.255.255.234";
            IPAddress ipAddr = IPAddress.Parse(address);

            var ipuint32 = BitConverter.ToUInt32(IPAddress.Parse(address).GetAddressBytes(), 0);

            Console.WriteLine(ipuint32);

            Console.ReadLine();
        }
    }
}
