using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6850)]
    [Attributes(9)]
    public sealed class UmtsAmrCodecPreferenceConfig
    {
        public byte Value { get; set; }
    }
}