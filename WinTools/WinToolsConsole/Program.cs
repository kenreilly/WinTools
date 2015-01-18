using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinToolsClientService;

namespace WinToolsConsole
{
    
    class Program
    {
        static List<string> ConsoleBuffer = new List<String>();

        static void Main(string[] args)
        {
            Console.Write(Environment.NewLine, Environment.NewLine);
            Console.WriteLine("WinTools CLI");

            Console.Write(Environment.NewLine);
            Console.WriteLine("Asset Tag: " + Core.AssetTag);

            Console.Write(Environment.NewLine);


        }



        static void WriteLines(List<string> consoleBuffer)
        {
            foreach (string line in consoleBuffer)
            {
                Console.WriteLine(consoleBuffer);
            }

            consoleBuffer.Clear();
        }
    }
}
