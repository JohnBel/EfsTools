using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [NvItemId(67259)]
    [EfsFile("/nv/item_files/ims/qp_ims_sms_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsSmsConfig
    {
        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] SmsConfigVDN { get; set; }

        public string SmsConfigVdnString
        {
            get => StringUtils.GetString(SmsConfigVDN);
            set => SmsConfigVDN = StringUtils.GetBytes(value, 128);
        }


        public byte SmsFormat { get; set; }


        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] SmsAcceptContact { get; set; }

        public string SmsAcceptContactString
        {
            get => StringUtils.GetString(SmsAcceptContact);
            set => SmsAcceptContact = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] SmsRatMaskStringValue { get; set; }

        public string SmsRatMaskString
        {
            get => StringUtils.GetString(SmsRatMaskStringValue);
            set => SmsRatMaskStringValue = StringUtils.GetBytes(value, 64);
        }


        public uint RatMaskValue { get; set; }

        [JsonIgnore]
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] PhoneContextUri { get; set; }

        public string PhoneContextUriString
        {
            get => StringUtils.GetString(PhoneContextUri);
            set => PhoneContextUri = StringUtils.GetBytes(value, 256);
        }


        public byte ISmsOverIpNetworkIndication { get; set; }
    }
}