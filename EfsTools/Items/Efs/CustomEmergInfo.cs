using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/custom_emerg_info", true, 0xE1FF)]
    [Attributes(9)]
    public class CustomEmergInfo
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IsEcbmRequired { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte HoldConcurrentVoiceCallDuringEmergency { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IsAlternateRedialAlgorithm { get; set; }


        [ElementsCount(1)]
        [ElementType("uint64")]
        [Description("")]
        public ulong Reserved { get; set; }
    }
}