using System;
using System.Configuration;

namespace EfsTools
{
    class EfsToolsConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("port", DefaultValue = "COM2", IsKey = true, IsRequired = true)]
        public string Port
        {
            get { return (string) (base["port"]); }
            set { base["port"] = value; }
        }

        [ConfigurationProperty("baudrate", DefaultValue = 38400, IsKey = true, IsRequired = true)]
        public int Baudrate
        {
            get { return (int) (base["baudrate"]); }
            set { base["baudrate"] = value; }
        }

        [ConfigurationProperty("password", DefaultValue = "00000000", IsKey = false, IsRequired = true)]
        public string Password
        {
            get { return ((string) (base["password"])); }
            set { base["password"] = value; }
        }

        [ConfigurationProperty("spc", DefaultValue = "000000", IsKey = false, IsRequired = true)]
        public string Spc
        {
            get { return ((string)(base["spc"])); }
            set { base["spc"] = value; }
        }
    }
}