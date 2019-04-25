using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(69744)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_extended_0_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsSipExtended0Config
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort SipLocalPort { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerSipRegValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerSipSubscribeValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerT1Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerT2Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerT4Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerTfValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerTJValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TcpThresholdValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CompactFormEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte SigCompEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IsSipInstanceNeeded { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpSecIntScheme { get; set; }

        public string IpSecIntSchemeString
        {
            get => $"{(IpSecIntegritySchemeValues) IpSecIntScheme}";
            set => IpSecIntScheme = EnumUtils.ParseEnumByte(typeof(IpSecIntegritySchemeValues), value);
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpSecEncAlgo { get; set; }

        public string IpSecEncAlgoString
        {
            get => $"{(IpSecEncryptionAlgorithmValues) IpSecEncAlgo}";
            set => IpSecEncAlgo = EnumUtils.ParseEnumByte(typeof(IpSecEncryptionAlgorithmValues), value);
        }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AuthScheme { get; set; }

        public string AuthSchemeString
        {
            get => $"{(AuthSchemeValues) AuthScheme}";
            set => AuthScheme = EnumUtils.ParseEnumByte(typeof(AuthSchemeValues), value);
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte InitialAuthConfig { get; set; }

        public string InitialAuthConfigString
        {
            get => $"{(InitialAuthConfigValues) InitialAuthConfig}";
            set => InitialAuthConfig = EnumUtils.ParseEnumByte(typeof(InitialAuthConfigValues), value);
        }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ShortCodeList { get; set; }

        public string ShortCodeListString
        {
            get => StringUtils.GetString(ShortCodeList);
            set => ShortCodeList = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ProxyRouteValue { get; set; }

        public string ProxyRouteValueString
        {
            get => StringUtils.GetString(ProxyRouteValue);
            set => ProxyRouteValue = StringUtils.GetBytes(value, 256);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte KeepAliveEnabled { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerNatRtoValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerVzW { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencySipRegValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencyT1Value { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencyT2Value { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencyT4Value { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencyTfValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerEmergencyTJValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CivicLocQueryTimeout { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort GpsLocFixQueryTimeout { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimerTbValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte GruuEnabled { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TransportSwitchEnabled { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TcpMaxBackOffTimer { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RouteHeaderEnabled { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte GzipDecodingOutBufferMultiplier { get; set; }

        [ElementsCount(424)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedBytes { get; set; }
    }
}