using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1953)]
    [Attributes(9)]
    public sealed class RfAntselGsm1900Rx
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}