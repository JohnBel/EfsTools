using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6953)]
    [Attributes(9)]
    public sealed class Wcdma1500HdetSpn
    {
        public byte Value { get; set; }
    }
}