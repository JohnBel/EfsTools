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
        ProxyAuthorization = 2
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


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpSecIntScheme { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpSecEncAlgo { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte AuthScheme { get; set; }

        public string AuthSchemeString
        {
            get => $"{(AuthSchemeValues) AuthScheme}";
            set => AuthScheme = (byte) Enum.Parse(typeof(AuthSchemeValues), value);
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte InitialAuthConfig { get; set; }

        public string InitialAuthConfigString
        {
            get => $"{(InitialAuthConfigValues) InitialAuthConfig}";
            set => InitialAuthConfig = (byte) Enum.Parse(typeof(InitialAuthConfigValues), value);
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