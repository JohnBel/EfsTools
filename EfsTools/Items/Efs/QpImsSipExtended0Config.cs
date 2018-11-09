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
        public ushort TimerT3Value { get; set; }


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
        public ushort TimerTJValue { get; set; }


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
        [Optional]
        public byte InitialAuthConfig { get; set; }

        public string InitialAuthConfigString
        {
            get => $"{(InitialAuthConfigValues) InitialAuthConfig}";
            set => InitialAuthConfig = (byte) Enum.Parse(typeof(InitialAuthConfigValues), value);
        }

        [JsonIgnore]
        [ElementsCount(2048)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] ShortCodeList { get; set; }

        public string ShortCodeListString
        {
            get => StringUtils.GetString(ShortCodeList);
            set => ShortCodeList = StringUtils.GetBytes(value, 2048);
        }

        [JsonIgnore]
        [ElementsCount(2048)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] ProxyRouteValue { get; set; }

        public string ProxyRouteValueString
        {
            get => StringUtils.GetString(ProxyRouteValue);
            set => ProxyRouteValue = StringUtils.GetBytes(value, 2048);
        }


        /*[ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint KeepAliveEnabled { get; set; }

        [ElementsCount(467)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedBytes { get; set; }*/
    }
}