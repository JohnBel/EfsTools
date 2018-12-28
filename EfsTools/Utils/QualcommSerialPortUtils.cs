using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using Microsoft.Win32;

namespace EfsTools.Utils
{
    internal static class QualcommSerialPortUtils
    {
        public static bool IsQualcommPort(string port)
        {
            InitializeQualcommPorts();
            return _qualcommPorts.Contains(port);
        }      
        
        private static HashSet<string> _qualcommPorts;

        private static void InitializeQualcommPorts()
        {
            try
            {
                if (_qualcommPorts == null)
                {
                    _qualcommPorts = new HashSet<string>();
                    using (var portsKey =
                        Registry.LocalMachine.OpenSubKey(
                            "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e978-e325-11ce-bfc1-08002be10318}", false))
                    {
                        if (portsKey != null)
                        {
                            foreach (var keyName in portsKey.GetSubKeyNames())
                            {
                                if (keyName != "Properties")
                                {
                                    ProcessRegistryKey(portsKey, keyName);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                if (_qualcommPorts == null)
                {
                    _qualcommPorts = new HashSet<string>();
                }
            }
        }

        private static void ProcessRegistryKey(RegistryKey portsKey, string keyName)
        {
            try
            {
                using (var portKey = portsKey.OpenSubKey(keyName, false))
                {
                    if (portKey != null)
                    {
                        var assignedPortForQcDevice =
                            portKey.GetValue("AssignedPortForQCDevice", string.Empty).ToString();
                        if (!string.IsNullOrEmpty(assignedPortForQcDevice))
                        {
                            _qualcommPorts.Add(assignedPortForQcDevice);
                        }
                    }
                    // "Qualcomm HS-USB"
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}