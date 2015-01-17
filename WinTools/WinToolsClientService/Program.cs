using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;

namespace WinToolsClientService
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
			ServiceBase.Run(ServicesToRun);
		}


		public static string getAssetTag()
		{
			string cpuInfo = string.Empty;
			ManagementClass mc = new ManagementClass("win32_processor");
			ManagementObjectCollection moc = mc.GetInstances();

			foreach (ManagementObject mo in moc)
			{
				cpuInfo = mo.Properties["processorID"].Value.ToString();
				break;
			}
			return string.Empty;
		}
	}
}
