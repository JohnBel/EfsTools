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
    [NvItemId(70263)]
    [EfsFile("/nv/item_files/ims/qp_ims_ut_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsUtConfig
    {
        [Required]
        public byte Version { get; set; }

        [JsonIgnore]
        [FieldCount(64)]
        public byte[] ApnName { get; set; }

        public string ApnNameString
        {
            get => StringUtils.GetString(ApnName);
            set => ApnName = StringUtils.GetBytes(value, 64);
        }

        [JsonIgnore]
        [FieldCount(256)] //Todo: check
        public byte[] DomainName { get; set; }

        public string DomainNameString
        {
            get => StringUtils.GetString(DomainName);
            set => DomainName = StringUtils.GetBytes(value, 256);
        }

        [JsonIgnore]
        [FieldCount(256)] //Todo: check
        public byte[] AssociatedUri { get; set; }

        public string AssociatedUriString
        {
            get => StringUtils.GetString(AssociatedUri);
            set => AssociatedUri = StringUtils.GetBytes(value, 256);
        }


        [JsonIgnore]
        [FieldCount(128)]
        public byte[] ApplicationUid { get; set; }

        public string ApplicationUidString
        {
            get => StringUtils.GetString(ApplicationUid);
            set => ApplicationUid = StringUtils.GetBytes(value, 128);
        }


        public uint RatConfig { get; set; }


        public byte IpAddrType { get; set; }


        public byte RetryTimerValue { get; set; }


        public byte RetryAttemptCount { get; set; }


        public byte ApnType { get; set; }


        public byte GbaUbType { get; set; }


        public byte GbaUbMode { get; set; }

        [JsonIgnore]
        [FieldCount(512)]
        public byte[] BsfAddr { get; set; }

        public string BsfAddrString
        {
            get => StringUtils.GetString(BsfAddr);
            set => BsfAddr = StringUtils.GetBytes(value, 512);
        }


        public byte DisableUt { get; set; }


        public byte GbaTlsMode { get; set; }


        public ushort PdnHysTimerValue { get; set; }


        public uint RatMaskValue { get; set; }


        public byte Apn2IpAddrType { get; set; }

        [JsonIgnore]
        [FieldCount(64)]
        public byte[] Apn2ApnName { get; set; }

        public string Apn2ApnNameString
        {
            get => StringUtils.GetString(Apn2ApnName);
            set => Apn2ApnName = StringUtils.GetBytes(value, 64);
        }
    }
}