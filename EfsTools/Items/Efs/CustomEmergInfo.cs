using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/custom_emerg_info", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CustomEmergInfo
    {
        [Required]
        public byte Version { get; set; }


        public byte IsEcbmRequired { get; set; }


        public byte HoldConcurrentVoiceCallDuringEmergency { get; set; }


        public byte IsAlternateRedialAlgorithm { get; set; }


        public ulong Reserved { get; set; }
    }
}