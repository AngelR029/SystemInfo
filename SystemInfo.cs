using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());
            Console.WriteLine("UserName: {0}", Environment.UserName);
            Console.WriteLine("The number of processors on this computer is {0}.", Environment.ProcessorCount);
            Console.WriteLine("Network name: {0}", Environment.UserDomainName);
            Console.ReadLine();
        }
    }
}
