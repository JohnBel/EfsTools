using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71597)]
    [EfsFile("/nv/item_files/ims/qipcall_qos_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallQosConfig
    {
        /*[ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }*/

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LocalQosAudio { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LocalQosVideo { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosInactiveInvite { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosInactiveReInvite { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosMbrAudioCheckReq { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosMbrVideoCheckReq { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint MbrThreshold { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte QosOptimization { get; set; }
    }
}