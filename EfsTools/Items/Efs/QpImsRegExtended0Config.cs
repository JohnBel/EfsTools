using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum EnableRegInLpmValues : byte
    {
        Invalid = 0,
        Off = 1,
        On = 2
    }

    [Serializable]
        [Subscription]
    [NvItemId(70235)]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_extended_0_config", true, 0xE1B6)]
    [Attributes(9)]
    public sealed class QpImsRegExtended0Config
    {
        [Required]
        public byte Version { get; set; }


        public ushort RegConfigNetworkInitiatedDeRegTimer { get; set; }


        public ushort TDelay { get; set; }


        public ushort EmerIpFallback { get; set; }


        public byte RegConfigPdnRecoveryImmediateTimer { get; set; }


        public ushort RegRetryBaseTime { get; set; }


        public ushort RegRetryMaxTime { get; set; }

        [JsonIgnore]
        public byte EnableRegInLpm { get; set; }

        public string EnableRegInLpmString
        {
            get => $"{(EnableRegInLpmValues) EnableRegInLpm}";
            set => EnableRegInLpm = EnumUtils.ParseEnumByte(typeof(EnableRegInLpmValues), value);
        }

        [FieldCount(1011)]
        public byte[] Reserved { get; set; }

        /*[FieldCount(1019)]
		public byte[] Field3 { get; set; }

        
        
        public ushort Field4 { get; set; }*/
    }
}