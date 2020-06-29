using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
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