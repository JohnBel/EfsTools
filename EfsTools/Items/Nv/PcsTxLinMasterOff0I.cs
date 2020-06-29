using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(329)]
    [Attributes(9)]
    public sealed class PcsTxLinMasterOff0
    {
        public ushort Value { get; set; }
    }
}