using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4176)]
    [Attributes(9)]
    public sealed class GsmIm21800
    {
        [FieldCount(3)]
        public ushort[] Value1 { get; set; }

        [FieldCount(7)]
        public byte[] Value2 { get; set; }
    }
}