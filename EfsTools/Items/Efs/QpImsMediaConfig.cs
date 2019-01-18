using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    public enum VideoResolutionValues : byte
    {
        Invalid = 0,
        Sqcif = 1,
        Qcif = 2,
        Cif = 3,
        Qqvga = 4,
        Qvga = 5,
        Vga = 6
    }

    public enum VideoCodecValues : byte
    {
        Invalid = 0,
        Mpeg4Xvid = 1,
        Mpeg4 = 2,
        H263 = 3,
        H264 = 4
    }

    public enum H264ProfileValues : byte
    {
        Invalid = 0,
        Baseline = 1,
        Main = 2,
        Extended = 3,
        High = 4
    }

    public enum H264ProfileLevelValues : byte
    {
        Invalid = 0,
        Level1 = 1,
        Level1B = 2,
        Level11 = 3,
        Level12 = 4,
        Level13 = 5,
        Level2 = 6,
        Level21 = 7,
        Level22 = 8,
        Level3 = 9,
        Level31 = 10,
        Level32 = 11,
        Level4 = 12,
        Level41 = 13,
        Level42 = 14,
        Level5 = 15,
        Level51 = 16
    }
    
    [Serializable]
    [NvItemId(67332)]
    [EfsFile("/nv/item_files/ims/qp_ims_media_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsMediaConfig
    {
        public QpImsMediaConfig()
        {
            Reserved = new byte[498];
        }

        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoResolution { get; set; }

        public string VideoResolutionString
        {
            get => $"{(VideoResolutionValues) VideoResolution}";
            set => VideoResolution = EnumUtils.ParseEnum(typeof(VideoResolutionValues), value);
        }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort VideoEncodingBitRate { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte FramesPerSecond { get; set; }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte VideoCodec { get; set; }

        public string VideoCodecString
        {
            get => $"{(VideoCodecValues) VideoCodec}";
            set => VideoCodec = EnumUtils.ParseEnum(typeof(VideoCodecValues), value);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Sar { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Par { get; set; }

        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte H264Profile { get; set; }
        
        public string H264ProfileString
        {
            get => $"{(H264ProfileValues) H264Profile}";
            set => H264Profile = EnumUtils.ParseEnum(typeof(H264ProfileValues), value);
        }
        
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte H264ProfileLevel { get; set; }

        public string H264ProfileLevelString
        {
            get => $"{(H264ProfileLevelValues) H264ProfileLevel}";
            set => H264ProfileLevel = EnumUtils.ParseEnum(typeof(H264ProfileLevelValues), value);
        }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort IpSyncDropUpperLimit { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort IpSyncDropLowerLimit { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IpSyncEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjTimeWrapping { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjIbaMax { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjMaxFramesAtStart { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjMaxDelay { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjMinDelay { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjDelayByFrameCount { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjMaxFramesAtRun { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjMaxBumpedUpDelay { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QdjJitterIncrement { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort QdjTargetUnderflow { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort QdjDefaultJitter { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort QdjGoThroughThreshold { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort QdjDropThreshold { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Qmin { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte TxSystemDelay { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RxSystemDelay { get; set; }


        [ElementsCount(500)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}