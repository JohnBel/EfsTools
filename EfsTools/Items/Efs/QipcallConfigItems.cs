using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    /*
     If I want config midcall_enable=1 and aSRVCC_enable=1,How can I config it? What does each configuration item mean? 

    NV67348 version to 25 or above 
    NV67348 srvcc_feature_tags to 0x07 
    SRVCC.midcall_enable1 (internally this will be stored to 0x01 "srvcc_feature_tags" in SW) 
    SRVCC.aSRVCC_enable1 (internally this will be stored to 0x02 "srvcc_feature_tags" in SW) 
    SRVCC.bSRVCC_enable1 (internally this will be stored to 0x07 "srvcc_feature_tags" in SW) 
     */

    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_config_items", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallConfigItems
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte EnableRtcpForActiveVoipCall { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint VtRtcpReportingInterval { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RtpNbAmrPayloadType { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RtpWbAmrPayloadType { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RtpNbDtmpPayloadType { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RtpWbDtmpPayloadType { get; set; }

        [JsonIgnore]
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] MediaAttribute { get; set; }

        public string MediaAttributeString
        {
            get => StringUtils.GetString(MediaAttribute);
            set => MediaAttribute = StringUtils.GetBytes(value, 16);
        }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DesiredQosStrength { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CmrAmrNb { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CmrAmrWb { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte EmergCallCsOnly { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoMediaProfileMode { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoCalls { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MobileData { get; set; }


        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] AudioFeatureTag { get; set; }

        public string AudioFeatureTagString
        {
            get => StringUtils.GetString(AudioFeatureTag);
            set => AudioFeatureTag = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] VideoFeatureTag { get; set; }

        public string VideoFeatureTagString
        {
            get => StringUtils.GetString(VideoFeatureTag);
            set => VideoFeatureTag = StringUtils.GetBytes(value, 128);
        }

        [ElementsCount(223)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] ReservedBytes { get; set; }
    }
}