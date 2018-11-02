using System;
using System.ComponentModel;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum Lte3gppReleaseVerValue : byte
    {
        /*Rel8 versions*/
        Rel8 = 0x10,
        Rel8Dec08 = 0x11,
        Rel8Mar09 = 0x12,
        Rel8Jun09 = 0x13,
        Rel8Sep09 = 0x14,
        Rel8Dec09 = 0x15,
        Rel8Mar10 = 0x16,
        Rel8Jun10 = 0x17,
        Rel8Sep10 = 0x18,
        Rel8Dec10 = 0x19,
        /*Rel 9 versions*/
        Rel9 = 0x20,
        Rel9Mar10 = 0x21,
        Rel9Jun10 = 0x22,
        Rel9Sep10 = 0x23,
        /*Rel 10 versions*/
        Rel10Jun11 = 0x40, /*June 2011 release*/
        Rel10Sep11 = 0x41,
        Rel10Dec11 = 0x42,
        Rel10Mar12 = 0x43,
        Rel10Jun12 = 0x44,
        Rel10Sep12 = 0x45
    }
    
    [Serializable]
    [EfsFile("/nv/item_files/modem/lte/lte_3gpp_release_ver", true, 0xE1FF)]
    [Attributes(9)]
    public class Lte3gppReleaseVer
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }

        public string StringValue
        {
            get => $"{(Lte3gppReleaseVerValue) Value}";
            set => Value = (byte) Enum.Parse(typeof(Lte3gppReleaseVerValue), value);
        }
    }
}