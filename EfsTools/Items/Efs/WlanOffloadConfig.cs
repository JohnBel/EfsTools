using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/wlan_config/wlan_offload_config", true, 0xE1FF)]
    [Attributes(9)]
    public class WlanOffloadConfig
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(WlanOffloadConfigValue) Value}";
            set => Value = EnumUtils.ParseEnumByte(typeof(WlanOffloadConfigValue), value);
        }


    }
    public enum WlanOffloadConfigValue : byte
    {
        Disabled = 0,
        WLanLbOnly = 1,
        IWlanS2b = 2
    }
}