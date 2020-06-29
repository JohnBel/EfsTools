using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [NvItemId(70293)]
    [EfsFile("/nv/item_files/ims/qp_ims_vt_3G_media_capability", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsVt3GMediaCapability
    {
        [Required]
        public byte Version { get; set; }


        public byte NumH264 { get; set; }


        public byte H263ExcludeConfigFromOffer { get; set; }


        public ushort H263PayloadType { get; set; }


        public byte H263Profile { get; set; }


        public byte H263PreferredProfileLevel { get; set; }


        public byte H263PreferredResolution { get; set; }


        public uint H263ResolutionsSupported { get; set; }


        public ushort H263PreferredBitRate { get; set; }


        public ushort H263MinBitRate { get; set; }


        public ushort H263MaxBitRate { get; set; }


        public byte H263PreferredFrameRate { get; set; }


        public byte H263MinFrameRate { get; set; }


        public byte H263MaxFrameRate { get; set; }


        public ushort H263Ipv4AsValue { get; set; }


        public ushort H263Ipv6AsValue { get; set; }


        public byte H264ExcludeConfigFromOffer1 { get; set; }


        public ushort H264PayloadTypePacketization01 { get; set; }


        public ushort H264PayloadTypePacketization11 { get; set; }


        public byte H264Profile1 { get; set; }


        public byte H264PreferredProfileLevel1 { get; set; }


        public byte H264PreferredResolution1 { get; set; }


        public uint H264ResolutionsSupported1 { get; set; }


        public ushort H264PreferredBitRate1 { get; set; }


        public ushort H264MinBitRate1 { get; set; }


        public ushort H264MaxBitRate1 { get; set; }


        public byte H264PreferredFrameRate1 { get; set; }


        public byte H264MinFrameRate1 { get; set; }


        public byte H264MaxFrameRate1 { get; set; }


        public ushort H264Ipv4AsValue1 { get; set; }


        public ushort H264Ipv6AsValue1 { get; set; }


        public byte H264ExcludeConfigFromOffer2 { get; set; }


        public ushort H264PayloadTypePacketization02 { get; set; }


        public ushort H264PayloadTypePacketization12 { get; set; }


        public byte H264Profile2 { get; set; }


        public byte H264PreferredProfileLevel2 { get; set; }


        public byte H264PreferredResolution2 { get; set; }


        public uint H264ResolutionsSupported2 { get; set; }


        public ushort H264PreferredBitRate2 { get; set; }


        public ushort H264MinBitRate2 { get; set; }


        public ushort H264MaxBitRate2 { get; set; }


        public byte H264PreferredFrameRate2 { get; set; }


        public byte H264MinFrameRate2 { get; set; }


        public byte H264MaxFrameRate2 { get; set; }


        public ushort H264Ipv4AsValue2 { get; set; }


        public ushort H264Ipv6AsValue2 { get; set; }
    }
}