using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum AuthSchemeValues : byte
    {
        None = 0,
        Digest = 1,
        Sag = 2,
        Aka = 3,
        Cave = 4,
        AkaV2 = 5
    }

    public enum InitialAuthConfigValues : byte
    {
        None = 0,
        Authorization = 1,
        ProxyAuthorization = 2,
        Authorization_ProxyAuthorization = 3
    }

    public enum IpSecIntegritySchemeValues : byte
    {
        None = 0,
        HmacSha1_96 = 1,
        HmacMd5_96 = 2,
        HmacMd5Sha1_96 = 3
    }

    public enum IpSecEncryptionAlgorithmValues : byte
    {
        None = 0,
        Null = 1,
        AesCbc = 2,
        Null_AesCbc = 3,
        DesEde3Cbc = 4,
        Null_DesEde3Cbc = 5,
        AesCbc_DesEde3Cbc = 6,
        Null_AesCbc_DesEde3Cbc = 7,
    }
    
    [Serializable]
    [NvItemId(67262)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsSipConfig
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort SipLocalPort { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerSipRegValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerSipSubscribeValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerT1Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerT2Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerT4Value { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TimerTfValue { get; set; }


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
        public byte FmcConfig { get; set; }

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
        public byte[] AuthHeaderValue { get; set; }

        public string AuthHeaderValueString
        {
            get => StringUtils.GetString(AuthHeaderValue);
            set => AuthHeaderValue = StringUtils.GetBytes(value, 256);
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
    }
}