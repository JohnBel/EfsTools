using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
        [Subscription]
    [NvItemId(67348)]
    [EfsFile("/nv/item_files/ims/qipcall_config_items", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallConfigItems
    {
        public QipcallConfigItems()
        {
            Version = 9;
        }

        [Required]
        public byte Version { get; set; }


        public byte EnableRtcpForActiveVoipCall { get; set; }


        public uint VtRtcpReportingInterval { get; set; }


        public byte RtpNbAmrPayloadType { get; set; }


        public byte RtpWbAmrPayloadType { get; set; }


        public byte RtpNbDtmpPayloadType { get; set; }


        public byte RtpWbDtmpPayloadType { get; set; }

        [JsonIgnore]
        [FieldCount(16)]
        public byte[] MediaAttribute { get; set; }

        public string MediaAttributeString
        {
            get => StringUtils.GetString(MediaAttribute);
            set => MediaAttribute = StringUtils.GetBytes(value, 16);
        }


        public byte DesiredQosStrength { get; set; }


        public byte CmrAmrNb { get; set; }


        public byte CmrAmrWb { get; set; }


        public byte EmergCallCsOnly { get; set; }


        public byte VideoMediaProfileMode { get; set; }


        public byte VideoCalls { get; set; }


        public byte MobileData { get; set; }


        [JsonIgnore]
        [FieldCount(128)]
        public byte[] AudioFeatureTag { get; set; }

        public string AudioFeatureTagString
        {
            get => StringUtils.GetString(AudioFeatureTag);
            set => AudioFeatureTag = StringUtils.GetBytes(value, 128);
        }

        [JsonIgnore]
        [FieldCount(128)]
        public byte[] VideoFeatureTag { get; set; }

        public string VideoFeatureTagString
        {
            get => StringUtils.GetString(VideoFeatureTag);
            set => VideoFeatureTag = StringUtils.GetBytes(value, 128);
        }

        [FieldCount(223)]
        public byte[] ReservedBytes { get; set; }
    }
}