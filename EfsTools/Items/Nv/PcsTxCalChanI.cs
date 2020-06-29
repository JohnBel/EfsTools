using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1310)]
    [Attributes(9)]
    public sealed class PcsTxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}