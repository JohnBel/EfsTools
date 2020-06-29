using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6956)]
    [Attributes(9)]
    public sealed class Wcdma1500PaCompensateDown
    {
        public short Value { get; set; }
    }
}