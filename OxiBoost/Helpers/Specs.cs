using Microsoft.Win32;
using System;
using System.Management;
using System.Text;

namespace Oxiboost.Helpers
{
    class Specs
    {
        public int gpuMem()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController");
            var ram_double = 0.0;
            foreach (ManagementObject mo in searcher.Get())
            {
                var ram = mo.Properties["AdapterRAM"].Value;
                ram_double = Convert.ToDouble(ram) / 1048576;
            }
            return Convert.ToInt32(ram_double);
        }

        public int coreCount()
        {
            var cores = Environment.ProcessorCount;
            return cores;
        }

        public int memCalc()
        {
            StringBuilder sb = new StringBuilder();
            ManagementObjectSearcher searcherz = new ManagementObjectSearcher("root\\CIMV2", "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcherz.Get())
            {
                double dblMemory;
                if (double.TryParse(Convert.ToString(queryObj["TotalPhysicalMemory"]), out dblMemory))
                {
                    var ram = Convert.ToInt32(dblMemory / (1024 * 1024 * 1024));
                    sb.AppendLine(ram.ToString());
                }
            }

            var mem_string = sb.ToString();
            var mem_num = Convert.ToInt32(mem_string);
            var calc_mem = (mem_num * 1024) / 4;

            return calc_mem;
        }

        public string compInfo()
        {
            StringBuilder sb = new StringBuilder();
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    string cpuName = processor_name.GetValue("ProcessorNameString").ToString();
                    sb.AppendLine("Processor: " + cpuName);
                }
            }


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        sb.AppendLine("Graphics Card: " + graphicsCard);
                    }
                }
            }
            ManagementObjectSearcher searcherz = new ManagementObjectSearcher("root\\CIMV2", "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcherz.Get())
            {
                double dblMemory;
                if (double.TryParse(Convert.ToString(queryObj["TotalPhysicalMemory"]), out dblMemory))
                {
                    var ram = "Installed Memory (Ram): " + Convert.ToInt32(dblMemory / (1024 * 1024 * 1024)) + " GB";
                    sb.AppendLine(ram.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
