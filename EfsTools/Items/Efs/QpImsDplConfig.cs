using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
    public sealed class QpImsDplConfig
    {
        public ushort PtimeValue { get; set; }


        public ushort IsIpv6PrivateAddrEnabled { get; set; }


        public byte E911Ipv6Enabled { get; set; }


        public byte Ipv6Enabled { get; set; }


        public ushort MsRpPktSz { get; set; }


        [JsonIgnore]
        public byte RuimImsiValue { get; set; }

        public string RuimImsiValueString
        {
            get => $"{(RuimImsiValues) RuimImsiValue}";
            set => RuimImsiValue = EnumUtils.ParseEnumByte(typeof(RuimImsiValues), value);
        }


        public uint DscpValue { get; set; }


        [JsonIgnore]
        public byte ImsParamSrc { get; set; }

        public string ImsParamSrcString
        {
            get => $"{(ImsParamSrcValues) ImsParamSrc}";
            set => ImsParamSrc = EnumUtils.ParseEnumByte(typeof(ImsParamSrcValues), value);
        }
    }
}