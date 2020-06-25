using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(285)]
    [Attributes(41)]
    public sealed class EvrcVoiceServiceOptions
    {
        public byte Nam { get; set; }


        public byte EvrcCapabilityEnabled { get; set; }


        public ushort HomePageVoiceSo { get; set; }


        public ushort HomeOrigVoiceSo { get; set; }


        public ushort RoamOrigVoiceSo { get; set; }
    }
}