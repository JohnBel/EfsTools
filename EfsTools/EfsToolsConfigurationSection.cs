using System.Configuration;

namespace EfsTools
{
    internal class EfsToolsConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("port", DefaultValue = "COM2", IsKey = true, IsRequired = true)]
        public string Port
        {
            get => (string) base["port"];
            set => base["port"] = value;
        }

        [ConfigurationProperty("baudrate", DefaultValue = 38400, IsKey = true, IsRequired = true)]
        public int Baudrate
        {
            get => (int) base["baudrate"];
            set => base["baudrate"] = value;
        }

        [ConfigurationProperty("password", DefaultValue = "00000000", IsKey = false, IsRequired = true)]
        public string Password
        {
            get => (string) base["password"];
            set => base["password"] = value;
        }

        [ConfigurationProperty("spc", DefaultValue = "000000", IsKey = false, IsRequired = true)]
        public string Spc
        {
            get => (string) base["spc"];
            set => base["spc"] = value;
        }
    }
}