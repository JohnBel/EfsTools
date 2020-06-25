using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
        Null_AesCbc_DesEde3Cbc = 7
    }

    [Serializable]
    [Subscription]
    [NvItemId(67262)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsSipConfig
    {
        public ushort SipLocalPort { get; set; }


        public ushort TimerSipRegValue { get; set; }


        public ushort TimerSipSubscribeValue { get; set; }


        public ushort TimerT1Value { get; set; }


        public ushort TimerT2Value { get; set; }


        public ushort TimerT4Value { get; set; }


        public ushort TimerTfValue { get; set; }


        public ushort TcpThresholdValue { get; set; }


        public byte CompactFormEnabled { get; set; }


        public byte SigCompEnabled { get; set; }


        public byte FmcConfig { get; set; }

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
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] AuthHeaderValue { get; set; }

        public string AuthHeaderValueString
        {
            get => StringUtils.GetString(AuthHeaderValue);
            set => AuthHeaderValue = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] ProxyRouteValue { get; set; }

        public string ProxyRouteValueString
        {
            get => StringUtils.GetString(ProxyRouteValue);
            set => ProxyRouteValue = StringUtils.GetBytes(value, 256);
        }
    }
}