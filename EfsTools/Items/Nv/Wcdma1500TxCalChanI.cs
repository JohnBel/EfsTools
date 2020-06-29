using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6990)]
    [Attributes(9)]
    public sealed class Wcdma1500TxCalChan
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}