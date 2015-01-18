using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinToolsClientService;

namespace WinToolsConsole1
{
    class Program
    {
        static void Main(string[] args)
        {

            WinToolsClientService.Service1 service = new WinToolsClientService.Service1();
            Console.WriteLine("WinTools CLI");
            Console.WriteLine(WinToolsClientService.Core.AssetTag);
        }
    }
}
