using System;
using System.ComponentModel;
using EfsTools.Attributes;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum EnableRegInLpmValues
    {
        Invalid = 0,
        Off = 1,
        On = 2
    }

    [Serializable]
    [NvItemId(70235)]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_extended_0_config", true, 0xE1B6)]
    [Attributes(9)]
    public class QpImsRegExtended0Config
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegConfigNetworkInitiatedDeRegTimer { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TDelay { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort EmerIpFallback { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigPdnRecoveryImmediateTimer { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegRetryBaseTime { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegRetryMaxTime { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte EnableRegInLpm { get; set; }

        public string EnableRegInLpmString
        {
            get => $"{(EnableRegInLpmValues) EnableRegInLpm}";
            set => EnableRegInLpm = (byte) Enum.Parse(typeof(EnableRegInLpmValues), value);
        }

        [ElementsCount(1011)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }

        /*[ElementsCount(1019)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field3 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field4 { get; set; }*/
    }
}