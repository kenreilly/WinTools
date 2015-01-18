using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinToolsClientService
{
	public static class Core
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

        private static string _assetTag = String.Empty;
		public static string AssetTag
		{
            get {
                if (_assetTag != String.Empty) {
                    return _assetTag;
                }

                string cpuInfo = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }

                _assetTag = cpuInfo;

                return _assetTag;
            }
		}
	}
}
