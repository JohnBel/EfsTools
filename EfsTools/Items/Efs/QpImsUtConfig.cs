using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(70263)]
    [EfsFile("/nv/item_files/ims/qp_ims_ut_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsUtConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [JsonIgnore]
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] ApnName { get; set; }

        public string ApnNameString
        {
            get => StringUtils.GetString(ApnName);
            set => ApnName = StringUtils.GetBytes(value, 64);
        }

        [JsonIgnore]
        [ElementsCount(256)] //Todo: check
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] DomainName { get; set; }

        public string DomainNameString
        {
            get => StringUtils.GetString(DomainName);
            set => DomainName = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [ElementsCount(256)] //Todo: check
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] AssociatedUri { get; set; }

        public string AssociatedUriString
        {
            get => StringUtils.GetString(AssociatedUri);
            set => AssociatedUri = StringUtils.GetBytes(value, 256);
        }


        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] ApplicationUid { get; set; }

        public string ApplicationUidString
        {
            get => StringUtils.GetString(ApplicationUid);
            set => ApplicationUid = StringUtils.GetBytes(value, 128);
        }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        [Optional]
        public uint RatConfig { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte IpAddrType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte RetryTimerValue { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte RetryAttemptCount { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte ApnType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte GbaUbType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte GbaUbMode { get; set; }

        [JsonIgnore]
        [ElementsCount(512)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] BsfAddr { get; set; }

        public string BsfAddrString
        {
            get => StringUtils.GetString(BsfAddr);
            set => BsfAddr = StringUtils.GetBytes(value, 512);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte DisableUt { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte GbaTlsMode { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        [Optional]
        public ushort PdnHysTimerValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        [Optional]
        public uint RatMaskValue { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte Apn2IpAddrType { get; set; }

        [JsonIgnore]
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        [Optional]
        public byte[] Apn2ApnName { get; set; }

        public string Apn2ApnNameString
        {
            get => StringUtils.GetString(Apn2ApnName);
            set => Apn2ApnName = StringUtils.GetBytes(value, 64);
        }
    }
}