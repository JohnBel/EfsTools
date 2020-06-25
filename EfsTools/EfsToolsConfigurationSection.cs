using Microsoft.Extensions.Configuration;

namespace EfsTools
{
    internal class EfsToolsConfigurationSection
    {
        private readonly IConfigurationSection _configurationSection;

        public EfsToolsConfigurationSection(IConfigurationRoot configurationRoot)
        {
            _configurationSection = configurationRoot == null ? null : configurationRoot.GetSection("efstool");
        }

        public string Port
        {
            get => GetValue("port", "Auto");
            set => SetValue("port", value);
        }

        public int Baudrate
        {
            get => int.Parse(GetValue("baudrate", "38400"));
            set => SetValue("baudrate", $"{value}");
        }

        public string Password
        {
            get => GetValue("password", "00000000");
            set => SetValue("password", value);
        }

        public string Spc
        {
            get => GetValue("spc", "000000");
            set => SetValue("spc", value);
        }

        private string GetValue(string name, string defaultValue)
        {
            if (_configurationSection != null)
            {
                var val = _configurationSection.GetSection(name);
                if (val != null)
                {
                    return val.Value;
                }
            }

            return defaultValue;
        }

        private void SetValue(string name, string value)
        {
            if (_configurationSection != null)
            {
                var val = _configurationSection.GetSection(name);
                if (val != null)
                {
                    val.Value = value;
                }
            }
        }
    }
}