using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [NvItemId(69744)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_extended_0_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsSipExtended0Config
    {
        [Required]
        public byte Version { get; set; }


        public ushort SipLocalPort { get; set; }


        public uint TimerSipRegValue { get; set; }


        public uint TimerSipSubscribeValue { get; set; }


        public uint TimerT1Value { get; set; }


        public uint TimerT2Value { get; set; }


        public uint TimerT4Value { get; set; }


        public uint TimerTfValue { get; set; }


        public uint TimerTJValue { get; set; }


        public ushort TcpThresholdValue { get; set; }


        public byte CompactFormEnabled { get; set; }


        public byte SigCompEnabled { get; set; }


        public byte IsSipInstanceNeeded { get; set; }

        [JsonIgnore]
        public byte IpSecIntScheme { get; set; }

        public string IpSecIntSchemeString
        {
            get => $"{(IpSecIntegritySchemeValues) IpSecIntScheme}";
            set => IpSecIntScheme = EnumUtils.ParseEnumByte(typeof(IpSecIntegritySchemeValues), value);
        }

        [JsonIgnore]
        public byte IpSecEncAlgo { get; set; }

        public string IpSecEncAlgoString
        {
            get => $"{(IpSecEncryptionAlgorithmValues) IpSecEncAlgo}";
            set => IpSecEncAlgo = EnumUtils.ParseEnumByte(typeof(IpSecEncryptionAlgorithmValues), value);
        }


        [JsonIgnore]
        public byte AuthScheme { get; set; }

        public string AuthSchemeString
        {
            get => $"{(AuthSchemeValues) AuthScheme}";
            set => AuthScheme = EnumUtils.ParseEnumByte(typeof(AuthSchemeValues), value);
        }

        [JsonIgnore]
        public byte InitialAuthConfig { get; set; }

        public string InitialAuthConfigString
        {
            get => $"{(InitialAuthConfigValues) InitialAuthConfig}";
            set => InitialAuthConfig = EnumUtils.ParseEnumByte(typeof(InitialAuthConfigValues), value);
        }

        [JsonIgnore]
        [FieldCount(256)]
        public byte[] ShortCodeList { get; set; }

        public string ShortCodeListString
        {
            get => StringUtils.GetString(ShortCodeList);
            set => ShortCodeList = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [FieldCount(256)]
        public byte[] ProxyRouteValue { get; set; }

        public string ProxyRouteValueString
        {
            get => StringUtils.GetString(ProxyRouteValue);
            set => ProxyRouteValue = StringUtils.GetBytes(value, 256);
        }


        public byte KeepAliveEnabled { get; set; }


        public uint TimerNatRtoValue { get; set; }


        public uint TimerVzW { get; set; }


        public uint TimerEmergencySipRegValue { get; set; }


        public uint TimerEmergencyT1Value { get; set; }


        public uint TimerEmergencyT2Value { get; set; }


        public uint TimerEmergencyT4Value { get; set; }


        public uint TimerEmergencyTfValue { get; set; }


        public uint TimerEmergencyTJValue { get; set; }


        public byte CivicLocQueryTimeout { get; set; }


        public ushort GpsLocFixQueryTimeout { get; set; }


        public uint TimerTbValue { get; set; }


        public byte GruuEnabled { get; set; }


        public byte TransportSwitchEnabled { get; set; }


        public uint TcpMaxBackOffTimer { get; set; }


        public byte RouteHeaderEnabled { get; set; }


        public byte GzipDecodingOutBufferMultiplier { get; set; }

        [FieldCount(424)]
        public byte[] ReservedBytes { get; set; }
    }
}