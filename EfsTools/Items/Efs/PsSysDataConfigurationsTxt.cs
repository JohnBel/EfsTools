using System;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/data/ps_sys_data_configurations.txt", false, 0x81B6)]
    [Attributes(9)]
    public sealed class PsSysDataConfigurationsTxt
    {
        [FieldCount(0)]
        private byte[] _values;

        public string[] Values
        {
            get => StringUtils.GetStringLines(_values, LineEnding.Linux);
            set => _values = StringUtils.GetBytes(value, LineEnding.Linux);
        }
    }
}