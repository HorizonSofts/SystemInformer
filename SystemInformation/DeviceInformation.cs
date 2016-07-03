using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;

namespace SystemInformation
{
    class DeviceInformation
    {
        public string DeviceInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("\t\tDEVICE BASIC INFORMATION\n\n");
            stringBuilder.AppendFormat("Operating System {0}:\n\n", Environment.OSVersion);
            if (Environment.Is64BitOperatingSystem)
            {
                stringBuilder.AppendFormat("Operating System is 64Bit\n\n");
            }
            else
            {
                stringBuilder.AppendFormat("Operating System is 32Bit\n\n");
            }
            stringBuilder.AppendFormat("PC-Name :{0}\n\n", Environment.MachineName);
            stringBuilder.AppendFormat("User Domain Name: {0}\n\n", Environment.UserDomainName);
            stringBuilder.AppendFormat("\t==========HardDisk Partition Details==========\n");
            foreach (DriveInfo driveinfo in DriveInfo.GetDrives())
            {
                stringBuilder.AppendFormat("Drive Name : {0}\nDrive Type : {1}\n\n", driveinfo.Name, driveinfo.DriveType);
            }
            stringBuilder.AppendFormat("=======================================================\n");
            stringBuilder.AppendFormat("System Page Size : {0}\n\n", Environment.SystemPageSize);
            stringBuilder.AppendFormat("Ticks Count : {0}\n", Environment.TickCount);
            return stringBuilder.ToString();
        }



        public string DeviceInformation1(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            ManagementClass ManagementClass1 = new ManagementClass(stringIn);
            ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
            PropertyDataCollection properties = ManagementClass1.Properties;
            foreach (ManagementObject obj in ManagemenobjCol)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {
                        StringBuilder1.AppendLine(property.Name + ":  " +
                          obj.Properties[property.Name].Value.ToString());
                    }
                    catch
                    {
                        //Add codes to manage more informations
                    }
                }
                StringBuilder1.AppendLine();
            }
            return StringBuilder1.ToString();
        }
    }
}
