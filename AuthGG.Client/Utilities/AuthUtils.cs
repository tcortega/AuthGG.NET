using System;
using System.Linq;
using System.Management;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace tcortega.AuthGG.Client.Utilities
{
    public class AuthUtils
    {
        internal static bool IsValidAuthData(string aid, string apiKey, string secret)
        {
            return !(string.IsNullOrEmpty(aid) || string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(secret)
                || !long.TryParse(aid, out _) || !BigInteger.TryParse(apiKey, out _) || secret.Length != 35);
        }

        public static string GetHWID()
        {
            // Retreving OS Info
            using var wmi = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
                .Get()
                .Cast<ManagementObject>()
                .First();

            var osVersion = wmi["Version"].ToString();
            var osSerialNumber = wmi["SerialNumber"].ToString();
            var osUser = wmi["RegisteredUser"].ToString();

            // Retrieving CPU Info
            var cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor")
                .Get()
                .Cast<ManagementObject>()
                .First();

            var cpuName = cpu["Name"].ToString();
            var cpuDesc = cpu["Caption"].ToString();
            var cpuSpeedMHz = cpu["MaxClockSpeed"].ToString();
            var cpuCores = cpu["NumberOfCores"].ToString();

            // Retrieving GPU Info

            var gpu = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController")
                .Get()
                .Cast<ManagementObject>()
                .First();

            var gpuName = gpu["Name"].ToString();
            var gpuDesc = gpu["Caption"].ToString();

            var mb = new ManagementObjectSearcher("SELECT * FROM Win32_MotherboardDevice")
                .Get()
                .Cast<ManagementObject>()
                .First();

            var mbName = mb["Name"].ToString();
            var mbDesc = mb["Caption"].ToString();

            var hwid = osVersion + osSerialNumber + osUser + cpuName + cpuDesc + cpuSpeedMHz + cpuCores + gpuName + gpuDesc + mbName + mbDesc;

            var hwidByteArr = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(hwid));
            return Convert.ToBase64String(hwidByteArr);
        }
    }
}
