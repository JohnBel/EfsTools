using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [NvItemId(67259)]
    [EfsFile("/nv/item_files/ims/qp_ims_sms_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsSmsConfig
    {
        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] SmsConfigVDN { get; set; }

        public string SmsConfigVdnString
        {
            get => StringUtils.GetString(SmsConfigVDN);
            set => SmsConfigVDN = StringUtils.GetBytes(value, 128);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte SmsFormat { get; set; }


        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] SmsAcceptContact { get; set; }

        public string SmsAcceptContactString
        {
            get => StringUtils.GetString(SmsAcceptContact);
            set => SmsAcceptContact = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] SmsRatMaskStringValue { get; set; }

        public string SmsRatMaskString
        {
            get => StringUtils.GetString(SmsRatMaskStringValue);
            set => SmsRatMaskStringValue = StringUtils.GetBytes(value, 64);
        }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint RatMaskValue { get; set; }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] PhoneContextUri { get; set; }

        public string PhoneContextUriString
        {
            get => StringUtils.GetString(PhoneContextUri);
            set => PhoneContextUri = StringUtils.GetBytes(value, 256);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ISmsOverIpNetworkIndication { get; set; }
    }
}