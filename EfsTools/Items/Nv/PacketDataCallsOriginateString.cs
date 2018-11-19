using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(298)]
    [Attributes(9)]
    public class PacketDataCallsOriginateString
    {
        public PacketDataCallsOriginateString()
        {
            Digits = new byte[16];
        }
        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte NumDigits { get; set; }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Digits { get; set; }

        public string DigitsString
        {
            get => StringUtils.GetString(Digits);
            set
            {
                if (value != null)
                {
                    Digits = StringUtils.GetBytes(value, 16);
                    NumDigits = (byte) Math.Min(value.Length, 16);
                }
            }
        }
    }
}