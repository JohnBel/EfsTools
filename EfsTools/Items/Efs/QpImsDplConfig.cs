using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum RuimImsiValues : byte
    {
        None = 0,
        ImsiT = 1,
        ImsiM = 2
    }

    public enum ImsParamSrcValues : byte
    {
        FileRead = 0,
        NvRead = 1,
        CardRead = 2,
        FileReadAuthEnabled = 3,
        UsimFallbackModeEnabled = 4,
        UsimOnlyModeEnabled = 5
    }
    
    [Serializable]
    [NvItemId(67261)]
    [EfsFile("/nv/item_files/ims/qp_ims_dpl_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsDplConfig
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort PtimeValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort IsIpv6PrivateAddrEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte E911Ipv6Enabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Ipv6Enabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort MsRpPktSz { get; set; }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RuimImsiValue { get; set; }

        public string RuimImsiValueString
        {
            get => $"{(RuimImsiValues) RuimImsiValue}";
            set => RuimImsiValue = EnumUtils.ParseEnumByte(typeof(RuimImsiValues), value);
        }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint DscpValue { get; set; }

        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ImsParamSrc { get; set; }

        public string ImsParamSrcString
        {
            get => $"{(ImsParamSrcValues) ImsParamSrc}";
            set => ImsParamSrc = EnumUtils.ParseEnumByte(typeof(ImsParamSrcValues), value);
        }
    }
}